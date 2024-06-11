using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    #endregion
    public GameObject mainCanvas;
    public GameObject endCanvas;
    public int lives = 2;

    public float currentScore = 0f;

    public bool isPlaying = true;

    private void Update()
    {
        if (isPlaying)
        {
            currentScore += Time.deltaTime;
        }

        Time.timeScale = currentScore / 40 + 1;

        //if (Input.GetKeyDown("k"))
        //{
        //    isPlaying = true;
        //}
    }

    public void GameOver()
    {
        currentScore = 0;
        isPlaying = false;
        mainCanvas.SetActive(false);
        endCanvas.SetActive(true);
        Time.timeScale = 0;

    }

    public string PrettyScore()
    {
        return "Score: " + Mathf.RoundToInt(currentScore).ToString();
    }
}
