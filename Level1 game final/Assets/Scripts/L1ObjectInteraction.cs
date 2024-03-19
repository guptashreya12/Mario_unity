using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1ObjectInteraction : MonoBehaviour
{
    public GameObject popupWindow; // Reference to the popup window GameObject.
    public void OnTriggerEnter2D(){
        TogglePopupWindow();
    }
    private void Start()
    {
        // Make sure the popup window is initially inactive.
        popupWindow.SetActive(false);
    }

    /*private void Update()
    {
        // Check for keyboard input to toggle the popup window.
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Toggle the visibility of the popup window.
            TogglePopupWindow();
        }
    }*/

    private void OnMouseDown()
    {
        // Show the popup window when the object is clicked.
        TogglePopupWindow();
    }

    // Add a method to toggle the visibility of the popup window.
    private void TogglePopupWindow()
    {
        bool currentVisibility = popupWindow.activeSelf;
        popupWindow.SetActive(!currentVisibility);
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

    // Add a method to hide the popup window.
    public void HidePopupWindow()
    {
        popupWindow.SetActive(false);
    }
}
