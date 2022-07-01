using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBounce : MonoBehaviour
{
    Vector3 lastVelocity;
    Rigidbody2D rb;

    
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity, other.contacts[0].normal);
        rb.velocity = direction;
        Debug.Log("sprawdz");
    }
}