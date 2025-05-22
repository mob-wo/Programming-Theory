using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    // text ui serialized field
    [SerializeField]
    private Text captionText;


    // Start is called before the first frame update
    void Start()
    {
        // Find all Sphere objects in the scene
        Sphere[] spheres = FindObjectsOfType<Sphere>();

        // Register OnClickEvent for each sphere
        foreach (Sphere sphere in spheres)
        {
            sphere.OnClickEvent += OnClick;
        }
     }

    // display caption
    public void DisplayCaption(string caption)
    {
        captionText.text = caption;
    }

    // クリック処理
    public void OnClick(Sphere sphere, int clickID)
    {
        if (clickID == 0)
        {
            // 左クリック
            // POLYMORPHISM
            sphere.ChangeColor();
            // ENCAPSULATION
            DisplayCaption(sphere.sphereName + " : Left Clicked");
        }
        else if (clickID == 1)
        {
            // 右クリック
            // ABSTRACTION
            sphere.ChangeDefaultColor();
            // ENCAPSULATION
            DisplayCaption(sphere.sphereName + " : Right Clicked");
        }

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
