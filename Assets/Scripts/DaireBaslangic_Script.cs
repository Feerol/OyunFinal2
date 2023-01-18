using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaireBaslangic_Script : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0.0f)
            {
                transform.Rotate(0f,0f,0.5f);
            }
        if (Input.GetAxis("Vertical") < 0.0f)
            {
                transform.Rotate(0f,0f,-0.5f);
            }
    }
}
