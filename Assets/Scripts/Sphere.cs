using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sphere : MonoBehaviour
{

    // マウスがオブジェクト上にあるかどうか
    private bool isMouseOver = false;

    public string sphereName { get; private set; }

    // イベント アクション　マウスクリック　引数　this
    public event System.Action<Sphere, int> OnClickEvent;
    

    // Start is called before the first frame update
    void Start()
    {
        sphereName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        // マウスがオブジェクト上にある場合
        if (isMouseOver)
        {
            int mouseID;
            if (Input.GetMouseButtonDown(0))
            {
                // 左クリック
                mouseID = 0;
                OnClickEvent?.Invoke(this, mouseID);
            }
            else if (Input.GetMouseButtonDown(1))
            {
                // 右クリック
                mouseID = 1;
                OnClickEvent?.Invoke(this, mouseID);
            }
        }
    }
    // マウスがオブジェクト上にあるかどうかを判定
    private void OnMouseOver()
    {
        isMouseOver = true;
    }
    // マウスがオブジェクト上にない場合
    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    // 色を変更する
    public virtual void ChangeColor()
    {
        // 白色に変更
        Color color = new Color(1.0f, 1.0f, 1.0f);
        GetComponent<Renderer>().material.color = color;
    }
    // 色をデフォルトに戻す
    public void ChangeDefaultColor()
    {
        // デフォルトの色に戻す
        Color color = new Color(1.0f, 1.0f, 1.0f);
        GetComponent<Renderer>().material.color = color;
    }

}
