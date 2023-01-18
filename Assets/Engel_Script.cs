using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel_Script : MonoBehaviour
{
    public float DönmeHızı;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,DönmeHızı);
    }
}
