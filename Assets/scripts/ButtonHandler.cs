using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void onclickButton1()
    {
        Debug.Log("button1");
        GoToNextScene();
    }
    public void onclickButton2()
    {
        Debug.Log("button2");
        Application.Quit();
    }

    void GoToNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Check to prevent going out of bounds
        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            Debug.Log("This is the last scene.");
            // Optionally, you can load the first scene or do something else.
            // SceneManager.LoadScene(0); // Load first scene
        }
    }
}

