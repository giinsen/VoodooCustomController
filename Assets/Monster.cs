using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Rigidbody rb = collision.rigidbody;
                
            if (rb != null)
            {
                Enemy e = rb.GetComponent<Enemy>();
                if (e != null)
                {
                    //rb.AddForce(Vector3.right * 12);
                    //collision.transform;
                    Instantiate(GameManager.Instance.particuleDeath, collision.transform.position + Vector3.up *0.2f, Quaternion.identity, transform);
                    e.Die();
                }
            }
        }       
    }

    private float startSpeed;

    private void Start()
    {
        startSpeed = GameManager.Instance.environmentSpeed;
    }

    public void StartAnimation()
    {
        //GameManager.Instance.environmentSpeed = 0f;
    }

    public void FinishAnimation()
    {
        GameManager.Instance.environmentSpeed = startSpeed;
    }
}
