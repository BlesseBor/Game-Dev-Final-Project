using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLever : MonoBehaviour
{
    private bool isPlayerInRange = false;
    [SerializeField] private GameObject portal;

    // Update is called once per frame
    void Update()
    {
        // Only flip the lever if the player is in range and the "F" key is pressed
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.F))
        {
            Vector3 currentScale = transform.localScale;
            currentScale.y *= -1; // Flip the lever by changing its vertical scale
            transform.localScale = currentScale;
            
            Debug.Log("Lever Flipped");
            portal.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // When the player enters the trigger zone, set the flag to true
        if (collision.CompareTag("Player1"))
        {
            isPlayerInRange = true;
            Debug.Log("Player entered trigger zone");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // When the player exits the trigger zone, reset the flag to false
        if (collision.CompareTag("Player1"))
        {
            isPlayerInRange = false;
            Debug.Log("Player exited trigger zone");
        }
    }

}
