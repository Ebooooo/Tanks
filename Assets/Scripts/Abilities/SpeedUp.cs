using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public GameObject SpeedPerkIcon;
    public Player1Controller SpeedUp1;
    public Player2Controller SpeedUp2;

    void Start()
    {
        SpeedPerkIcon.SetActive(false);
        SpeedUp1 = GameObject.Find("Player1").GetComponent<Player1Controller>();
        SpeedUp2 = GameObject.Find("Player2").GetComponent<Player2Controller>();
    }

    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D player) 
    {
        if(player.CompareTag("Player1"))
        {
            DestroyObject();
            SpeedUp1.MoveSpeed = 2f;
        }
        if(player.CompareTag("Player2"))
        {
            DestroyObject();
            SpeedUp2.MoveSpeed = 2f;
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject, 0);
    }
}
