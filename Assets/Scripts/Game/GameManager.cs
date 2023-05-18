using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class GameManager : MonoBehaviour
{

    

    private int Score;

    public PlayerFly player;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play()
    {
        UIManager.instance.UIStartGame.HideUI();
        UIManager.instance.UIGameOver.HideUI();
        UIManager.instance.UIScore.ShowUI();
        Score = 0;
        UIManager.instance.UIScore.SetText(Score);
        Time.timeScale = 1f;
        player.enabled = true;

        PipeTransform[] pipes = FindObjectsOfType<PipeTransform>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        player.enabled = true;
    }
    public void GameOver()
    {
        UIManager.instance.UIGameOver.ShowUI();
        Pause();
    }

    public void IncreaseScore()
    {
        Score++;
        UIManager.instance.UIScore.SetText(Score);
    }
}
