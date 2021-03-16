using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPrefab : MonoBehaviour
{
    public float speed = 10.0f;
    public float destroyTime = 15.0f;

    void Start()
    {
        // Destroy this level prefab
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        /*
        if (ResumeScript.GameIsPaused == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        */

        // Move the level platform
        transform.position -= transform.right * Time.deltaTime * speed;
    }
}
