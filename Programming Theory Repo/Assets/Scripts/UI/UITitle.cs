using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UITitle : UIBase
{
    public void InputPlayerName(TextMeshProUGUI text)
    {
        MainManager.Instance.PlayerName = text.text;
    }
}
