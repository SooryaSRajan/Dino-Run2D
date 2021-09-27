using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HiScore"))
             {
                GetComponent<UnityEngine.UI.Text>().text = "Hi-Score: " + PlayerPrefs.GetInt("HiScore");;
             }
        else{
            GetComponent<UnityEngine.UI.Text>().text = "Hi-Score: 0";
                PlayerPrefs.SetInt("HiScore",0);
                PlayerPrefs.Save();
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
