using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{

    [SerializeField] private GameObject PauseMenu;
    rollingsphere mainCode;

    private void Awake() 
    {
        mainCode = GetComponent<rollingsphere>();
    }
    
    public void GoingMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GoingPauseMenu()
    {
        PauseMenu.SetActive(true);
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
    }
}
