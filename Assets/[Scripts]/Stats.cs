using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stats : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            SceneManager.LoadScene(2); //[Menu]
        }
    }
}
