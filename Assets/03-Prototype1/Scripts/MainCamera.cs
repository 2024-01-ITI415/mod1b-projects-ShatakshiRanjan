using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform targetObject; // The object to move towards
    public float speed = 5f; // Speed at which the camera moves

    void Update()
    {
        if (targetObject != null)
        {
            // Calculate the direction from the camera to the target object
            Vector3 direction = targetObject.position - transform.position;

            // Normalize the direction to have a magnitude of 1
            direction.Normalize();

            // Move the camera towards the target object
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
