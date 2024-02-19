using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCamera : MonoBehaviour
{
    public Transform targetObject; // The object to move towards
    public float speed = 5f; // Speed at which the camera moves

    public Text endText; // Reference to the UI text component displaying the end message
    public float stopThreshold = 0.1f; // Threshold to determine when the camera is considered stopped

    void Update()
    {
        if (targetObject != null)
        {
            // Move the camera directly towards the target object
            transform.position = Vector3.MoveTowards(transform.position, targetObject.position, speed * Time.deltaTime);

            // Check if the camera has stopped moving
            if (Vector3.Distance(transform.position, targetObject.position) <= stopThreshold && endText != null)
            {
                endText.gameObject.SetActive(true); // Activate the end text to make it visible
            }
        }
    }

    void Start()
    {
        // Set the end text to inactive (false) at the start
        if (endText != null)
        {
            endText.gameObject.SetActive(false);
        }
    }

}
