using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int levelToChange;
    [SerializeField] private GameObject completeLevel;
    [SerializeField] private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            // SceneManager.LoadScene(levelToChange);
            // Time.timeScale = 0; // pause
            
            // completeLevel.gameObject.SetActive(true);
            gameManager.DisplayCompleteLevel();
            
            Debug.Log("Interacted w/ Portal!");
            
        }
    }
}
