using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadLevelScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadSelectedScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuiteGame()
    {
        Application.Quit();
        Debug.Log("Quit the game");
    }
}
