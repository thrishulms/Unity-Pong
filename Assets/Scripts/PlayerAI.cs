using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    public float speed = 8.0f;
    public Transform ball;

    void Update()
    {
        // Ensure that the ball exists
        if (ball == null)
        {
            Debug.LogError("Ball not assigned to PongAI script.");
            return;
        }

        // Move the AI paddle towards the ball's position
        float targetY = Mathf.MoveTowards(transform.position.y, ball.position.y, speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
    }
}
