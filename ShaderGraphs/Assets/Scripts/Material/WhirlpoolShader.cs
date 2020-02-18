using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirlpoolShader : MonoBehaviour
{
    Material material;
    float TwirlStrength =5f;
    float Speed = 0.3f;
    float WaveStrength = 0.6f;
    float Depth = -5f;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 60, 100, 30), "TwirlStrength:  ");
        TwirlStrength = GUI.HorizontalSlider(new Rect(200, 60, 100, 30), TwirlStrength, 0, 20);

        GUI.Label(new Rect(100, 90, 100, 50), "Speed:  ");
        Speed = GUI.HorizontalSlider(new Rect(200, 90, 100, 30), Speed, 0, 2);

        GUI.Label(new Rect(100, 120, 100, 30), "WaveStrength:  ");
        WaveStrength = GUI.HorizontalSlider(new Rect(200, 120, 100, 30), WaveStrength, 0, 1);

        GUI.Label(new Rect(100, 150, 100, 30), "Depth:  ");
        Depth = GUI.HorizontalSlider(new Rect(200, 150, 100, 30), Depth, -10, 10);

    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("Vector1_3BCFC3FB", TwirlStrength);
        material.SetFloat("Vector1_1B5100D6", Speed);
        material.SetFloat("Vector1_A8348906", WaveStrength);
        material.SetFloat("Vector1_E534D142", Depth);
    }

}
