using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToApple : MonoBehaviour
{
    public GameObject apple;

    public void Switch()
    {
        apple.SetActive(true);
        gameObject.SetActive(false);
    }
}
