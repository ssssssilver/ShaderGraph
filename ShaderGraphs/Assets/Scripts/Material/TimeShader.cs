using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShader : MonoBehaviour
{
    Material material;
     float time = 0.5f;
    float waveRange = 1;
    float speed = 1;
    float lowRange = 0.3f;
    Material material2;
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        material2 = mesh.material;
    }

    private void OnGUI()
    {
            GUI.Label(new Rect(100, 60, 100, 30),"Time:  ");
            time= GUI.HorizontalSlider(new Rect(200,60,100,30), time, 0,1);

            GUI.Label(new Rect(100, 90, 100, 50), "WaveRange:  ");
            waveRange = GUI.HorizontalSlider(new Rect(200, 90, 100, 30), waveRange, 0, 2);

            GUI.Label(new Rect(100, 120, 100, 30), "Speed:  ");
            speed = GUI.HorizontalSlider(new Rect(200, 120, 100,30), speed, 0, 2);

            GUI.Label(new Rect(100, 150, 100, 30), "LowRange:  ");
        lowRange = GUI.HorizontalSlider(new Rect(200, 150, 100, 30), lowRange, 0.01f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("Vector1_68C7923C", time);
        material.SetFloat("Vector1_B0F3EE61", waveRange);
        material.SetFloat("Vector1_4517B2EB", speed);
        material.SetFloat("Vector1_9D49368D", lowRange);


        material2.SetFloat("Vector1_68C7923C", time);
        material2.SetFloat("Vector1_B0F3EE61", waveRange);
        material2.SetFloat("Vector1_4517B2EB", speed);
        material2.SetFloat("Vector1_9D49368D", lowRange);
    }
    
}
