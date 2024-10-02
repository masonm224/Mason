using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject Player;
    private Vector3 offsetBehind = new Vector3(0, 1, -3);
    private Vector3 offsetPOV = new Vector3(0, 0, 0);
    public float turnSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
   
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
        transform.position = Player.transform.position + offsetBehind;
        }
        if (Input.GetKeyDown(KeyCode.F)){
        transform.position = Player.transform.position + offsetPOV;
        }
        if (Input.GetKeyDown(KeyCode.Q)){
        transform.Rotate(Vector3.down * turnSpeed);
        }
        if (Input.GetKeyDown(KeyCode.E)){
        transform.Rotate(Vector3.up * turnSpeed);
        }
    }
}
