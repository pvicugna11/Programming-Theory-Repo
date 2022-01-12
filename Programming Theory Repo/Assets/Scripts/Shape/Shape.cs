using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string ShapeName { get; protected set; }
    public Color ShapeColor;

    private Renderer m_Renderer;

    private void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        SetColor(ShapeColor);
    }

    public void SetColor(Color color)
    {
        m_Renderer.material.color = color;
    }

    public virtual void DisplayText() {}
}
