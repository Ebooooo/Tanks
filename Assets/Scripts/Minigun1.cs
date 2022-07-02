using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun1 : MonoBehaviour
{
    public float Speed = 5f;
    public Player1Controller numBul;
    public Player2Controller numBul1;
    Vector2 direction;
    Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        numBul = GameObject.Find("Player1").GetComponent<Player1Controller>();
        numBul1 = GameObject.Find("Player2").GetComponent<Player2Controller>();
    }

    IEnumerator destroyBulletTime()
    {
        if(gameObject.activeInHierarchy)
        {
            yield return new WaitForSeconds(5);
            numBul.bulletNumber--;
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        rb.AddForce(transform.up * Time.deltaTime * Speed);
        StartCoroutine (destroyBulletTime());        
    }

    private void OnCollisionEnter2D(Collision2D wall) 
    {
        if(wall.gameObject.CompareTag("Player2"))
        {
            numBul1.player2hp--;
        }
    }
}
