using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{       

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard Game Mate!");
        Debug.Log("Highest number you can pick is : " + max);
        Debug.Log("Lowest number you can pick is : " + min);
        Debug.Log("Pick a Number Now");
        Debug.Log("I'll try to guess a number you picked up!");
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("So, Your number is Higher!");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("So, Your number is Lower!");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("My Guess is correct!");
            StartGame();
        }
        
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + guess);
    }
}
