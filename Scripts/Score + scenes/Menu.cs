using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Difficulty");
    }

    
    public void Quit()
    {
        Application.Quit();
    }

    public void StartEasyMode()
    {
        SceneManager.LoadScene("EasyMode");
    }
    public void StartNormalMode()
    {
        SceneManager.LoadScene("NormalMode");
    }
    public void StartHardMode()
    {
        SceneManager.LoadScene("HardMode");
    }
    public void StartDontEvenTry()
    {
        SceneManager.LoadScene("DontEvenTryMode");
    }
}
