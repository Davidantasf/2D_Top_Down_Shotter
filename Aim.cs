using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public float Range;
    public Transform Target;
    bool Detected = false;
    Vector2 Direction;
    public GameObject Gun;
    public Rigidbody2D Enemy;
    public Transform FirePoint;
    public GameObject BulletPrefab;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public float bulletForce = 20f;
    public int totalHealth;
    public int health;
    

    // Start is called before the first frame update
    void Start()
    {
        health = totalHealth;
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = Target.position;
        Direction = targetPos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Range);
        if (rayInfo)
        {
            if(rayInfo.collider.gameObject.tag == "Player")
            {
                if(Detected == false)
                {
                    Detected = true;
                }


            }
            else 
            {
                if (Detected == true)
                {
                    Detected = false;
                }
            }
            if(Detected)
            {
                Gun.transform.up = Direction;
                Enemy.transform.up = Direction;
                if(timeBtwShots <= 0)
            {
                timeBtwShots = startTimeBtwShots;
                Shoot();
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
            }
            
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Impulse);
        SoundManager.PlaySound ("tiro");
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
