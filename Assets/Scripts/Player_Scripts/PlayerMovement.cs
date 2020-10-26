using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 6;
    public float jumpForce = 100;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleMovement(float vertical, float horizontal, bool grounded) {
        Debug.Log("HandleMovement");
        if (grounded)
        {
            if (vertical > 0) { //Replace horizontal with space bar
                HandleJump();
            }

            rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, 0);
        }
    }

    void HandleJump() {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        //rb.velocity = new Vector3(rb.velocity.x, 0);
    }

}
