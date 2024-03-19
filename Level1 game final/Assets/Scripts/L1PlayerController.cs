using UnityEngine;

public class L1PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    private int touchCount = 0; // Variable to track the number of touches
    private Rigidbody2D rb;
    public GameObject popupQuestion; // Reference to the popup question GameObject

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            // Increment the touch count
            touchCount++;
            Debug.Log("Touch Count: " + touchCount);

            // Check if the enemy is defeated after 3 touches
            if (touchCount >= 3)
            {
                Destroy(collision.gameObject);
                Debug.Log("Enemy Defeated!");

                // Show the popup question window when the enemy is defeated
                popupQuestion.SetActive(true);

                touchCount = 0; // Reset the touch count
            }
        }
    }
}
