using UnityEngine;
using System.Collections;

public class UI : CollectTrigger
{
    //make gui pop up asking if I want to restart the game after all enemies are defeated and crossing finish line

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, 100, 100));
        GUILayout.Box("Score: " + score.ToString());
        GUILayout.EndArea();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}