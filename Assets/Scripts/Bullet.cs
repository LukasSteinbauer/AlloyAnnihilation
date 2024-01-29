using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //configuration of the bullets travel speed

    public float speed = 20f;
    public int damage = 34;
    public Rigidbody2D rb;

    //Start is called before the first frame update -- making the bullet travel away from t he barrel of the gun
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //When the bullet hits something, destroy the bullet + display what you hit in the console
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<EnemyBehaviour>(out EnemyBehaviour enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }

        Destroy(gameObject);
    }
}
