using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicatorinator : MonoBehaviour
{
    public Countinator counter;
	public GameObject prefab;
	public bool clockwise = false;
	public SFXPlayer soundPlayer;
	
	public void Duplicate() {
		if (counter.count < 3) {
			Vector3 instPos = transform.position;
			
			if (counter.count == 0) {
				instPos += Vector3.up;
			} else if ((counter.count == 1 && clockwise) || (counter.count == 3 && !clockwise)) {
				instPos += Vector3.right;
			} else if (counter.count == 2) {
				instPos += Vector3.down;
			} else {
				instPos += Vector3.left;
			}
			
			GameObject clone = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
			clone.GetComponent<Sendoffinator>().SendOff(instPos);
			
			soundPlayer.PlaySound("Pop");
			
			counter.count += 1;
		}
	}
}
