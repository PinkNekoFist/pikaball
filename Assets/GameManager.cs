using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   public GameObject ball;
    private bool left_gs;
    private bool right_gs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            ball.SetActive(true);
            GameObject.Find("ball").GetComponent<count_score>().Serve();
        }  
    }
}
