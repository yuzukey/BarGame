using UnityEngine;
using System.Collections;

public class UnityChanContoll : MonoBehaviour
{

    private Animator animator;
    private CharacterController Controller;
    public bool isGround = false;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        Controller = (CharacterController)GetComponent("CharacterController");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * 0.05f;
            animator.SetBool("is_running", true);
        }
        else
        {
            animator.SetBool("is_running", false);
        }

        if (Input.GetKey("space") && isGround)
        {
            transform.position += transform.up * 0.01f;
            animator.SetBool("is_jamping", true);
            isGround = false;
        }
        else
        {
            animator.SetBool("is_jamping", false);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 10, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -10, 0);
        }
    }

    private void OnCollisionEnter(CharacterController Controller)
    {
        if (Controller.collider.gameObject.name == "Floor")
        {
            isGround = true;
        }
    }
}
