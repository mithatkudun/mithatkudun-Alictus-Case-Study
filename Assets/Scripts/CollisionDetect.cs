using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    [HideInInspector]
    public bool oliveDestroyed;
    [HideInInspector]
    public bool cherryDestroyed;
    [HideInInspector]
    public bool bananaDestroyed;
    [HideInInspector]
    public bool hotdogDestroyed;
    [HideInInspector]
    public bool hamburgerDestroyed;
    [HideInInspector]
    public bool cheeseDestroyed;
    public int destroyedobject;
    void Start()
    {
        oliveDestroyed = false;
        cherryDestroyed = false;
        bananaDestroyed = false;
        hotdogDestroyed = false;
        hamburgerDestroyed = false;
        cheeseDestroyed = false;
    }
    public void CollisionDetectedOlive(CheckDestroyed checkDestroyed)
    {
        if (checkDestroyed.countolive % 2 != 0)
        {
            oliveDestroyed = true;
            destroyedobject++;
        }
        else
        {
            oliveDestroyed = false;
        }
    }
        public void CollisionDetectedCherry(CheckDestroyed checkDestroyed)
        {

        if (checkDestroyed.countcherry % 2 != 0)
        {
            cherryDestroyed = true;
            destroyedobject++;
        }
        else
        {
            cherryDestroyed = false;
        }
    }
    public void CollisionDetectedBanana(CheckDestroyed checkDestroyed)
    {
        if (checkDestroyed.countbanana % 2 != 0)
        {
            bananaDestroyed = true;
            destroyedobject++;
        }
        else
        {
            bananaDestroyed = false;
        }
    }
    public void CollisionDetectedHotdog(CheckDestroyed checkDestroyed)
    {
        if (checkDestroyed.counthotdog % 2 != 0)
        {
            hotdogDestroyed = true;
            destroyedobject++;
        }
        else
        {
            hotdogDestroyed = false;
        }
    }
    public void CollisionDetectedHamburger(CheckDestroyed checkDestroyed)
    {
        if (checkDestroyed.counthamburger % 2 != 0)
        {
            hamburgerDestroyed = true;
            destroyedobject++;
        }
        else
        {
            hamburgerDestroyed = false;
        }
    }
    public void CollisionDetectedCheese(CheckDestroyed checkDestroyed)
    {
        if (checkDestroyed.countcheese % 2 != 0)
        {
            cheeseDestroyed = true;
            destroyedobject++;
        }
        else
        {
            cheeseDestroyed = false;
        }
    }

}
