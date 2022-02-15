using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            GameObject.Find("Ball").GetComponent<count_score>().Serve();
        }
        if(count_score.left_score >= 11){
            SceneManager.LoadScene(2);
            count_score.left_score = 0;
            count_score.right_score = 0;
        }
        else if(count_score.right_score >= 11){
            SceneManager.LoadScene(3);
            count_score.right_score = 0;
            count_score.left_score = 0;
        } 
    }
    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
