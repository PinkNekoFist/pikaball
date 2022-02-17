using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 vc;
    public Vector2 vc_U;
    private bool hit;
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "left_floor")
        {
            hit = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "left_floor")
        {
            hit = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-vc.x,rb.velocity.y);
        }
       
        else if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(vc.x, rb.velocity.y);
        }
        else{
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
        if(Input.GetKeyDown(KeyCode.W) && hit == true)
        {
            rb.velocity = new Vector2(rb.velocity.x,vc_U.y);
            hit = false;
        }
    }
}
