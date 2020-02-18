using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1Shader : MonoBehaviour
{
    Material material;
    float height = 0.5f;
    float scale = 20;
    float speed = 0.3f;
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
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("Vector1_81A7653D", height);
        material.SetFloat("Vector1_8C3DDC96", scale);
        material.SetFloat("Vector1_3A6C1337", speed);

    }

}
