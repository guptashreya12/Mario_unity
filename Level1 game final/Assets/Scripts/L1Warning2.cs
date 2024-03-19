using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class L1Warning2 : MonoBehaviour
{
    public TextMeshProUGUI popUpMessage_Under; // Reference to the TextMesh Pro object.
    public GameObject WarningCanvas1; // Reference to the warning canvas GameObject

    private bool playerEntered = false;

    private void Update()
    {
        if (playerEntered)
        {
            WarningCanvas1.SetActive(true);
            Destroy(WarningCanvas1, 6f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) // Changed to OnTriggerEnter2D
    {
        if (other.CompareTag("Player")) // Adjust the tag as needed
        {
            playerEntered = true;
        }
    }
}
