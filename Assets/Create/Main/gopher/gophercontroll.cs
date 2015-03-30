using UnityEngine;
using System.Collections;

public class gophercontroll : MonoBehaviour 
{

    public bool isGround = true; 
    
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.09f;
        }

        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * 0.09f;
        }


        if (Input.GetKey("space") && isGround)
        {
            rigidbody.AddForce(Vector3.up * 60);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(3, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(-3, 0, 0);
        }

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        isGround = true;
    }

    private void OnCollisionExit(Collision collisionInfo)
    {
        isGround = false;
    }
}
