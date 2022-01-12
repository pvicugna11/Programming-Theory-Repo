using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string ShapeName { get; protected set; }
    public Color ShapeColor { get; protected set; }

    public abstract void DisplayText();
}
