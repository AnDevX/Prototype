//     _          ____            __  __
//    / \   _ __ |  _ \  _____   _\ \/ /
//   / _ \ | '_ \| | | |/ _ \ \ / /\  / 
//  / ___ \| | | | |_| |  __/\ V / /  \ 
// /_/   \_\_| |_|____/ \___| \_/ /_/\_\
//<------------------------------------>
// Game core



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetKeyUp(KeyCode.X))
        {
            //
        }

        if (Input.GetKeyDown(KeyCode.Escape)) // For Mobile to quit the game with the back button
        {
            if(SceneManager.GetActiveScene().buildIndex == 0) //Main screen [X]
            {
                Application.Quit(); //Todo "Do you want to Quit" Message
            }
            else
            {
                SceneManager.LoadScene(1); //[Game]
            }
        } 
    }


    #region [UI]
    public void GoToMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToAwards()
    {
        SceneManager.LoadScene(5);
    }
    public void GoToMarket()
    {
        SceneManager.LoadScene(3);
    }
    public void AdminMode()
    {
        //
    }
    public void GoToGameGuide()
    {
        SceneManager.LoadScene(6);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }   
    #endregion
}
