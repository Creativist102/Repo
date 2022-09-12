using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player stats
    float speed = 10.00f;
    Rigidbody playerRB;

    //player input
    float hInput;
    float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keyboard inputs
        hInput = hInput.GetAxis("Horizontal");
        vInput = vInput.GetAxis("Vertical");

        //move player forward and back
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);

        //rotate player left and right
        transform.Rotate(Vector3.up, hInput * speed * Time.deltaTime);
    }
}
