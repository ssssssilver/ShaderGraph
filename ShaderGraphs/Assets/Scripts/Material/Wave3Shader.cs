using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave3Shader : MonoBehaviour
{
    Material material;
    float height = 0.5f;
    float scale = 20;
    float speed = 0.3f;
    float posHeight = 0.6f;
    float x = 0.5f;
    float y = 0.5f;
    float postArea = 5;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 60, 100, 30), "height:  ");
        height = GUI.HorizontalSlider(new Rect(200, 60, 100, 30), height, 0, 1);

        GUI.Label(new Rect(100, 90, 100, 50), "scale:  ");
        scale = GUI.HorizontalSlider(new Rect(200, 90, 100, 30), scale, 1, 100);

        GUI.Label(new Rect(100, 120, 100, 30), "Speed:  ");
        speed = GUI.HorizontalSlider(new Rect(200, 120, 100, 30), speed, 0, 1);

        GUI.Label(new Rect(100, 150, 100, 30), "posHeight:  ");
        posHeight = GUI.HorizontalSlider(new Rect(200, 150, 100, 30), posHeight,-1, 1);

        GUI.Label(new Rect(100, 180, 100, 30), "x:  ");
        x = GUI.HorizontalSlider(new Rect(200, 180, 100, 30), x, 0, 1);

        GUI.Label(new Rect(100, 210, 100, 30), "y:  ");
        y = GUI.HorizontalSlider(new Rect(200, 210, 100, 30), y, 0, 1);
        
        GUI.Label(new Rect(100, 240, 100, 30), "postArea:  ");
        postArea = GUI.HorizontalSlider(new Rect(200, 240, 100, 30), postArea, 5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("Vector1_81A7653D", height);
        material.SetFloat("Vector1_8C3DDC96", scale);
        material.SetFloat("Vector1_3A6C1337", speed);
        material.SetFloat("Vector1_3A0EBAB", posHeight);
        material.SetFloat("Vector1_3B9C177D", x);
        material.SetFloat("Vector1_F36C19F", y);
        material.SetFloat("Vector1_74CB9E17", postArea);
    }

}
