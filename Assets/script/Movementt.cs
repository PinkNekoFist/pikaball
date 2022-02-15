using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementt : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 vc;
    public Vector2 vc_U;
    private bool hit;
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "right_floor")
        {
            hit = true;
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
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-vc.x,rb.velocity.y);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(vc.x, rb.velocity.y);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && hit == true)
        {
            rb.velocity = new Vector2(rb.velocity.x,vc_U.y);
            hit = false;
        }
    }
}
