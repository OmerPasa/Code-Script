using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;                
     
    private Rigidbody2D rb2d;        
    
    Animator Animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        
        float moveVertical = Input.GetAxis ("Vertical");
        if(Input.GetMouseButtonDown(0)==true)
        {
        Animator.SetBool("Fire",true);
        }else
        {
         Animator.SetBool("Fire",false);
        }
    
        Vector2 movement = new Vector2(0,moveVertical);
        rb2d.AddForce (movement * speed);
    }
}