using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToApple : MonoBehaviour
{
    public GameObject apple;
	public SFXPlayer soundPlayer;

    public void Switch()
    {
        soundPlayer.PlaySound("Pop");
		apple.SetActive(true);
        gameObject.SetActive(false);
    }
}
