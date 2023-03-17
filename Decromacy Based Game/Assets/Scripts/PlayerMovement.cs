using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float amountOfAccel, baseSpeed, JumpForce;
    public Transform groundCheckTransform;
    public LayerMask groundLayer;
    
    void Update()
    {
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (moveDir.magnitude != 0)
        {
            if (amountOfAccel <= 1)
            {
                amountOfAccel = 1;
            }

            amountOfAccel += (amountOfAccel / (Mathf.Pow(amountOfAccel, 2)) * Time.deltaTime);
            amountOfAccel = Mathf.Clamp(amountOfAccel, 0, 1.6f);
        }
        else
            amountOfAccel = 0;
        moveDir.y = rb.velocity.y;

        rb.velocity = (moveDir * amountOfAccel * baseSpeed);
        rb.velocity = new Vector3(rb.velocity.x, moveDir.y, rb.velocity.z);



        if (Input.GetKeyDown(KeyCode.Space) && Physics.CheckSphere(groundCheckTransform.position, 0.2f, groundLayer) ){
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
        }
    }
}
