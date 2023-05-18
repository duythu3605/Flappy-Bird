using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : UIScreen
{
    [SerializeField]
    private Button ReplayGame;

    public override void Init()
    {
        base.Init();
        Panel.GetComponent<UIGameOver>();
        Replay();
    }

    private void Replay()
    {
        ReplayGame.onClick.AddListener(() =>
        {
            FindObjectOfType<GameManager>().Play();
        });
    }

    public override void ShowUI()
    {
        base.ShowUI();
    }

    public override void HideUI()
    {
        base.HideUI();
    }
}
