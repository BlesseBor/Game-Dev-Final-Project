using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbs : MonoBehaviour
{
    // Start is called before the first frame update
    // private GameManager gameManager;
    [SerializeField] private int scoreValue;
    void Start()
    {
        // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Obtained Orb");
        if(collision.tag == "Player1")
        {
            // collision.GetComponent<Health>().TakeDamage(damage);
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().UpdateScore(scoreValue); // update score when clicked
            Destroy(this.gameObject);
        }
    }
}
