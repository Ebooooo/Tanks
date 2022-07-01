using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets1 : MonoBehaviour
{
    public Player1Controller numBul;
    public float Speed = 5f;
    Vector2 direction;
    Rigidbody2D rb;


    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        numBul = GameObject.Find("Player1").GetComponent<Player1Controller>();
    }

    private void Update()
    {
        rb.AddForce(transform.up * Time.deltaTime * Speed);
    }
    private void OnCollisionEnter2D(Collision2D wall) 
    {
        if(wall.gameObject.CompareTag("WallUP"))
        {
            Debug.Log("uderzylem");
        }
        if(wall.gameObject.CompareTag("WallSide"))
        {
            direction.x = -direction.x;
        }
    }
}
