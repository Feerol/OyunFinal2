using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_Script : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed=5;
    // Start is called before the first frame update
    public void Start()
    {
        topHareket();
        
    }

    public void topHareket()
    {
        rb=GetComponent<Rigidbody2D>();
        //rb.AddForce(new Vector2(20*Time.deltaTime*speed,20*Time.deltaTime*speed));
        float x = Random.Range(0,2) == 0 ? -1: 1;
        float y = Random.Range(0,2) == 0 ? -1: 1;
        rb.velocity = new Vector2(x*speed,y*speed);
    }

    // Update is called once per frame
    
    
}
