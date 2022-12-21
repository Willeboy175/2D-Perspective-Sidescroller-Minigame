using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;
    public GameObject quitMenu;
    public GameObject Level1;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    // Update is called once per frame
    void Update()
    {
        if (Level1 == true)
        {
            Level1Button();
        }
    }

    public void MainMenuButton()
    {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
        quitMenu.SetActive(false);
    }

    public void Level1Button()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1");
    }
}
