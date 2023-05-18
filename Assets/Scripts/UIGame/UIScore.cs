using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScore : UIScreen
{
    [SerializeField]
    private TMP_Text TextScore;
    [SerializeField]
    private Button PauseButton;
    [SerializeField]
    private Button ResumeButton;

    public override void Init()
    {
        base.Init();
        Panel.GetComponent<UIScore>();
        Pause();
        Resume();
    }
    private void Pause()
    {
        PauseButton.onClick.AddListener(() =>
        {
            FindObjectOfType<GameManager>().Pause();
        });
    }
    private void Resume()
    {
        ResumeButton.onClick.AddListener(() =>
        {
            FindObjectOfType<GameManager>().Resume();
        });
    }

    public void SetText(int score)
    {
        TextScore.text = score.ToString();
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
