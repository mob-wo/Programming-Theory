using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueSphere : Sphere
{
    // 色を変更する
    public override void ChangeColor()
    {
        // 青色に変更
        Color color = new Color(0.0f, 0.0f, 1.0f);
        GetComponent<Renderer>().material.color = color;
    }
}
