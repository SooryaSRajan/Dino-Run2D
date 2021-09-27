using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFinalHighScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   

        int finalScore = 0;
        if (PlayerPrefs.HasKey("HiScore"))
             {
                int hiScore = PlayerPrefs.GetInt("HiScore");
                if(UpdateScore.score > hiScore){
                    finalScore = UpdateScore.score;
                    PlayerPrefs.SetInt("HiScore", UpdateScore.score);
                    PlayerPrefs.Save();
                }
                else{
                    finalScore = hiScore;
                }   
             }
        else{
                PlayerPrefs.SetInt("HiScore",UpdateScore.score);
                PlayerPrefs.Save();
                finalScore = UpdateScore.score;
            }

        GetComponent<UnityEngine.UI.Text>().text = "Hi-Score: " + finalScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
