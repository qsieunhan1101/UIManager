using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasGamePlay : UICanvas
{
    [SerializeField] private TextMeshProUGUI coinText;

    public override void SetUp()
    {
        base.SetUp();
        UpdateCoin(0);
    }
    public void UpdateCoin(int coin)
    {
        coinText.text = coin.ToString();
    }

    public void SettingButton()
    {
        UIManager.Instance.OpenUI<CanvasSetting>().SetState(this);
    }
}
