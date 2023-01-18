using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopYapismasi_Script : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 LastVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        LastVelocity =rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
