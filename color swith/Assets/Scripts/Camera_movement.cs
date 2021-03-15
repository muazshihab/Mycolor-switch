using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_movement : MonoBehaviour
{

    public Transform follow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < follow.position.y)
        {
            transform.position = new Vector3 (transform.position.x,follow.position.y,transform.position.z);
        }
    }
}
