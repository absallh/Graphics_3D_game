using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiCoins : MonoBehaviour
{
    private int x = 10;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Score.instance.AddPoint(x);

        }


    }
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
    }
}
