using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countinator : MonoBehaviour
{
    internal int count = 0;
	private TextMeshPro counterText;
	
	void Start() {
		counterText = GetComponent<TextMeshPro>();
	}

    // Update is called once per frame
    void Update()
    {
        counterText.text = count.ToString();
    }
}
