using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleLevel1 : MonoBehaviour
{
    public int destroyedobject;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Olive")
        {
            float OliveY = other.transform.position.y;
            float step = 0.01f * Time.deltaTime;
            OliveY = -1f;
            other.transform.position = Vector3.MoveTowards(other.transform.position, this.transform.position, step).normalized;
            Destroy(other.gameObject);
            destroyedobject++;
        }
    }
}
