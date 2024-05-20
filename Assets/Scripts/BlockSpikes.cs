using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpikes : MonoBehaviour
{
[SerializeField] private float damage = 10f;

    void Start()
    {
        // Initialization code if needed
    }

    void Update()
    {
        // Update code if needed
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Spike Trigger");

        if (collision.gameObject.CompareTag("Player1"))
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
            else
            {
                Debug.LogWarning("No Health component found on the collided object");
            }
        }
    }

    // public void TakeDamage(float damage)
    // {
}
