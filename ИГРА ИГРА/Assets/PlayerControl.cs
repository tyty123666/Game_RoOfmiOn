using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  PlayerControl : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            Vector3 input2 = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            rb.MovePosition(transform.position + input2 * speed * Time.deltaTime);
        }
        else if (Input.GetKey("s"))
        {
            Vector3 input3 = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            rb.MovePosition(transform.position + input3 * speed * Time.deltaTime * -1);
        }
        else if (Input.GetKey("a") || Input.GetKey("d"))
        {
            Vector3 input1 = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            rb.MovePosition(transform.position + input1 * speed * Time.deltaTime);
        }
    }
}





