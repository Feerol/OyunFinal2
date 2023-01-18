using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAsyncLevel : MonoBehaviour
{
    public bool levelComplete=false;
    public int sahneNum;

    void Start()
    {
         sahneNum = SceneManager.GetActiveScene().buildIndex;
    }
    

    void Update()
    {
        if(levelComplete == true)
        {
            
            StartCoroutine(SahneyiGec());
            Time.timeScale=1f;
        }
    }

    IEnumerator SahneyiGec()
    {
        yield return new WaitForSeconds(0.5f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sahneNum+1);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
