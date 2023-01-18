using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kale_Script : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed=5;
    public AudioSource audioPlayer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        var VerticalInput = Input.GetAxis("Vertical");
        var HorizontalInput=Input.GetAxis("Horizontal");
        if (VerticalInput > 0.0f && VerticalInput< 2.48f)
        {
        rb.transform.Translate(Vector2.up*VerticalInput*Time.deltaTime*speed);
        }
        if (VerticalInput < 0.0f && VerticalInput> -2.48f)
        {
        rb.transform.Translate(Vector2.up*VerticalInput*Time.deltaTime*speed);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CollisionTag")
        {
            audioPlayer.Play();
        }
    }
}
