using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olive : MonoBehaviour
{
    public MoveHotDog moveHotDog;
    public Rigidbody rb;
    float ForceMulti = 500f;
    public GameObject Hotdog;
    public int destroyedobject;
    public void Start()
    {
        Vector3 startforce = new Vector3(0, 0, -150f);

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(startforce);
    }
    public void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        float distance = Camera.main.transform.position.z - transform.position.z;
        Vector3 targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        targetPos = Camera.main.ScreenToWorldPoint(targetPos);
        Vector3 force = new Vector3(Hotdog.transform.position.x-gameObject.transform.position.x,0, gameObject.transform.position.z - Hotdog.transform.position.z);
        if (collision.gameObject.tag == "Hotdog")
        {
            rb.AddForce(new Vector3(force.x * ForceMulti, 0, force.z * ForceMulti));
        }
        if(collision.gameObject.tag =="Cherry")
        {
            Destroy(collision.gameObject);
            rb.velocity = rb.velocity * 2f;
            destroyedobject++;
        }
        if(collision.gameObject.tag=="Banana")
        {
            Destroy(collision.gameObject);
            Hotdog.transform.localScale = new Vector3(Hotdog.transform.localScale.x * 2f, Hotdog.transform.localScale.y, Hotdog.transform.localScale.z);
            destroyedobject++;
        }
        if(collision.gameObject.tag =="Watermelon")
        {
            Destroy(collision.gameObject);
            this.transform.localScale = new Vector3(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f, transform.localScale.z * 1.5f);
            ForceMulti = ForceMulti * 1.5f;
            destroyedobject++;
        }
        if(collision.gameObject.tag =="Hamburger")
        {
            Destroy(collision.gameObject);
            moveHotDog.followXonly = new Vector3(-moveHotDog.targetPos.x, moveHotDog.transform.position.y, moveHotDog.transform.position.z);
            Hotdog.transform.position = Vector3.Lerp(Hotdog.transform.position, moveHotDog.followXonly, moveHotDog.speed * Time.deltaTime);
            destroyedobject++;
        }
        if(collision.gameObject.tag =="BounceWall")
        {
            rb.AddForce(new Vector3(Random.Range(-1f,1f), 0, Random.Range(-1f,1f))*ForceMulti/4);
        }
        if(collision.gameObject.tag == "Cheese")
        {
            Destroy(collision.gameObject);
            destroyedobject++;

        }
    }

 
    
    public void Update()
    {
        if (rb.velocity.z == 0 && rb.velocity.x == 0)
        {
            rb.AddForce(new Vector3(rb.velocity.z, 0, Random.Range(-1, 1    ) *10* ForceMulti));
        }
    }
}
