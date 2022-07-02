using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPerks : MonoBehaviour
{
    public GameObject perk;
    public GameObject[] perks;
    private int spawnIndex;
    private Transform[] spawnPoints;
    private Vector2 spawnPos;
    public float spawnTime = 10f;
    public float nextSpawn = 0f;
    public int numberOfPerks = 0;
    private int count;


    void Start()
    {
        count = transform.childCount;
        spawnPoints = new Transform[count];
        for(int i = 0; i < count; i++)
        {
            spawnPoints[i] = transform.GetChild(i);
        }

        InvokeRepeating("spawnPerks", 1, 5);
    }

    void Update()
    {
        if(Time.time > nextSpawn && numberOfPerks < 4)
        {
            spawnIndex = Random.Range(0, count);
            nextSpawn = Time.time + spawnTime;
            GameObject perkClone = Instantiate(perks[Random.Range(0, perks.Length)], spawnPoints[spawnIndex].position, perk.transform.rotation) as GameObject;
            numberOfPerks++;
            Destroy(perkClone, 10);
        }
    }
}
