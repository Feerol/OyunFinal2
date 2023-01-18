using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button DevamEtButton;
    public Button YeniOyunButton;
    public Kayit_Script KayitliOyun;

    void Start()
    {
        
    }

    void Update()
    {
        
        if(PlayerPrefs.GetInt("saved_level")>0)
        {
            DevamEtButton.interactable = true;
        }
            else
        {
            
            DevamEtButton.interactable = false;
   
        }
    }
    public void YeniOyun()
    {
         StartCoroutine(SahneyiGec());
    }


    IEnumerator SahneyiGec()
    {
        
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("OyunSahne1");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    
    public void DevamEt()
    {
        
            
        SceneManager.LoadScene(PlayerPrefs.GetInt("saved_level"));
            
            
    }
        
    }

    
    
    

