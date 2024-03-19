using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1BigEnemy : MonoBehaviour
{
    private bool hasCollided = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasCollided)
        {
            hasCollided = true;
            StartCoroutine(DisappearAfterDelay());
        }
    }

    private IEnumerator DisappearAfterDelay()
    {
        yield return new WaitForSeconds(0.5f); // Wait for 0.5 seconds
        Destroy(gameObject); // Destroy the Goomba after the delay
    }
}
