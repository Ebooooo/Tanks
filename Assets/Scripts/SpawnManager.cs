using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject perkObject;
    private int spawnIndex;
    private Transform[] spawnPoints;
    private Vector2 spawnPos;
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

    public void spawnPerks()
    {
        spawnIndex = Random.Range(0, count);
        Instantiate(perkObject, spawnPoints[spawnIndex].position, perkObject.transform.rotation);
    }
}
