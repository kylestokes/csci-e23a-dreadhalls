using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class MazeUIController : MonoBehaviour
{
    private Text text;
    public static int maze = 0;

    // Start is called before the first frame update
    void Start()
    {
       text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Maze: " + MazeUIController.maze;
    }
}
