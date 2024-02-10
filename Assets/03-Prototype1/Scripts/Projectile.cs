using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float destroyYThreshold = -14f;

    private Vector3 direction;

    void Update()
    {
        // Move the projectile in its direction
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
        if (transform.position.y < destroyYThreshold)
        {
            // Destroy the projectile
            Destroy(gameObject);
        }
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }

    /*void OnCollisionEnter(Collision collision)
    {
        // Check if the projectile collides with the ground object
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Destroy the projectile
            Destroy(gameObject);
        }
    }*/
}
