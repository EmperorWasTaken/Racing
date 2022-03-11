using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectLevel : MonoBehaviour
{
    public void SelectLevel()
    {
        switch (this.gameObject.name)
        {
            case "Track 1":
                SceneManager.LoadScene("ClimberTrack");
                break;
            case "Track 2":
                SceneManager.LoadScene("LevelUltima");
                break;
            case "Track 3":
                SceneManager.LoadScene("SpeederTrack");
                break;
            case "Track 4":
                SceneManager.LoadScene("TheLordsRoad");
                break;
            case "Return":
                SceneManager.LoadScene(0);
                break;
        }
    }
}
