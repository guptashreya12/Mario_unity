using UnityEngine;
using TMPro;

public class L1PlayerMovement : MonoBehaviour
{
    public static L1PlayerMovement instance; // Singleton instance
    private int score;
    private new Rigidbody2D rigidbody;
    public TextMeshProUGUI scoreText;
    public Vector2 velocity;
    private float inputAxis;

    public float moveSpeed = 8f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        score = 0;
        SetScoreText();
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }

    private void Update()
    {
        HorizontalMovement();
    }

    private void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
        velocity.x = Mathf.Lerp(velocity.x, inputAxis * moveSpeed, 0.1f);
    }

    void SetScoreText()
    {
        scoreText.text = "Score:" + score;
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidbody.position;
        position += velocity * Time.fixedDeltaTime;

        rigidbody.MovePosition(position);
    }

    // Add a method to increase the score
    public void IncreaseScore(int amount)
    {
        score += amount;
        SetScoreText();
    }

    // Add a method to decrease the score
    public void DecreaseScore(int amount)
    {
        score -= amount;
        SetScoreText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            // Handle the Pickup object (e.g., increase score)
            IncreaseScore(1);
            // Optionally, you can disable the collider or renderer of the object if needed.
            other.GetComponent<Collider2D>().enabled = false;
            other.GetComponent<Renderer>().enabled = false;
        }
        else if (other.gameObject.CompareTag("Mushroom"))
        {
            // Handle the Mushroom object (e.g., increase score by 5)
            IncreaseScore(5);
            // Optionally, you can disable the collider or renderer of the object if needed.
            other.GetComponent<Collider2D>().enabled = false;
            other.GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            // Handle the Bomb object (e.g., decrease score)
            DecreaseScore(1);
            // Optionally, you can disable the collider or renderer of the object if needed.
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
            collision.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}