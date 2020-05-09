using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VideoManazer : MonoBehaviour
{

    public static VideoManazer instance;
    public UnityEngine.Video.VideoClip videoClip;
    public bool m=false;
    public int g = 500;

    void Start()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.Play();
        StartCoroutine(ExampleCoroutine());

        
          
        
    }

    IEnumerator ExampleCoroutine()
    {
        
     yield return new WaitForSeconds(7);
        Debug.Log("m");
        SceneManager.LoadScene(1);
        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }



    

}