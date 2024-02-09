using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;

    private Vector3 direction;

    void Update()
    {
        // Move the projectile in its direction
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }
}
