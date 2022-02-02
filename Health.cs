using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite Heart;
    public Sprite HeartHollow;

    public GameObject GameOver;
    public GameObject drop;
    public GameObject dropd;
    public GameObject dropt;
    public GameObject dropq;
    public GameObject dropc;
    public GameObject drops;

    void Start()
    {
        health = numOfHearts;
    }
    public void Update() 
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = Heart;
            }
            else 
            {
                hearts[i].sprite = HeartHollow;
            }
            if (i < numOfHearts) 
            {
                hearts[i].enabled = true;
            }
            else 
            {
                hearts[i].enabled = false;
            }
        }
        if (health <= 0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Bala")
        {
            TakeDamage();
        }
        if (collider.tag == "Heart")
        {
            health = health + 1;
            Destroy(drop);
        }
        if (collider.tag == "Heart2")
        {
            health = health + 1;
            Destroy(dropd);
        }
        if (collider.tag == "Heart3")
        {
            health = health + 1;
            Destroy(dropt);
        }
        if (collider.tag == "Heart4")
        {
            health = health + 1;
            Destroy(dropq);
        }
        if (collider.tag == "Heart5")
        {
            health = health + 1;
            Destroy(dropc);
        }
        if (collider.tag == "Heart6")
        {
            health = health + 1;
            Destroy(drops);
        }
    }
    public void TakeDamage()
    {
        health = health - 1;
        print("Levou Dano");
        SoundManager.PlaySound ("hurt");
    }
    
    
}


