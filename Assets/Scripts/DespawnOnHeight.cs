using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // switch to Game Over scene if below floor
		if (transform.position.y < 0) {
            // pause audio
            AudioSource audio = DontDestroy.instance.GetComponents<AudioSource>()[0];
            audio.Pause();
            Destroy(DontDestroy.instance);

            // load Play scene
            SceneManager.LoadScene("GameOver");

            // reset maze level count
            MazeUIController.maze = 0;
		}
    }
}
