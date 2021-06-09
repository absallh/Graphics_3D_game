using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    // Start is called before the first frame update
  private  void Start()
    {
        
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
       
           
        
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

 
   
}

