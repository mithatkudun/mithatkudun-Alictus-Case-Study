using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class InstantiatePrefabs : MonoBehaviour
{   
    public CollisionDetect collisionDetect;
    public GameObject[] prefabs;
    GameObject cherry;
    GameObject banana;
    GameObject hotdog;
    GameObject hamburger;
    GameObject cheese;
    GameObject watermelon;
    public bool watermeloninstantiated = false;
    void InstantiatePrefab()
    {
        SpawnerClass prefab = new SpawnerClass();
        collisionDetect.GetComponent<CollisionDetect>();
        prefab.newSpawnXPos = Random.Range(-0.8f, 0.9f);
        prefab.newSpawnZPos = Random.Range(1f, 4.5f);

        if (collisionDetect.oliveDestroyed == true)
        {
            cherry = Instantiate(prefabs[0], new Vector3(prefab.newSpawnXPos, 1, prefab.newSpawnZPos), Quaternion.identity);
            cherry.transform.parent = gameObject.transform;
            collisionDetect.oliveDestroyed = false;
        }
        collisionDetect.oliveDestroyed = false;
        if (collisionDetect.cherryDestroyed == true)
        {
            banana = Instantiate(prefabs[1], new Vector3(prefab.newSpawnXPos, 1, prefab.newSpawnZPos), Quaternion.identity);
            banana.transform.parent = gameObject.transform;
            collisionDetect.cherryDestroyed = false;
        }
        collisionDetect.cherryDestroyed = false;
        if (collisionDetect.bananaDestroyed == true)
        {
            hotdog = Instantiate(prefabs[2], new Vector3(prefab.newSpawnXPos, 1, prefab.newSpawnZPos), Quaternion.identity);
            hotdog.transform.parent = gameObject.transform;
            collisionDetect.bananaDestroyed = false;
        }
        collisionDetect.bananaDestroyed = false;
        if (collisionDetect.hotdogDestroyed == true)
        {
            hamburger = Instantiate(prefabs[3], new Vector3(prefab.newSpawnXPos, 1, prefab.newSpawnZPos), Quaternion.identity);
            hamburger.transform.parent = gameObject.transform;
            collisionDetect.hotdogDestroyed = false;
        }
        collisionDetect.hotdogDestroyed = false;
        if (collisionDetect.hamburgerDestroyed == true)
        {
            cheese = Instantiate(prefabs[4], new Vector3(prefab.newSpawnXPos, 1, prefab.newSpawnZPos), Quaternion.identity);
            cheese.transform.parent = gameObject.transform;
            collisionDetect.hamburgerDestroyed = false;
        }
        collisionDetect.hamburgerDestroyed = false;
        if (collisionDetect.cheeseDestroyed == true)
        {
            watermelon = Instantiate(prefabs[5], new Vector3(prefab.newSpawnXPos, 1, prefab.newSpawnZPos), Quaternion.identity);
            watermelon.transform.parent = gameObject.transform;
            collisionDetect.cheeseDestroyed = false;
            watermeloninstantiated = true;
        }
        collisionDetect.cheeseDestroyed = false;



    }

    void Update()
    {
        InstantiatePrefab();
    }
}
