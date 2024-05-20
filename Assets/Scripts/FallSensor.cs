using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSensor : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] private float damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player Fell");
        if(collision.tag == "Player1" || collision.tag == "Player2")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            // Destroy(collision.gameObject);
        }
    }
}
