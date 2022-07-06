using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHotDog : MonoBehaviour
{
    public Vector3 targetPos;
    public Vector3 followXonly;
    public float speed = 2.0f;
    public Olive olive;
    void Start()
    {
        targetPos = transform.position;
        
    }

    void Update()
    {
        float distance = Camera.main.transform.position.z - transform.position.z;
        targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        targetPos = Camera.main.ScreenToWorldPoint(targetPos);
        Vector3 followXonly = new Vector3(targetPos.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, followXonly, speed * Time.deltaTime);
    }   
}
