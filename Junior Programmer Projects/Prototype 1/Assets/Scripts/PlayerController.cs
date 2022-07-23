using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 5.0f;
    private float turnspeed = 25.0f;
    private float horizontalinput;
    private float forwardinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");

        //Moves the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardinput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnspeed * horizontalinput * Time.deltaTime);
        //Might need to delete this line
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalinput);
    }
}
