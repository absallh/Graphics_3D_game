using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountDown : MonoBehaviour
{
    public float TimeValue = 6f;
    public int TimeValue2 = 1;
    public Text TimeText;
    public static CountDown instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (TimeValue > 0)
        {
            TimeValue -= Time.deltaTime;
           
        }
        else
        {
            TimeValue = 0;
            
            
           
        }
        
            DisplayTime(TimeValue);
            End();
        
    }


    void DisplayTime(float TimeToDisplay)
    {
        if (TimeToDisplay < 0)
        {

            TimeToDisplay = 0;
            TimeValue2 = 0;
            Destroy(gameObject);

        }
        float Seconds = Mathf.FloorToInt(TimeToDisplay % 60);

        TimeText.text = string.Format("{0:0}", Seconds);
  


    }

    public bool End() 
    {
        if (TimeValue2 == 0) 
        {
            return false ;
        }

        return true;
    }




}
