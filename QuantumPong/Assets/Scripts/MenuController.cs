using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static bool versusComputer = false;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void VsPlayer()
    {
        SceneManager.LoadScene (sceneName:"SampleScene");
        versusComputer = false;
    }

    public void VsCPU()
    {
        SceneManager.LoadScene (sceneName:"SampleScene");
        versusComputer = true;
    }
}
