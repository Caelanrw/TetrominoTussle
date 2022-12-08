using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{

    public string mainMenuScene;
    public GameObject pauseMenu;
    static public bool is_paused=false;


    // Start is called before the first frame update
    void Start()
    {
        is_paused=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (is_paused)
            {
                ResumeGame();
            }
            else
            {
                is_paused=true;
                pauseMenu.SetActive(true);
            }
            
        }
        
    }

    public void ResumeGame()
    {
        is_paused=false;
        pauseMenu.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
