using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;
    public GameObject quitMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void MainMenuButton()
    {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
        quitMenu.SetActive(false);
    }

    public void LevelMenuButton()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
        quitMenu.SetActive(false);
    }

    public void QuitMenuButton()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(false);
        quitMenu.SetActive(true);
    }
    public void Level1Button()
    {
        SceneManager.LoadScene("Level-1");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
