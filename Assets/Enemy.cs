using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Part target;
    

    public bool dead = false;

    protected virtual void Update()
    {
        if (dead)
        {
            //death anim
            Destroy(gameObject);
            return;
        }
    }

    public virtual void Die()
    {
        dead = true;
        //particule boom
    }
}
