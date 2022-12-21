using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverMenu;

    private void Start()
    {
        ContinueButton();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuButton();
        }
    }

    //Pause menu - william
    public void PauseMenuButton()
    {
        pauseMenu.SetActive(true);
        gameOverMenu.SetActive(false);
    }


    public void ContinueButton()
    {
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(false);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main menu");
    }
}
