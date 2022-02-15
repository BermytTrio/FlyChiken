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
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponents");
        gameGameUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponents");
        DisableUIComponent(gameGameUIComponents);
        EnableUIComponent(startGameUIComponents);
        DisableScore(score);
    }

    public void GameOver()
    {
        EnableUIComponent(gameGameUIComponents);
    }

    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }

    private void EnableUIComponent(GameObject[] startGameUIComponents)
    {
        foreach(GameObject obj in startGameUIComponents) 
        {
            obj.SetActive(false);
        }
    }

    private void DisableUIComponent(GameObject[] gameGameUIComponents)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
