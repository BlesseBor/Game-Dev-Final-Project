using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private bool isPlayerInRange = false;
    // [SerializeField] private GameObject portal;

    // Update is called once per frame
     void Update()
    {
        // Only flip the lever if the player is in range and the "F" key is pressed
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(this.gameObject);
            Debug.Log("Stone Destroyed");
            // portal.SetActive(true); // Uncomment if you have a portal to activate
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When the player enters the trigger zone, set the flag to true
        if (collision.gameObject.CompareTag("Player2"))
        {
            isPlayerInRange = true;
            Debug.Log("Player entered trigger zone");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // When the player exits the trigger zone, set the flag to false
        if (collision.gameObject.CompareTag("Player2"))
        {
            isPlayerInRange = false;
            Debug.Log("Player exited trigger zone");
        }
    }
}
