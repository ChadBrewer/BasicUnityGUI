using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Don't forget to add SceneManagement to load different scenes

public class MenuButtonScript : MonoBehaviour
{

    //Custom StartGame Function that will start the game when the Start button is clicked
    public void StartGame()
    {
        //Utilize the SceneManager and LoadScene funtion to switch to the Start scene
        SceneManager.LoadScene("GameStart");
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
