using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closeinator : MonoBehaviour
{
	public Countinator coffeeCounter;
	public Countinator donutCounter;
	
	public SFXPlayer soundPlayer;
	
	private MeshRenderer myMR;
	private MeshRenderer childMR;
	
	private bool closed = false;
	
    // Start is called before the first frame update
    void Start()
    {
        myMR = GetComponent<MeshRenderer>();
		childMR = transform.Find("We Are Closed").gameObject.GetComponent<MeshRenderer>();
		
		myMR.enabled = false;
		childMR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!closed && coffeeCounter.count == 3 && donutCounter.count == 3) {
			myMR.enabled = true;
			childMR.enabled = true;
			closed = true;
			soundPlayer.PlaySound("Ding Ding");
		}
    }
}
