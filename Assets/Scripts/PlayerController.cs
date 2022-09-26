using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    public float jumpForce;


    public Transform groundCheck;
    bool isGrounded = false;
    public float groundDistance;
    public LayerMask whatIsGround;
    public Vector2 moving;

    private Animator anim;

    public float moveHorizontal;
    [SerializeField] private Transform shotpos;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float fireSpeed;
    private bool isRotate = false;

    public AudioClip jumpA;
    public AudioClip run;
    public AudioSource audi;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audi = GetComponent<AudioSource>();
    }

    void Update()
    {
        Jump();
        Shooting();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        moveHorizontal = Input.GetAxis("Horizontal");

        moving = new Vector2(moveHorizontal * speed, rb.velocity.y);

        rb.velocity = moving;

        if (moveHorizontal > 0)
        {
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("IsRunning", true);
            isRotate = false;
        }
        if (moveHorizontal < 0)
        {
            transform.localScale = new Vector2(-1, 1);
            anim.SetBool("IsRunning", true);
            isRotate = true;
        }
        if (moveHorizontal == 0)
        {
            anim.SetBool("IsRunning", false);
        }
    }

    void Jump() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundDistance, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            anim.SetTrigger("IsJump");
            audi.PlayOneShot(jumpA);
        }
    }

    void Shooting() 
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(isRotate == false) 
            {
                GameObject thisBullet = Instantiate(Bullet, shotpos.transform.position, Quaternion.identity);
                Rigidbody2D thisBulletRb = thisBullet.GetComponent<Rigidbody2D>();
                thisBulletRb.velocity = new Vector2(fireSpeed * 1, thisBulletRb.velocity.y);

            }
            else if (isRotate == true)
            {
                GameObject thisBullet = Instantiate(Bullet, shotpos.transform.position, Quaternion.Euler(0,-180,0));
                Rigidbody2D thisBulletRb = thisBullet.GetComponent<Rigidbody2D>();
                thisBulletRb.velocity = new Vector2(fireSpeed * -1, thisBulletRb.velocity.y);
            }
        }
    }
}
