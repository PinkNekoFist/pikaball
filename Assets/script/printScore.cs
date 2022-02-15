using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score\n" + count_score.left_score + ":" + count_score.right_score;
    }
}
