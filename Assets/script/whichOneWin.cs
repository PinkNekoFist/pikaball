using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class whichOneWin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerL;
    public GameObject playerR;
    public Text whichwin;
    void Start()
    {
        
        if(GameManager.Lwin == true){
            Instantiate(playerL,new Vector2(0,0),Quaternion.identity);
            whichwin.text = "Player 1 win!";
        }
        if(GameManager.Lwin == false){
            Instantiate(playerR,new Vector2(0,0),Quaternion.identity);
            whichwin.text = "Player 2 win!";
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    
}
