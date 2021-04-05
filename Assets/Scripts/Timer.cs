using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    private float time;
    public TextMeshPro timer;
    
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        int deltaTime = Mathf.RoundToInt(Time.time - time);

        if (deltaTime >= 60)
            SceneManager.LoadScene("GameOver");

        timer.text = (60 - deltaTime).ToString();
    }
}
