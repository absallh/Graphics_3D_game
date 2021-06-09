using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject[] playerObjects;
    public int selectedCharacter = 0 ,flag;
    private string selectedCharacterDataName = "Selected Character";

    private void Start()
    {
        HideAllCharacters();
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObjects[selectedCharacter].SetActive(true);
    }
    private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }
    public void NextCharacter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter+=1;
        if(selectedCharacter>= playerObjects.Length)
        {
            selectedCharacter = 0;
         
        }
        playerObjects[selectedCharacter].SetActive(true);
        flag = 0;
    }
    public void PreviousCharachter()
    {
        playerObjects[selectedCharacter].SetActive(false);
        selectedCharacter -= 1;
        if(selectedCharacter< 0)
        {
            selectedCharacter=playerObjects.Length-1;
         
        }
        playerObjects[selectedCharacter].SetActive(true);
        flag = 1;
    }
    public void StartGame()
    {
        if (selectedCharacter == 0)
        {
            SceneManager.LoadScene("ManScene");
        }
        else
        {
            SceneManager.LoadScene("GirlScene");
        }
    }
   
    public void QuitGame()
    {
        Application.Quit();
    }

   
   
    public void Settings()
    {
        SceneManager.LoadScene("SettingMenu");
    }
}
