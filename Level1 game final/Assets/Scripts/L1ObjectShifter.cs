using UnityEngine;

public class L1ObjectShifter : MonoBehaviour
{
    public GameObject uppercam; // Assign in the Unity Editor
    public GameObject lowercam; // Assign in the Unity Editor
    public GameObject upupcam;
    public GameObject player;
    void Update()
    {
        float y = player.transform.position.y; // Assuming you want to check the x position of the script's owner
        if (y>9){
            upupcam.SetActive(true);
            uppercam.SetActive(false);
            lowercam.SetActive(false);
        }
        else if (9>y && y>-11.1) // Change the condition as per your requirement
        {
            upupcam.SetActive(false);
            uppercam.SetActive(true);
            lowercam.SetActive(false);
        }
        else
        {   upupcam.SetActive(false);
            uppercam.SetActive(false);
            lowercam.SetActive(true);
        }
    }
}