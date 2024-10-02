using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    

public float speed = 10;
public float horizontalInput;
public float verticalInput;
private float boundary = 19;


// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Left Boundary
        if (transform.position.x < -boundary){
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        //Right Boundary
        if (transform.position.x > boundary){
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }
        //Top Boundary
        if (transform.position.z > boundary){
            transform.position = new Vector3(transform.position.x, transform.position.y, boundary);
        }
        //Bottom Boundary
        if (transform.position.z < -boundary){
            transform.position = new Vector3(transform.position.x, transform.position.y, -boundary);
        }
        //PlayerMovement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
    }
}
