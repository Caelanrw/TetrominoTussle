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
        SceneManager.LoadScene(Game);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ControlScene()
    {
        SceneManager.LoadScene(Controls);
    }
}
