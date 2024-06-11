using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterComic : MonoBehaviour
{
    public float seconds = 9f;
    float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= seconds)
        {
            SceneManager.LoadScene(1);
        }
    }
}
