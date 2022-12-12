using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Win : MonoBehaviour
{
    public string mainMenuScene;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene); //go to main menu if button is pressed
    }
}
