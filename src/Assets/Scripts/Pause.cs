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
        is_paused = false; //initially the game will not be paused
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //if escape is pressed
        {
            if (is_paused) //resume game if paused
            {
                ResumeGame();
            }
            else //pause game if unpaused
            {
                is_paused = true;
                pauseMenu.SetActive(true); //makes pause menu object active
            }
            
        }
    }

    public void ResumeGame()
    {
        is_paused = false;
        pauseMenu.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene); //loads main menu scene if main menu button is pressed
    }
}
