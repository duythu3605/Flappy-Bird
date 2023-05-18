using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStartGame : UIScreen
{
    [SerializeField]
    private Button StartGame;

    public override void Init()
    {
        base.Init();
        Panel.GetComponent<UIStartGame>();
        Star();
    }
    private void Star()
    {
        StartGame.onClick.AddListener(() =>
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
