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
		if (
            transform.position.y < 0 ||
            transform.parent.transform.position.y < 0
        ) {
            AudioSource audio = DontDestroy.instance.GetComponents<AudioSource>()[0];
            audio.Pause();
            Destroy(DontDestroy.instance);
            SceneManager.LoadScene("GameOver");
		}
    }
}
