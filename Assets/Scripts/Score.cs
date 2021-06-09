using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text MyScoreText;
    public int ScoreNum;
    public static Score instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = " " + ScoreNum;
    
    }

    // Update is called once per frame
    public void AddPoint(int x)
    {

        ScoreNum += x;
        MyScoreText.text = " " + ScoreNum;

   
    }

 
 
}

