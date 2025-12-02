using UnityEngine;

public class Player : MonoBehaviour
{
    //public Fields
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private bool isInvulnerable = false;
    //[SerializeField] private float jumpForce = 10f;
    //private float moveSpeed = 5f; // ค่า speed การเคลื่อนที่พื้นฐาน
    private float jumpForce = 10f; // ค่าแรงกระโดดพื้นฐาน
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //1. movement 
        float moveInput = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        //2. jump (No Ground Check Required)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Landed on the ground.");
        }

    }
    public void SetMoveSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
        Debug.Log("Move speed set to: " + moveSpeed);
    }

    public void SetInvulnerability(bool isEnabled)
    {
        Debug.Log("Invulnerability set to: " + isEnabled);
    }


}

