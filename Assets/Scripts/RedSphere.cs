using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 色変更時の処理をオーバーライド
// INHERITANCE
public class RedSphere : Sphere
{
    // 色を変更する
    public override void ChangeColor()
    {
        // 赤色に変更
        Color color = new Color(1.0f, 0.0f, 0.0f);
        GetComponent<Renderer>().material.color = color;
    }

}
