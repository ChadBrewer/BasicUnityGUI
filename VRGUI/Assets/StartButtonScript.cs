using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Don't forget to add SceneManagement to load different scenes

public class StartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {  
    }

    //Custom StartGame Function that will start the game when the Start button is clicked
    void StartGame()
    {
        //Utilize the SceneManager and LoadScene funtion to switch to the Start scene
        SceneManager.LoadScene("GameStart");
    }
    void OptionMenu()
    {
        SceneManager.LoadScene("Options");
    }
}
