using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public GameObject SpeedPerkIcon;
    public Player1Controller SpeedUp1;
    public Player2Controller SpeedUp2;
    public SpawnPerks number;

    void Start()
    {
        SpeedUp1 = GameObject.Find("Player1").GetComponent<Player1Controller>();
        SpeedUp2 = GameObject.Find("Player2").GetComponent<Player2Controller>();
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
            SpeedUp1.MoveSpeed = 6f;
        }
        if(player.CompareTag("Player2"))
        {
            DestroyObject();
            SpeedUp2.MoveSpeed = 6f;
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject, 0);
        number.numberOfPerks--;
    }
}
