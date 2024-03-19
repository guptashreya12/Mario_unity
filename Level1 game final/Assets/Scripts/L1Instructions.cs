// using UnityEngine;
// using UnityEngine.UI;

// public class L1Instructions : MonoBehaviour
// {
//     public GameObject panel1;
//     public GameObject panel2;
//     public Button nextButton;
//     public Button playButton;
//     public Canvas InstructionCanvas;  // Reference to the Canvas in the Unity Inspector
//     public GameObject player;

//     private void Start()
//     {
//         // Initialize the canvas with Panel1 active and Panel2 inactive.
//         panel1.SetActive(true);
//         panel2.SetActive(false);

//         // Add click event listeners to the Next and Play buttons.
//         nextButton.onClick.AddListener(OnNextButtonClick);
//         playButton.onClick.AddListener(OnPlayButtonClick);
//         InstructionCanvas.enabled = true;  // Enable the Canvas

//     }

//     private void OnNextButtonClick()
//     {
//         // When the Next button is clicked, switch to Panel2.
//         panel1.SetActive(false);
//         panel2.SetActive(true);
//     }

//     private void OnPlayButtonClick()
//     {
//         // When the Play button is clicked, disable the entire canvas.
//        InstructionCanvas.enabled = false;  // Disable the entire Canvas
//        player.SetActive(true);
//     }
// }
using UnityEngine;
using UnityEngine.UI;

public class L1Instructions : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public Button nextButton;
    public Button playButton;
    public Canvas InstructionCanvas;  // Reference to the Canvas in the Unity Inspector
    public Canvas AnotherCanvas; // Reference to the other Canvas you want to enable

    private void Start()
    {
        // Initialize the canvas with Panel1 active and Panel2 inactive.
        panel1.SetActive(true);
        panel2.SetActive(false);

        // Add click event listeners to the Next and Play buttons.
        nextButton.onClick.AddListener(OnNextButtonClick);
        playButton.onClick.AddListener(OnPlayButtonClick);
        InstructionCanvas.enabled = true;  // Enable the Canvas
    }

    private void OnNextButtonClick()
    {
        // When the Next button is clicked, switch to Panel2.
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

private void OnPlayButtonClick()
{
    // When the Play button is clicked, disable the entire canvas and enable another canvas.
    Debug.Log("Play button clicked"); // Check if this message appears in the console

    InstructionCanvas.enabled = false;  // Disable the entire Canvas

    if (AnotherCanvas != null)
    {
        AnotherCanvas.enabled = true; // Enable another Canvas
        Debug.Log("Canvas enabled"); // Check if this message appears in the console
    }
    else
    {
        Debug.LogError("Canvas not assigned.");
    }
}

}
