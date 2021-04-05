using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatHorizontal : MonoBehaviour
{
    private Vector3 left;
    private Vector3 right;
    private Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        left = transform.position + new Vector3(-1, 0, 0);
        right = transform.position + new Vector3(1, 0, 0);

        destination = left;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, destination, 0.5f * Time.deltaTime);

        if (Vector3.Distance(transform.position, destination) <= 0.1)
        {
            if (destination == left)
                destination = right;
            else
                destination = left;
        }
    }
}
