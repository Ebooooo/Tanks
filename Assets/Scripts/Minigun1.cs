using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun1 : MonoBehaviour
{
    public float Speed = 2f;
    public Player1Controller numBul;

    public void Start()
    {
        numBul = GameObject.Find("Player1").GetComponent<Player1Controller>();
    }

    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D walls)
    {
        Destroy(gameObject);
    }
}
