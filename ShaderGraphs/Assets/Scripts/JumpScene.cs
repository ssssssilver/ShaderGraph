using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(CameraFollow))]
public class JumpScene : MonoBehaviour {

    void OnGUI()
    {
        if(GUI.Button(new Rect(20,10,70,25), "Timing"))
        {
            SceneManager.LoadScene("Timing");
        }
        if (GUI.Button(new Rect(20, 40, 70, 25), "Wave1"))
        {
            SceneManager.LoadScene("Wave1");
        }
        if (GUI.Button(new Rect(20, 70, 70, 25), "Wave2"))
        {
            SceneManager.LoadScene("Wave2");
        }
        if (GUI.Button(new Rect(20, 100, 70, 25), "Wave3"))
        {
            SceneManager.LoadScene("Wave3");
        }
        if (GUI.Button(new Rect(20, 130, 70, 25), "Tornado"))
        {
            SceneManager.LoadScene("Tornado");
        }
        if (GUI.Button(new Rect(20, 160, 70, 25), "Waterfall"))
        {
            SceneManager.LoadScene("Waterfall");
        }
        if (GUI.Button(new Rect(20, 190, 70, 25), "Whirlpool"))
        {
            SceneManager.LoadScene("Whirlpool");
        }

        GUI.Label(new Rect(120, 10, 600, 25), "W↑ S↓ A← D→  左键拖动旋转镜头");

    }
}
