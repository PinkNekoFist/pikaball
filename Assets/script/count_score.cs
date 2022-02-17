using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_score : MonoBehaviour
{
    static public int left_score;
    static public int right_score;
    static public bool whetherLS;    
    static public bool whetherRS;
    private Rigidbody2D rb;
    public float serve_force,save_force;
    public  Vector2 serve_position;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("left_floor")){
            right_score++;
            transform.position = serve_position;
            this.gameObject.SetActive(false);
            whetherRS = true;
        }
        if(other.gameObject.CompareTag("right_floor")){
            left_score++;
            transform.position = new Vector2(-serve_position.x,serve_position.y);
            this.gameObject.SetActive(false);
            whetherLS = true;
        }
    }
    public void Serve(){
        if(whetherLS){
            rb.AddForce(new Vector2(serve_force+3,serve_force),ForceMode2D.Impulse);
            whetherLS = false;
        }
        if(whetherRS){
            rb.AddForce(new Vector2(-serve_force-3,serve_force),ForceMode2D.Impulse);
            whetherRS = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            rb.velocity = new Vector2(rb.velocity.x,save_force);
        }
    }
}
