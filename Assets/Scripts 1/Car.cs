using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Car : MonoBehaviour
{
    public int position;
    public bool hasFinishedRace=false;
    string number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasFinishedRace)
        switch (position)
        {
            case 1:number="you won at postion 1";break;
            case 2:number="you won at postion 2";break;
            case 3:number="you won at postion 3";break;
            default:number="you lost"; break;
        }
    }
    private void OnEnable() 
    {
      SceneManager.sceneLoaded+=OnSceneLoaded;  
    }
    void OnSceneLoaded(Scene scene,LoadSceneMode loadSceneMode)
    {

    }
}
