using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
   public void loadnextlevel()
    {
        SceneManager.LoadScene("Premise");
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Elise Scene");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        GameManager.bluegem = 0;
        GameManager.redgem = 0;
        GameManager.greengem = 0;

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
