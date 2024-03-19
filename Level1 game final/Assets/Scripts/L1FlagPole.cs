using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1FlagPole : MonoBehaviour
{
    public Transform flag;
    public Transform poleBottom;
    public float speed = 6f;
    public GameObject questionPanel; // Reference to the question panel GameObject
    public GameObject Starman;

    private bool isFlagMoving = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isFlagMoving)
        {
            StartCoroutine(MoveFlagToBottom());
        }
    }

    private IEnumerator MoveFlagToBottom()
    {
        isFlagMoving = true;
        yield return StartCoroutine(MoveTo(flag, poleBottom.position));

        // Flag animation is complete, activate the question window
        if (questionPanel != null)
        {
            questionPanel.SetActive(true);
        }
    }

    private IEnumerator MoveTo(Transform subject, Vector3 destination)
    {
        while (Vector3.Distance(subject.position, destination) > 0.125f)
        {
            subject.position = Vector3.MoveTowards(subject.position, destination, speed * Time.deltaTime);
            yield return null;
        }
        subject.position = destination;
        Destroy(Starman);
    }
}
