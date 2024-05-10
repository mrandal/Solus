using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySword : MonoBehaviour
{
    [SerializeField] private float health;
    public float KnockbackForce;
    public Rigidbody2D rb;
    public Collider2D sword;
    public Collider2D otherEnemy;
    public GameObject spawn;
    public bool drop;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0f)
        {
            //dead
            Destroy(gameObject);
            if(drop)
            {
                spawn.SetActive(true);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other == sword)
        {
            Vector2 direction = transform.position - other.transform.position;
            Vector2 knockback = direction.normalized * KnockbackForce;
            rb.AddForce(knockback, ForceMode2D.Impulse);
        }
        if(other == otherEnemy)
        {
            Vector2 direction = transform.position - other.transform.position;
            Vector2 knockback = direction.normalized * KnockbackForce/2;
            rb.AddForce(knockback, ForceMode2D.Impulse);
        }
    }
}
