using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriptt : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    [SerializeField]
    int damage;
    Rigidbody2D rb2d;
    [SerializeField]
    public CommonEnemy enemy;


    public void StartShooting(bool isFacingLeft)
    {
        
        rb2d = GetComponent<Rigidbody2D>();

        if (isFacingLeft)
        {
            rb2d.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb2d.velocity = new Vector2(speed, 0);
        }
        
        
       Destroy(gameObject, 5f);
    }
    /*
    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
      CommonEnemy enemy = hitInfo.GetComponent<CommonEnemy>();
      if (enemy != null)
      {
          enemy.TakeDamage(1);
      }
      Destroy(gameObject);

    }
    */
    private void Collision2D (Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
      {
        Destroy(gameObject);
      }
        if(collision.CompareTag("Enemy"))
      {
        Destroy(gameObject);
      }
    }
}
