using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_score : MonoBehaviour
{
    [SerializeField]
    private int left_score;
    [SerializeField]
    private int right_score;
    
    private Rigidbody2D rb;
    public float serve_force;
    public float serve_position_x;
    public float serve_position_y;
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
            transform.position = new Vector2(serve_position_x,serve_position_y);
            this.gameObject.SetActive(false);
        }
        if(other.gameObject.CompareTag("right_floor")){
            left_score++;
            transform.position = new Vector2(-serve_position_x,serve_position_y);
            this.gameObject.SetActive(false);
        }
    }
    public void Serve(){
        if(transform.position.x == 5){
            rb.AddForce(new Vector2(-serve_force,0),ForceMode2D.Impulse);
        }
        else if(transform.position.x == -5){
            rb.AddForce(new Vector2(serve_force,0),ForceMode2D.Impulse);
        }
    }
}
