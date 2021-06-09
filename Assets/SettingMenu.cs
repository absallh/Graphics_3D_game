using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class SettingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer Mix;
    public void SetVolume(float volume)
    {
        Mix.SetFloat("Mixer", volume);
    }
    public void Home() 
    {
        SceneManager.LoadScene("MainMenu");
    }
}
