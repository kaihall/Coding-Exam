using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatVertical : MonoBehaviour
{
    private Vector3 top;
    private Vector3 bottom;
    private Vector3 destination;
    
    // Start is called before the first frame update
    void Start()
    {
        top = transform.position + new Vector3(0, 1, 0);
        bottom = transform.position + new Vector3(0, -1, 0);

        destination = top;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, destination, 0.5f * Time.deltaTime);

        if (Vector3.Distance(transform.position, destination) <= 0.1)
        {
            if (destination == top)
                destination = bottom;
            else
                destination = top;
        }
    }
}
