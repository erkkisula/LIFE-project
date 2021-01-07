using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class logo_script : MonoBehaviour
{
    DateTime sceneStartTime = new DateTime(1970, 1, 1);

    void Start()
    {
        sceneStartTime = DateTime.Now;
    }

    void Update()
    {
        checkIfMoveToMenu();
    }

    private void checkIfMoveToMenu()
    {
        TimeSpan span = DateTime.Now - sceneStartTime;

        if (span.TotalMilliseconds > 3000.0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
