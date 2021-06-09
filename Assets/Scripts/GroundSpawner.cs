using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 NextSpawnPoint;
    // Start is called before the first frame update
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, NextSpawnPoint, Quaternion.identity);
        NextSpawnPoint = temp.transform.GetChild(1).transform.position;




    }

    // Update is called once per frame
    private void Start()
    {
       
        for (int i = 0; i < 2; i++)
        {

            SpawnTile();


        }
    }
}
