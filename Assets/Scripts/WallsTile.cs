using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsTile : MonoBehaviour
{
    private Vector3 point;
    public GameObject Walls;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 2; i <= 11; i += 3)
        {

            SpawnWalls(i, i + 3);
        }


    }


    // Update is called once per frame
    void Update()
    {

    }

   /* void SpawnWalls()
    {

        for (int i = 0; i < 10; i++)
        {

            int WallsIndex = Random.Range(2, 5);
            Transform SpawnPoint = transform.GetChild(WallsIndex).transform;
            Instantiate(Walls, SpawnPoint.position, Quaternion.identity, transform);
            point = SpawnPoint.position;
            point.z = point.z + 10;
            SpawnPoint.position = point;


        }
        for (int i = 0; i < 5; i++)
        {
            int WallsIndex2 = Random.Range(5, 8);
            Transform SpawnPoint2 = transform.GetChild(WallsIndex2).transform;
            Instantiate(Walls, SpawnPoint2.position, Quaternion.identity, transform);
            point = SpawnPoint2.position;
            point.z = point.z + 10;
            SpawnPoint2.position = point;
        }


    }
    */



void SpawnWalls(int rand1, int rand2)
{


    for (int i = 0; i <3; i++)
    {
        int WallsIndex = Random.Range(rand1, rand2);
        Transform SpawnPoint = transform.GetChild(WallsIndex).transform;
        Instantiate(Walls, SpawnPoint.position, Quaternion.identity, transform);
        point = SpawnPoint.position;
        point.z = point.z + 20;
        SpawnPoint.position = point;
    }
}






}
