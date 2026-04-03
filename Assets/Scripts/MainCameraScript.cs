using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public GameObject g1;
    Vector3 location;

    void LateUpdate()   // better for camera follow
    {
        location = transform.position;   // keep current z

        location.x = g1.transform.position.x;
        location.y = g1.transform.position.y;

        transform.position = location;   // re-assign whole Vector3
    }
}
