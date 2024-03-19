// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class L1quedisplay : MonoBehaviour
// {
//     public GameObject panel;
//     public GameObject background;
//     public Sprite foregroundImage;
//     public Sprite backgroundImage;

//     private SpriteRenderer foregroundRenderer;
//     private SpriteRenderer backgroundRenderer;

//     private void Start()
//     {
//         foregroundRenderer = panel.GetComponent<SpriteRenderer>();
//         backgroundRenderer = background.GetComponent<SpriteRenderer>();

//         // Set the initial images
//         if (foregroundRenderer != null && foregroundImage != null)
//         {
//             foregroundRenderer.sprite = foregroundImage;
//         }

//         if (backgroundRenderer != null && backgroundImage != null)
//         {
//             backgroundRenderer.sprite = backgroundImage;
//         }

//         // Ensure the panel is initially inactive
//         panel.SetActive(false);
//     }

//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             TogglePopupWindow();
//             Destroy(gameObject); // Destroy the cube when the player triggers the event
//         }
//     }

//     private void OnMouseDown()
//     {
//         // Show the popup window when the object is clicked.
//         TogglePopupWindow();
//         Destroy(gameObject); // Destroy the cube when it is clicked
//     }

//     // Add a method to toggle the visibility of the popup window.
//     private void TogglePopupWindow()
//     {
//         bool currentVisibility = panel.activeSelf;
//         panel.SetActive(!currentVisibility);
//     }

//     // Add a method to check the player's answer.
//     public void CheckAnswer(bool isCorrect)
//     {
//         // Check if the answer is correct.
//         if (isCorrect)
//         {
//             // If the answer is correct, hide the popup window.
//             HidePopupWindow();
//         }
//     }

//     public void HidePopupWindow()
//     {
//         panel.SetActive(false);
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1quedisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    //public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TogglePopupWindow();
            Destroy(gameObject); // Destroy the cube when the player triggers the event
        }
    }

    private void OnMouseDown()
    {
        // Show the popup window when the object is clicked.
        TogglePopupWindow();
        Destroy(gameObject); // Destroy the cube when it is clicked
    }

    // Add a method to toggle the visibility of the popup window.
    private void TogglePopupWindow()
    {
        bool currentVisibility = panel.activeSelf;
        panel.SetActive(!currentVisibility);
      //  player.SetActive(false);
    }

    // Add a method to check the player's answer.
    public void CheckAnswer(bool isCorrect)
    {
        // Check if the answer is correct.
        if (isCorrect)
        {
            // If the answer is correct, hide the popup window.
            HidePopupWindow();
        }
    }

    public void HidePopupWindow()
    {
        panel.SetActive(false);
        //player.SetActive(true);
    }
}
