using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kayit_Script : MonoBehaviour
{
    public int eskiLevel=0;
    public int guncelLevel=0;
    void Start()
    {
        
        
    }

    
    void Update()
    {
        guncelLevel=SceneManager.GetActiveScene().buildIndex;
        if(guncelLevel>eskiLevel)
        {
            
            eskiLevel=guncelLevel;
            PlayerPrefs.SetInt("saved_level",guncelLevel);
            
        }
    }
}
