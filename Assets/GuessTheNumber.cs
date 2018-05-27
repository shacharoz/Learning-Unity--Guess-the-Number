using UnityEngine;

public class GuessTheNumber : MonoBehaviour {

    private int intRandomNumber;

    // Use this for initialization
    void Start () {

        InitializeGame();

    }

    private void InitializeGame()
    {
        // Pick a random number
        intRandomNumber = Random.Range(1, 10);

        // Set the text to start the game
        Debug.Log("Guess a number between 1 and 10");
    }


    // Update is called once per frame
    void Update()
    {
        // Hitting the spacebar always restarts the game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitializeGame();
        }


        // find the number the user guesses
        int intGuessedNumber = 0;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            intGuessedNumber = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            intGuessedNumber = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            intGuessedNumber = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            intGuessedNumber = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            intGuessedNumber = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            intGuessedNumber = 6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            intGuessedNumber = 7;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            intGuessedNumber = 8;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            intGuessedNumber = 9;
        }


        if (intGuessedNumber > 0)
        {
            if (intRandomNumber > intGuessedNumber)
            {
                Debug.Log("You guessed " + intGuessedNumber + ". You are too low");
            }
            if (intRandomNumber < intGuessedNumber)
            {
                Debug.Log("You guessed " + intGuessedNumber + ". You are too high");
            }
            if (intRandomNumber == intGuessedNumber)
            {
                Debug.Log("You guessed " + intGuessedNumber + ". You are CORRECT!");
                Debug.Log("Remember you can start a new game with a spacebar click");
            }
        }
    }
}
