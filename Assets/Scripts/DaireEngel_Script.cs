using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaireEngel_Script : MonoBehaviour
{
    Rigidbody2D rb;
    public float DönmeHızı;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.isPaused && !TopSekmesi_Script.isDead)
        {
            transform.Rotate(0f,0f,DönmeHızı);
        }
        
    }

    
}
