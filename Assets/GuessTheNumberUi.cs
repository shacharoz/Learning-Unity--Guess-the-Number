using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberUi : MonoBehaviour {

    public InputField UserInputField;
    public Text PcResponseTextField;

    public string myname;

    private int intRandomNumber;

    // Use this for initialization
    void Start()
    {
        StartNewGame();
    }

    public void StartNewGame()
    {
        // Pick a random number
        intRandomNumber = Random.Range(1, 10);

        // Set the text to start the game
        Debug.Log("Guess a number between 1 and 10");
        PcResponseTextField.text = "Guess a number between 1 and 10";
    }

    public void CheckNumbers()
    {
        // find the number the user guesses
        int intGuessedNumber = System.Convert.ToInt32(UserInputField.text);
        
        if (intRandomNumber > intGuessedNumber)
        {
            Debug.Log("You guessed " + intGuessedNumber + ". You are too low");
            PcResponseTextField.text = "You guessed " + intGuessedNumber + ". You are too low";
        }
        if (intRandomNumber < intGuessedNumber)
        {
            Debug.Log("You guessed " + intGuessedNumber + ". You are too high");
            PcResponseTextField.text = "You guessed " + intGuessedNumber + ". You are too high";
        }
        if (intRandomNumber == intGuessedNumber)
        {
            Debug.Log("You guessed " + intGuessedNumber + ". You are CORRECT!");
            Debug.Log("Remember you can start a new game with a spacebar click");
            PcResponseTextField.text = "You guessed " + intGuessedNumber + ". You are CORRECT!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        // Hitting the spacebar always restarts the game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitializeGame();
        }

        CheckNumbers();
        */
    }
}
