using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBase : MonoBehaviour
{
    public void StartTitle()
    {
        SceneManager.LoadScene(0);
    }

    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }
}
