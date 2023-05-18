using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region SingleTon
    public static UIManager instance;
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion

    
    public UIScore UIScore;

    public UIStartGame UIStartGame;

    public UIGameOver UIGameOver;

    public void Start()
    {
        UIScore.Init();
        UIStartGame.Init();
        UIGameOver.Init();
    }
}
