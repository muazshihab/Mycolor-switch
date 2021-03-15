using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Color[] color;


    private int mycolor = 0;
    private Vector3 restpos;
    float ymin;

    public float jumpspeed = 10f;




    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public AudioSource myaudio;
    public AudioClip sd_change;
    public AudioClip sd_die;
    public GameObject part_die;



    // Start is called before the first frame update
    void Start()
    {
        // color[0] = Color.red;
        // color[1] = Color.green;
        // color[2] = Color.blue;
        // color[3] = Color.magenta;
        Camera camera = Camera.main;
        ymin = camera.ViewportToWorldPoint(new Vector3(0,0,0)).y;


        restpos = transform.position;
  

        rb = GetComponent<Rigidbody2D>();
        // sr = GetComponent<SpriteRenderer>();


        Changecolor();



    }

    private void Changecolor()
    {
        mycolor = Random.Range(0, 4);

        if (mycolor == 0)
            sr.color = new Color32(198,50,52,255);//Color.red;
        if (mycolor == 1)
            sr.color = new Color32(49, 176, 80,255); //Color.green;//color[mycolor];
        if (mycolor == 2)
            sr.color = new Color32(34, 130, 197,255); //Color.blue;//color[mycolor];
        if (mycolor == 3)
            sr.color = new Color32(134, 31, 195,255); //Color.magenta;//color[mycolor];
    }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0f, jumpspeed);
            myaudio.PlayOneShot(myaudio.clip,1);
        }

        if (transform.position.y < ymin)
        {
            Die();

        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("change color"))
        {
            Changecolor();
            Destroy(col.gameObject,0f);
            AudioSource.PlayClipAtPoint(sd_change,transform.position);
            return;
        }
        if (!col.CompareTag("star"))
        {

            if (mycolor == 0 && !col.CompareTag("red"))
            {
                Die();

            }

            if (mycolor == 1 && !col.CompareTag("green"))
            {
                Die();
            }

            if (mycolor == 2 && !col.CompareTag("blue"))
            {
                Die();
            }

            if (mycolor == 3 && !col.CompareTag("purple"))
            {
                Die();
            }

        }
    }



    private void Die()
    {
        //transform.position = restpos;
        //StartCoroutine(Restart());

       // Changecolor();
        AudioSource.PlayClipAtPoint(sd_die, transform.position);
        Instantiate(part_die,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }


}
