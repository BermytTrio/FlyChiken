using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    
    public void ReloadLevel()
    {
        // одно и тоже
        //SceneManager.loadScene("GameScene);
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        ResumeGame();
    }
    public void Exit() { Application.Quit(); }
    private void ResumeGame() { Time.timeScale = 1; }
    public void LoadSetting()
    {
        SceneManager.LoadSetting(2);
        ResumeGame();
    }
}
