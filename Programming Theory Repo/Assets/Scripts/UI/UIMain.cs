using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMain : UIBase
{
    public static UIMain Instance { get; private set; }

    public interface IUIInfoContent
    {
        string GetName();
        string GetColor();
    }

    public InfoPopup InfoPopup;

    private Vector3 bias = new Vector3(3f, 2.6f, 0f);

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InfoPopup.gameObject.SetActive(false);
    }

    public void DisplayText(Shape shape)
    {
        if (!shape)
        {
            InfoPopup.gameObject.SetActive(false);
        }
        else
        {
            InfoPopup.gameObject.SetActive(true);
            InfoPopup.transform.position = shape.gameObject.transform.position + bias;
            Fetch(shape);
        }
    }

    private void Fetch(IUIInfoContent content)
    {
        InfoPopup.Name.SetText(content.GetName());
        InfoPopup.Color.SetText(content.GetColor());
    }
}   
