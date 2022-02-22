using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    GameObject[] startGameUIComponents;
    GameObject[] gameGameUIComponents;
    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponents");
        gameGameUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponents");
        DisableUIComponent(gameGameUIComponents);
        EnableUIComponent(startGameUIComponents);
        DisableScore(score);
    }

    public void DisableStartUI()
    {
        DisableUIComponent(startGameUIComponents);
    }

    public void GameOver()
    {
        EnableUIComponent(gameGameUIComponents);
        Time.timeScale = 0;
    }

    public void ShowScore()
    {
        score.SetActive(true);
    }

    public void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }
    public void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }

    private void EnableUIComponent(GameObject[] uiOjects)
    {
        foreach(GameObject obj in uiOjects) 
        {
            obj.SetActive(true);
        }
    }

    private void DisableUIComponent(GameObject[] uiOjects)
    {
        foreach (GameObject obj in uiOjects)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
