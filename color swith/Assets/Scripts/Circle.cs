using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float rotspeed = 10f;
    public GameObject star;


    private void Start()
    {
        Instantiate(star, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotspeed * Time.deltaTime);
    }
}
