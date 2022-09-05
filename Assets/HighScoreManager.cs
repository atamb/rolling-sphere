using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText;

    void Start()
    {
        highScoreText.text ="HighScore= " + PlayerPrefs.GetInt("highScore").ToString();
    }


}
