using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Management : MonoBehaviour
{

    public void Again()
    {
        SceneManager.LoadScene("Final_Project");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Fail_Scene");
    }

    public void End()
    {
        SceneManager.LoadScene("End_Scene");
    }

    public void EndGame()
    {
        Application.Quit();
    }

}
