using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Jump : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpForce = 10000f;
    private bool _shouldJump;
    private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (_shouldJump == false)
            _shouldJump = Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space);
    }

    private void FixedUpdate()
    {
        if (_shouldJump)
        {
            _rigidbody.AddForce(_jumpForce * Vector3.up);
            _shouldJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Calculate the direction from the player to the colliding object
        Vector2 impactDirection = collision.transform.position - transform.position;
        impactDirection.Normalize();

        // Cast a ray in the opposite direction of the impact
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -impactDirection, 2f);

        if (hit.collider != null)
        {
            // Apply a force to the colliding object in the direction of the ray
            Rigidbody2D otherRigidbody = hit.collider.GetComponent<Rigidbody2D>();
            if (otherRigidbody != null)
            {
                otherRigidbody.AddForce(impactDirection * _jumpForce * 1.5f, ForceMode2D.Impulse);
            }
        }
    }
}
