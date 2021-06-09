using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text HScore;

    void Start()
    {
        int Score = PlayerPrefs.GetInt("Score");
        HScore.text = " " + Score;
    }
}
