using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour
{

    public Transform follow;
  

    // Update is called once per frame
    void Update()
    {
        if (follow != null)
        if (transform.position.y < follow.position.y)
        {
            transform.position = new Vector3 (transform.position.x,follow.position.y,transform.position.z);
        }
    }
}
