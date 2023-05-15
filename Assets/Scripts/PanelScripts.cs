using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScripts : MonoBehaviour
{
    public GameObject panel;
    public float delayTime = 3f;
    private bool gameStarted = false;


    private void Start()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (!gameStarted && Time.timeSinceLevelLoad >= delayTime)
        {
            StartGame();
        }
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
        gameStarted = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
