using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSetting : UICanvas
{

    [SerializeField] private GameObject[] buttons;

   

    public void SetState(UICanvas canvas)
    {
        for (int i = 0; i<buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
        if (canvas is CanvasMainMenu)
        {
            buttons[2].SetActive(true);
        } else if (canvas is CanvasGamePlay)
        {
            buttons[0].SetActive(true);
            buttons[1].SetActive(true);
        }
    }

    public void MainMenuButton()
    {
        UIManager.Instance.CloseAll();
        UIManager.Instance.OpenUI<CanvasMainMenu>();
    }

}
