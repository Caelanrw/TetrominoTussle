using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePage : MonoBehaviour
{
    public string Game, Controls;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 20; //sets game frame rate
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Game); //load game when button pressed
    }

    public void QuitGame()
    {
        Application.Quit(); //close game when button pressed
    }

    public void ControlScene()
    {
        SceneManager.LoadScene(Controls); //load control screen when button pressed
    }
}
