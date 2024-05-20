using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    
    [SerializeField] PlayerController playerController;
    [SerializeField] PlayerController player2Controller;
    // [SerializeField] PlayerController player3Controller;
    [SerializeField] GameObject camera1;
    [SerializeField] GameObject camera2;
    // [SerializeField] GameObject camera3;
    private int activePlayer = 1;

    void Start()
    {
        camera1 = GameObject.FindGameObjectWithTag("State-Driven Camera");
        camera2 = GameObject.FindGameObjectWithTag("State-Driven Camera2");
        // camera3 = GameObject.FindGameObjectWithTag("State-Driven Camera3");

        SwitchToPlayer(1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchToPlayer(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchToPlayer(2);
        }
        // else if (Input.GetKeyDown(KeyCode.Alpha3))
        // {
        //     SwitchToPlayer(3);
        // }
    }

    void SwitchToPlayer(int playerNumber)
    {
        playerController.enabled = false;
        player2Controller.enabled = false;
        // player3Controller.enabled = false;
        camera1.SetActive(false);
        camera2.SetActive(false);
        // camera3.SetActive(false);

        switch (playerNumber)
        {
            case 1:
                playerController.enabled = true;
                camera1.SetActive(true);
                activePlayer = 1;
                break;
            case 2:
                player2Controller.enabled = true;
                camera2.SetActive(true);
                activePlayer = 2;
                break;
            // case 3:
            //     player3Controller.enabled = true;
            //     camera3.SetActive(true);
            //     activePlayer = 3;
            //     break;
        }
    }
}


// // Start is called before the first frame update
    // [SerializeField] PlayerController playerController;
    // [SerializeField] PlayerController player2Controller;
    // [SerializeField] GameObject camera1;
    // [SerializeField] GameObject camera2;
    // private bool player1Active = true;
    // void Start()
    // {
    //     // playerController = GetComponent<PlayerController>();
    //     // player2Controller = GetComponent<PlayerController>();
    //     camera1 =  GameObject.FindGameObjectWithTag("State-Driven Camera");
    //     camera2 =  GameObject.FindGameObjectWithTag("State-Driven Camera2");
    //     camera1.SetActive(true);
    //     camera2.SetActive(false);
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.LeftShift))
    //     {
    //         SwitchPlayer();
    //     }
    // }

    // void SwitchPlayer()
    // {
    //     if(player1Active)
    //     {
    //         playerController.enabled = false;
    //         player2Controller.enabled = true;
    //         player1Active = false;
    //         camera1.SetActive(false);
    //         camera2.SetActive(true);

    //     }
    //     else
    //     {
    //         playerController.enabled = true;
    //         player2Controller.enabled = false;
    //         player1Active = true;
    //         camera1.SetActive(true);
    //         camera2.SetActive(false);
    //     }
    // }