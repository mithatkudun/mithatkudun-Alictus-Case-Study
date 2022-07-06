using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel2 : MonoBehaviour
{       
    public GameObject[] Olives;
    GameObject olive;
    [HideInInspector]
    Vector3 spawnOffSet = new Vector3(0.5f, 0, 0.3f);
    float spawnPointZ;
    float spawnPointX;

    void Start()
    {   
        Spawner();
    }
    public void Spawner()
    {
        SpawnerClass Olive = new SpawnerClass();
        Olive.spawntimes = 32;

        for (int i = 0; i < 4; i++)
        {
            spawnPointZ = 0;
            spawnPointX = spawnPointX + spawnOffSet.x;
            Olive.newSpawnXPos = spawnPointX - 1.2f;
            
                for (int c = 0; c < 8; c++)
                {
                spawnPointZ = spawnPointZ + spawnOffSet.z;
                Olive.newSpawnZPos = spawnPointZ + 1.8f;

                Olive.currentPosition = new Vector3(Olive.newSpawnXPos, 0, Olive.newSpawnZPos);
                olive = Instantiate(Olives[0], new Vector3(Olive.newSpawnXPos, 0, Olive.newSpawnZPos), Quaternion.identity);
                olive.transform.parent = gameObject.transform;
              //Olive.prefabslist.Add(prefab);
                }
        }                      
    }
}



