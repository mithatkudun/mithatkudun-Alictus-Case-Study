using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevelAwards : MonoBehaviour
{
    public GameObject[] awards;
    public GameObject[] inventoryawards;
    public GameObject finishlevelpanel;
    bool isWorking;
    GameObject award;
     void Start()
    {
        isWorking = false;
    }
    void Update()
    {
        GiveAward();
    }
        public void GiveAward()
        {
        SpawnerClass awardsinventory = new SpawnerClass();
        if (finishlevelpanel.activeInHierarchy)
        {   
            if(isWorking == false)
           award = Instantiate(awards[Random.Range(0, awards.Length)], transform.position, transform.rotation);
            award.transform.parent = gameObject.transform;
            awardsinventory.prefabslist.Add(award);
            isWorking = true;
        }
    }
    
}
