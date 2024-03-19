using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class L1Warning : MonoBehaviour
{
    public TextMeshProUGUI popUpMessage; // Reference to the TextMesh Pro object.
    public GameObject WarningCanvas; // Reference to the warning canvas GameObject

    private bool playerEntered = false;

    private void Update()
    {
        if (playerEntered)
        {
            WarningCanvas.SetActive(true);
            Destroy(WarningCanvas, 6f);
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
