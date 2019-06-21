using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnTimer;

    public GameObject enemy;
    public GameObject spawnerTop;
    public GameObject spawnerMiddle;
    public GameObject spawnerDown;


    void Start()
    {
        spawnTimer = Random.Range(GameManager.Instance.spawnTimerMin, GameManager.Instance.spawnTimerMax);
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            spawnTimer = Random.Range(GameManager.Instance.spawnTimerMin, GameManager.Instance.spawnTimerMax);
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject e;
        float r = Random.Range(0, 2);
        if (r == 0)
        {
            e = Instantiate(enemy, spawnerDown.transform);
            e.GetComponent<Archer>().target = PartManager.allParts[Random.Range(0, PartManager.nbParts - 1)].GetComponent<Part>();
        }
        else if (r == 1)
        {
            e = Instantiate(enemy, spawnerMiddle.transform);
            e.GetComponent<Archer>().target = PartManager.allParts[Random.Range(0, PartManager.nbParts - 1)].GetComponent<Part>();
        }
        //else
        //{
        //    e = Instantiate(enemy, spawnerDown.transform);
        //    e.GetComponent<Archer>().target = PartManager.downParts[Random.Range(0, PartManager.downParts.ToArray().Length)].GetComponent<Part>();
        //}
        
    }
}
