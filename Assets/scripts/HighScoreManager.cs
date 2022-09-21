using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText;
    public float whichlevel;
    public float highScorrrrr;

    void Start()
    {
        highScoreText.text ="HighScore= " + PlayerPrefs.GetInt("highScore").ToString();
    }

    private void Update() 
    {
    whichlevel=PlayerPrefs.GetInt("openedLevel");    
    highScorrrrr=PlayerPrefs.GetInt("highScore");
    }


}
