using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UITitle : MonoBehaviour
{
    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }

    public void InputPlayerName(TextMeshProUGUI text)
    {
        MainManager.Instance.PlayerName = text.text;
    }
}
