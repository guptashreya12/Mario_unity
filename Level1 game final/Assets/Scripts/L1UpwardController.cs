using UnityEngine;

public class L1UpwardController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private bool isTouchingGround = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get the player's input for movement (e.g., WASD or arrow keys).
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the desired movement vector.
        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);
        moveDirection.Normalize();

        // Apply the movement.
        rb.velocity = moveDirection * moveSpeed;

        // Prevent upward movement when colliding with the GroundisTouchingGround.
        if (isTouchingGround && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player has collided with the GroundisTouchingGround.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isTouchingGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player has stopped colliding with the GroundisTouchingGround.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isTouchingGround = false;
        }
    }
}
