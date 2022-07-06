using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel1 : MonoBehaviour
{
    public GameObject[] prefabs;    
    void Start()
    {     
        Spawner();
    }
    public void Spawner()
    {   
        SpawnerClass Olive = new SpawnerClass();
            Olive.spawntimes = 64;

        for (int i = 0; i < Olive.spawntimes; i++)
            {
                    Olive.newSpawnXPos = Random.Range(-1f, 1f);
                    Olive.newSpawnZPos = Random.Range(1.5f, 4.5f);
                    Olive.currentPosition = new Vector3(Olive.newSpawnXPos, 0, Olive.newSpawnZPos) ;
                    prefabs[0] = Instantiate(prefabs[0], new Vector3(Olive.newSpawnXPos, 0, Olive.newSpawnZPos), Quaternion.identity);
                    prefabs[0].transform.parent = gameObject.transform;
                    //Olive.prefabslist.Add(prefabs[0]);
                }    
    }
           
}
        
        
    

