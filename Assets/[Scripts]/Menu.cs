using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            SceneManager.LoadScene(1); //[Game]
        }
    }

    #region UI
    public void GoToStats()
    {
        SceneManager.LoadScene(4);
    }
    #endregion
}
