using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunActive : MonoBehaviour
{
    public GameObject MinigunIcon;
    public Player1Controller MinigunActive1;
    public Player2Controller MinigunActive2;
    public SpawnPerks number;

    void Start()
    {
        MinigunActive1 = GameObject.Find("Player1").GetComponent<Player1Controller>();
        MinigunActive2 = GameObject.Find("Player2").GetComponent<Player2Controller>();
        number = GameObject.Find("SpawnPerks").GetComponent<SpawnPerks>();
    }

    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D player) 
    {
        if(player.CompareTag("Player1"))
        {
            DestroyObject();
            MinigunActive1.perkMinigunActive = true;
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject, 0);
        number.numberOfPerks--;
    }
}