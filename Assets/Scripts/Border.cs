using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public float zRange = 21;
    public float xRange = 21;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -zRange) 
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
    }
}
