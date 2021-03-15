using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    public AudioClip myclip;
    public GameObject part;


    private void LateUpdate()
    {
        transform.Rotate(0f, 0f, 0f);
      //  myaudio.PlayOneShot(myaudio.clip);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(myclip, transform.position,2);

        var pr = Instantiate(part,transform.position,Quaternion.identity);
        Destroy(pr, 1f);
        Destroy(gameObject);
    }


}
