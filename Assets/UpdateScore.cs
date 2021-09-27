using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Score: 0";
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score++;
        GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();

        if(score >= 1000 && score <2000){
            GameManager.gameSpeed = 15;
        }
        else if(score >= 2000 && score <3000){
            GameManager.gameSpeed = 20;
        }
        else if(score >= 3000){
            GameManager.gameSpeed = 25;
        }
        else if(score >= 4000){
            GameManager.gameSpeed = 35;
        }
    }

}
