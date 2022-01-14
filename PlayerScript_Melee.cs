
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using UnityEngine.SceneManagement;

public class PlayerScript_Melee : MonoBehaviour
{
    [SerializeField]
    private float runSpeed;

    [SerializeField]
    public Transform groundCheck;
    [SerializeField]
    private float jumpForce;
    private Animator animator;
    Collider2D col2D;
    private string currentAnimaton;
    private float xAxis;
    private float yAxis;
    private Rigidbody2D rb2d;
    private bool isJumpPressed;
    private bool isGrounded;
    private bool isAttackPressed;
    private bool isAttacking;
    private bool isntDead;
    private bool TakingDamage;
    private bool ControlPressedLeft;
    private bool ControlPressedRight;
    [SerializeField]
    AudioSource StabMusic;
    [SerializeField]
    AudioSource DodgeMusic;
    [SerializeField]
    AudioSource DamageMusic;
    public AudioSource BackGroundM;
    public bool isFacingLeft = false;
    [SerializeField]
    public Transform Damage_Box;
    public float attackRange;
    public LayerMask Enemies;
    [SerializeField]
    private float attackDelay = 0f;
    private float damageDelay;
    public int Playerhealth;
    public int Playerblood = 0;
    public int damage = 1;
    private Vector3 dashVc3;

    //Animation States
    const string PLAYER_IDLE = "Player_Idle";
    const string PLAYER_DODGEBACKWARD = "Player_DodgeBackward";
    const string PLAYER_DODGEFORWARD = "Player_DodgeForward";
    const string PLAYER_RUN = "Player_Run";
    const string PLAYER_JUMP = "Player_Jump_Gun";
    const string PLAYER_ATTACK = "Player_Attack";
    const string PLAYER_AIR_ATTACK = "Player_Jump_Firing";
    const string PLAYER_DEATH = "Player_Death";
    const string PLAYER_TAKEDAMAGE = "Player_TakeDamage";

    //=====================================================
    // Start is called before the first frame update
    //=====================================================
    void Start()
    {
        isntDead = true;
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        AudioSource StabMusic = GameObject.Find("StabMusic").GetComponent<AudioSource>();
        AudioSource DamageMusic = GameObject.Find("DamageMusic").GetComponent<AudioSource>();
        AudioSource DodgeMusic = GameObject.Find("DodgeMusic").GetComponent<AudioSource>();
        AudioSource BackGroundM = GameObject.Find("BackGroundMusic").GetComponent<AudioSource>();
    }
    void Update()
    {

        if (Playerhealth <= 0)
        {
            isntDead = false;
            ChangeAnimationState(PLAYER_DEATH);
            Invoke("Die", 2f);
            SceneManager.LoadScene(0);


        }
        //Checking for inputs
        xAxis = Input.GetAxisRaw("Horizontal");
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (!isAttacking && !TakingDamage)
            {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
            isFacingLeft = false;
            }

        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (!isAttacking && !TakingDamage)
            {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            isFacingLeft = true;
            }
        }else if (isGrounded)
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        
        
        //space jump key pressed?
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            isJumpPressed = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ControlPressedLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ControlPressedRight = true;
        }

        //space Atatck key pressed?
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isAttackPressed = true;
            Debug.Log("attackpressed");
        }
    }
    //=====================================================
    // Physics based time step loop
    //=====================================================
    private void FixedUpdate()
    {
        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("ground")))
        {
            isGrounded = true;
            Debug.Log("isGROUNDED");
        }
        else
        {
            isGrounded = false;
        }

        //------------------------------------------
        
        if (isGrounded && !isAttacking && isntDead && !TakingDamage)
        {   
            if (ControlPressedLeft)
            {
                float dash = transform.position.x;
                transform.position = new Vector3(dash + -10f,transform.position.y,transform.position.z);
                Debug.Log("DASHED_Player");
                BackGroundM.volume = 0.6f;
                DodgeMusic.Play();
                ChangeAnimationState(PLAYER_DODGEBACKWARD);
                ControlPressedLeft = false;
                BackGroundM.volume = 1f;
            }
            if (ControlPressedRight)
            {
                float dash = transform.position.x;
                transform.position = new Vector3(dash + 10f,transform.position.y,transform.position.z);
                BackGroundM.volume = 0.6f;
                DodgeMusic.Play();
                ChangeAnimationState(PLAYER_DODGEFORWARD);
                ControlPressedRight = false;
                BackGroundM.volume = 1f;
            }
            if (xAxis != 0)
            {
                ChangeAnimationState(PLAYER_RUN);
            }
            else
            {
                ChangeAnimationState(PLAYER_IDLE);
            }
            
        }


        //Check if trying to jump 
        if (isJumpPressed && isGrounded)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
            isJumpPressed = false;
            ChangeAnimationState(PLAYER_JUMP);
        }
        //attack
        if (isAttackPressed)
        {
            isAttackPressed = false;

            if (!isAttacking)
            {
                isAttacking = true;
                Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(Damage_Box.position, attackRange, Enemies);
                //for giving every one of enemies damage.
                for (int i = 0; i < enemiesInRange.Length; i++)
                {
                enemiesInRange[i].GetComponent<CommonEnemy>().TakeDamage(damage);
                Debug.Log("damage givenby player");
                }
                    BackGroundM.volume = 0.6f;
                    StabMusic.Play();
                if(isGrounded)
                {
                    ChangeAnimationState(PLAYER_ATTACK);

                }
                else
                {
                    ChangeAnimationState(PLAYER_AIR_ATTACK);
                }
                attackDelay = animator.GetCurrentAnimatorStateInfo(0).length + 0.2f;
                Invoke("AttackComplete", attackDelay);
            }
        }
    }
    /*IEnumerator AttackStart()
    {
        Damage_Box.SetActive(true);
        yield return new WaitForSeconds(.4f);
        Damage_Box.SetActive(false);
        isAttacking = false;
    }*/

    void AttackComplete()
    {
        isAttacking = false;
        BackGroundM.volume = 1f;
        Debug.Log("ATTACKCOMPLETE");
    }
    public void Die()
    {
        Destroy(gameObject);
    }
    public void PlayerTakeDamage(int damage)
    {
        BackGroundM.volume = 0.6f;
        TakingDamage = true;
        Playerhealth -= damage;
        Debug.Log("damageTakenbyplayer");
        DamageMusic.Play();
        ChangeAnimationState(PLAYER_TAKEDAMAGE);
        damageDelay = animator.GetCurrentAnimatorStateInfo(0).length + 1f;
        Invoke("DamageDelayComplete", damageDelay);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Damage_Box.position, attackRange);
    }
    void DamageDelayComplete()
    {
        BackGroundM.volume = 1f;
        TakingDamage = false;
    }

    //=====================================================
    // mini animation manager
    //=====================================================
    void ChangeAnimationState(string newAnimation)
    {
        if (currentAnimaton == newAnimation) return;

        animator.Play(newAnimation);
        currentAnimaton = newAnimation;
    }

}
