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

    //Selects main menu - William Strandberg
    public void MainMenuButton()
    {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
        quitMenu.SetActive(false);
    }

    //Selects level Menu - Strandberg
    public void LevelMenuButton()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
        quitMenu.SetActive(false);
    }

    //Selects quit menu - Strandberg
    public void QuitMenuButton()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(false);
        quitMenu.SetActive(true);
    }

    //Loads level 1 - Strandberg
    public void Level1Button()
    {
        SceneManager.LoadScene("Level 1");
    }

    //Exit game function - Strandberg
    public void QuitGameButton()
    {
        Application.Quit();
    }
}
