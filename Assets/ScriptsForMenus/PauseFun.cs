using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseFun : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject PauseUI;
   
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
                
            }
        }

    }

    public void Paused()
    {
        PauseUI.SetActive(true);        
        Time.timeScale = 0;
        GameIsPaused = true;
    }
    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    public void PressHome()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
        
    }
    public void pressSetting()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SettingMenu");
       
    }
    public void Quit()
    {
        Application.Quit();
    }
}
