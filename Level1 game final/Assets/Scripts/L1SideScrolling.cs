using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1SideScrolling : MonoBehaviour
{
    private Transform player;

    public float height = 3.2f;
    //public float undergroundHeight = -30f;

    private void Awake()
    {
        // camera = GetComponent<Camera>();
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {

        Vector3 cameraPosition = transform.position;
        cameraPosition.x = player.position.x;

        transform.position = cameraPosition;
    }

    /*public void SetUnderground(bool underground)
    {
        Vector3 cameraPosition = transform.position;
        //cameraPosition.y = underground ? undergroundHeight : height;
        //transform.position = cameraPosition;

    }*/

}
