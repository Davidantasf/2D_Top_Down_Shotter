using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int totalHealth;
    public GameObject enemy;
    
    void Start()
    {
        health = totalHealth;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Bala")
        {
            Damage();
        }
    }
    public void Damage()
    {
        health = health - 1;
        SoundManager.PlaySound ("hurt");
        if (health <= 0)
        {
            Destroy(gameObject);
            
        }
    }
}
