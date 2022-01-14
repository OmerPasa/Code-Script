using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanAI : MonoBehaviour
{
    public float viewRange;
    public float minRange;
    public float closeAttackRange;
    public float closeAttackTime;
    public float bulletRange;
    public float bulletTime;
    public float movementSpeed;
    public float jumpPower;
    public float jumpTime;
    //public bool isFacingLeft = false;
    public GameObject character;
    public GameObject bullet;

    float closeATime2 = 0;
    float bulletTime2 = 0;
    float jumpTime2 = 0;
    bool grounded = true;
    bool pathBlocked = false;
    bool StopMoving;

    float tempX = 10000;
    float tempY = 0;
    private Animator animator;

    // Update is called once per frame
    void Start() 
    {
        animator = GetComponent<Animator>();   
    }
    void Update()
    {
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Enemy_Attack") || this.animator.GetCurrentAnimatorStateInfo(0).IsName("Enemy_TakeDamage"))
        {
            StopMoving = true;
        }else
        {
            StopMoving = false;
        }
        Vector3 karPos = character.transform.position;
        Vector3 pos = transform.position;
        if (Mathf.Abs(karPos.x - pos.x)< viewRange) 
        {
            if (!StopMoving)
            {
                moveTowardCharacter(karPos, pos);
            }
            
        }
        if (Mathf.Abs(karPos.x - pos.x) < closeAttackRange)
        {
            //closeAttack();
        }
        else if (Mathf.Abs(karPos.x - pos.x) < bulletRange)
        {
           // shoot(karPos, pos);
        }


        if (pos.y != tempY) { grounded = false; } 
        else { grounded = true; }

    }
   
    void moveTowardCharacter(Vector3 karPos, Vector3 pos)
    {
        if (Mathf.Abs(karPos.x - pos.x) > minRange && !(pathBlocked&&grounded))
        {
            Rigidbody2D rb2d = gameObject.GetComponent<Rigidbody2D>();
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((karPos.x - pos.x) * movementSpeed / Mathf.Abs(karPos.x - pos.x), rb2d.velocity.y);

            transform.localScale = new Vector3((karPos.x - pos.x) / Mathf.Abs(karPos.x - pos.x), 1, 1);
            //isFacingLeft = false;
        }
        else if ((pathBlocked && grounded))
        {
            jump();
        }
    }

    void jump ()
    {
        if (jumpTime - (Time.realtimeSinceStartup - jumpTime2) <= 0 )
        {
            jumpTime2 = Time.realtimeSinceStartup;

            gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2(0f, jumpPower);

        }
    }

    void closeAttack()
    {
        //gettingDamage
        //animation
        if (closeAttackTime - (Time.realtimeSinceStartup - closeATime2) <= 0)
        {
            Debug.Log("hit");
            closeATime2 = Time.realtimeSinceStartup;
        }
    }

    void shoot(Vector3 karPos, Vector3 pos)
    {

        if (bulletTime - (Time.realtimeSinceStartup - bulletTime2) <= 0)
        {
            bulletTime2 = Time.realtimeSinceStartup;
            Debug.Log("fire");//ate�

            Vector3 a = (karPos - pos);
            GameObject bulletClone = (GameObject)Instantiate(bullet, pos + transform.right * 0.5f + new Vector3(0, 0, -0.21f), transform.rotation);
            bulletClone.transform.up = new Vector3(a.x, a.y, 0); 
            bulletClone.GetComponent<BulletScriptt>().StartShooting(a.x<0);


        }
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.tag == "block")
        {
            pathBlocked = true;
            jump();
        }
        
    }
    void OnTriggerExit2D(Collider2D temas)
    {
        if (temas.tag == "block")
        {
            pathBlocked = false;
        }
    }



}
