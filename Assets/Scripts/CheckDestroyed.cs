using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDestroyed : MonoBehaviour
{
    [HideInInspector]
    public int countolive;
    [HideInInspector]
    public int countcherry;
    [HideInInspector]
    public int countbanana;
    [HideInInspector]
    public int counthotdog;
    [HideInInspector]
    public int counthamburger;
    [HideInInspector]
    public int countcheese;
    [HideInInspector]
    public Vector3 lastpos;
    public static CheckDestroyed Instance;
    void Awake()
    {
        Instance = this;
    }
    public void OnCollisionEnter(Collision collision)
    {   
        
        if(collision.gameObject.tag == gameObject.tag )
        {

                if (gameObject.tag=="Olive")
                {                
                countolive++;
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                transform.parent.GetComponent<CollisionDetect>().CollisionDetectedOlive(this);                
                }
                if (gameObject.tag == "Cherry")
                {                  
                    countcherry++;
                    Destroy(collision.gameObject);
                    
                    transform.parent.GetComponent<CollisionDetect>().CollisionDetectedCherry(this);
                   
                }               
                if (gameObject.tag == "Banana")
                {
                    lastpos = collision.transform.position;
                    countbanana++;
                    Destroy(collision.gameObject);
                    
                    transform.parent.GetComponent<CollisionDetect>().CollisionDetectedBanana(this);                  
                }
                if (gameObject.tag == "Hotdog")
                {                   
                    counthotdog++;
                    Destroy(collision.gameObject);
                    Destroy(this.gameObject);
                    transform.parent.GetComponent<CollisionDetect>().CollisionDetectedHotdog(this);                   
                }
                if (gameObject.tag == "Hamburger")
                {                    
                    counthamburger++;
                    Destroy(collision.gameObject);
                    Destroy(this.gameObject);
                    transform.parent.GetComponent<CollisionDetect>().CollisionDetectedHamburger(this);             
                }
            if (gameObject.tag == "Cheese")
            {
                countcheese++;
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                transform.parent.GetComponent<CollisionDetect>().CollisionDetectedCheese(this);
            }
            if (gameObject.tag == "Watermelon")
            {
                return;
            }

        }
        }
    }



