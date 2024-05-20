using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private GameManager gameManager;
    public float currentHealth{get; private set;}
    private Animator playerAnimator;
    private bool dead;
    private PlayerRespawn respawnPlayer;

    void Start()
    {
        playerAnimator = GetComponent<Animator>(); 
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Awake()
    {
        currentHealth = startingHealth;
        respawnPlayer = GetComponent<PlayerRespawn>();
    }

    public void TakeDamage(float _damage)
    {
        
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth > 0)
        {
            playerAnimator.SetTrigger("isHurt");
            Debug.Log("Hurt");
        }
        else
        {
            if(!dead)
            {
                playerAnimator.SetTrigger("isDead");
                GetComponent<PlayerController>().enabled = false;
                dead = true;

            }
           
        }
    }

    public void AddHealth(float _value)
    {   
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    public void Respawn()
    {
        dead = false;
        AddHealth(startingHealth);
        GetComponent<PlayerController>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            AddHealth(1);
        }

        if(dead)
        {
            Respawn();
            // respawnPlayer.Respawn();
            gameManager.DisplayGameOver();

        }
    }
}
