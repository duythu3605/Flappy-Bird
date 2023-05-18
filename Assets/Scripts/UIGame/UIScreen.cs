using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScreen : MonoBehaviour
{
    
    public GameObject Panel;

    public virtual void Init()
    {

    }
    public virtual void ShowUI()
    {
        Panel.SetActive(true);
    }

    public virtual void HideUI()
    {
        Panel.SetActive(false);
    }
   
}
