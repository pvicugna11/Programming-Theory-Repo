using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour,
    UIMain.IUIInfoContent
{
    public string ShapeName { get; protected set; }
    public Color ShapeColor { get; protected set; }
    
    private void Start()
    {
        Init();
    }

    private void Init()
    {
        ShapeName = gameObject.name;
        ShapeColor = GetComponent<Renderer>().material.color;
    }

    public void DisplayText()
    {
        UIMain.Instance.DisplayText(this);
    }

    public virtual string GetName()
    {
        return ShapeName;
    }

    public virtual string GetColor()
    {
        return "";
    }
}
