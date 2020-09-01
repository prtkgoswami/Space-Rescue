using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject playerShip;
    [SerializeField] float cameraSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        if (playerShip != null)
        {
            transform.position = playerShip.transform.position + new Vector3(7.30f, -playerShip.transform.position.y, -10);
        }
        
        //Vector3 cameraMovementVector = new Vector3(1 * cameraSpeed, 0, 0);
        //cameraMovementVector *= Time.deltaTime;
        //transform.Translate(cameraMovementVector);
    }
}
