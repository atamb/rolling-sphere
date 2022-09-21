using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncode : MonoBehaviour
{
   [SerializeField] private GameObject levelsScene;
   [SerializeField] private GameObject SecondLevel;
   [SerializeField] private GameObject ThirdLevel;
   [SerializeField] private GameObject FourthLevel;
   [SerializeField] private GameObject FifthLevel;
   [SerializeField] private GameObject SixthLevel;
   [SerializeField] private GameObject SeventhLevel;
   [SerializeField] private GameObject EighthLevel;
   [SerializeField] private int levelCount;

   public void level1()
    {
        SceneManager.LoadScene(1);
    }

    public void levelsShow()
    {
        levelsScene.SetActive(true);

        levelCount=PlayerPrefs.GetInt("openedLevel");

        if(levelCount>1)
        {
            SecondLevel.SetActive(true);
        }
        if(levelCount>2)
        {
            ThirdLevel.SetActive(true);
        }
        if(levelCount>3)
        {
            FourthLevel.SetActive(true);
        }
        if(levelCount>4)
        {
            FifthLevel.SetActive(true);
        }
        if(levelCount>5)
        {
            SixthLevel.SetActive(true);
        }
        if(levelCount>6)
        {
            SeventhLevel.SetActive(true);
        }
        if(levelCount>7)
        {
            EighthLevel.SetActive(true);
        }
    }

    public void Ball1()
    {
        PlayerPrefs.SetInt("levelWanted", 1);
        SceneManager.LoadScene(1);
    }

    public void Ball2()
    {
        PlayerPrefs.SetInt("levelWanted", 2);
        SceneManager.LoadScene(1);
    }

    public void Ball3()
    {
        PlayerPrefs.SetInt("levelWanted", 3);
        SceneManager.LoadScene(1);
    }

    public void Ball4()
    {
        PlayerPrefs.SetInt("levelWanted", 4);
        SceneManager.LoadScene(1);
    }

    public void Ball5()
    {
        PlayerPrefs.SetInt("levelWanted", 5);
        SceneManager.LoadScene(1);
    }

    public void Ball6()
    {
        PlayerPrefs.SetInt("levelWanted", 6);
        SceneManager.LoadScene(1);
    }

    public void Ball7()
    {
        PlayerPrefs.SetInt("levelWanted", 7);
        SceneManager.LoadScene(1);
    }

    public void Ball8()
    {
        PlayerPrefs.SetInt("levelWanted", 8);
        SceneManager.LoadScene(1);
    }
}
