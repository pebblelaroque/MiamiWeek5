using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;

    [SerializeField]
    private Button joinPlayerTwo;

    [SerializeField]
    private Text playerOneText;

    [SerializeField]
    private Text playerTwoText;

    [SerializeField]
    private GameObject playerOne;

    //TODO: Add PlayerTwoButton reference **DONE**

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;

    public bool playerOneExists = false;

    public bool playerTwoExists = false;

    // Start is called before the first frame update
    void Start()
    {
    
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
        //TODO Listen for player two click event **DONE**
    }

    private void JoinPlayerOne()
    {
        if(playerOneExists == false)
        {
            playerInputManager.JoinPlayer(0, "Keyboard&Mouse");
            playerOneText.text = "Leave Player 1";
            playerOneExists = true;
        }
        else
        {
            playerOneText.text = "Join Player 1";
            playerInputManager.LeavePlayer(0);
            playerOneExists = false;
        }
        
        //TODO flip text to say "Leave Player One" **DONE**
        //TODO on click after player has joined, remove player **DONE**
      
    }

    private void JoinPlayerTwo()
    {
        if (playerTwoExists == false)
        {
            playerInputManager.JoinPlayer(1, "PlayerTwo");
            playerTwoText.text = "Leave Player 2";
            playerTwoExists = true;
        }
        else
        {
            playerTwoText.text = "Join Player 2";
            playerInputManager.LeavePlayer(1);
            playerTwoExists = false;
        }
        
    }


    //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme **DONE**
    //TODO flip text after player has joined to say "Leave Player Two" **DONE**
    //TODO on click after player has joined, remove player **DONE**
}
