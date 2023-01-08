using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;

    float yPos;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    //int dies = 0;

    public CinemachineCameraShaker camShake;
    //public GameObject Border;
    //public Text diesText;

    private void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0 || facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && extraJumps > 0)
        {
            yPos = transform.position.y;
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            extraJumps--;
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && extraJumps == 0 && isGrounded == true)
        {
            yPos = transform.position.y;
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }   
        rb.gravityScale = 1 + (transform.position.y - yPos);
        if (rb.gravityScale < 1)
        {
            rb.gravityScale = 1;
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Border)
        {
            dies++;
            //diesText.text = "Dies: " + dies;
            this.gameObject.transform.position = new Vector3(-0.3969f, -2.1013f, 0);
        }
    }*/

    void Flip()
    {
        camShake.ShakeCamera(0.5f, 5f, 5f);
        facingRight = !facingRight;
        Vector3 Scalar = transform.localScale;
        Scalar.x *= -1;
        transform.localScale = Scalar;
    }
}
