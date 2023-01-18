using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopAim_Script : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform TopTransform;
    private Vector3 mousePos;
    public GameObject Top;

    

    // Update is called once per frame
    void Update()
    {
        Aiming();
        Shooting();
    }
    private void Aiming()
    {
        Input.GetAxis("Mouse X");
        Input.GetAxis("Mouse Y");

        Vector3 mousePosition=Input.mousePosition;

        Vector3 rotation=(mousePosition-transform.position).normalized;
        float rotZ=Mathf.Atan2(rotation.y,rotation.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(0,0,rotZ);
    }
    private void Shooting()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(Top,TopTransform.position,Quaternion.identity);
        }

        
    }
}
