using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EndMenu : MonoBehaviour
{
    
  
    
    
    // Start is called before the first frame update
    private void Start()
    {
     
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Setting()
    {
        SceneManager.LoadScene("SettingMenu");
       
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReStart()
        
    {

        string sceneName = PlayerPrefs.GetString("lastLoadedScene");
        SceneManager.LoadScene(sceneName);

    }
}