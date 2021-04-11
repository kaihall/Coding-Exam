using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour
{
    public SFXPlayer soundPlayer;
	
	public void SwitchScene()
    {
        soundPlayer.PlaySound("Woosh");
		SceneManager.LoadScene("Scene2");
    }
}
