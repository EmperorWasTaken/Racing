using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectMainMenu : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("LevelSelect");
                break;
            case "Quit":
                Application.Quit();
                break;
        }
    }
}
