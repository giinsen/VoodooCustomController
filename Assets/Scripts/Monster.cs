using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    private float startSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Archer" || collision.gameObject.tag == "Warrior")
        {

            Rigidbody rb = collision.rigidbody;
                
            if (rb != null)
            {
                Enemy e = rb.GetComponent<Enemy>();
                if (e != null)
                {
                    Instantiate(GameManager.Instance.particuleDeath, collision.transform.position + Vector3.up *0.4f, Quaternion.identity, transform);
                    e.Die();
                }
            }
        }
    }

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
