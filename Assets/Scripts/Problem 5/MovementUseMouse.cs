using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUseMouse : MonoBehaviour
{
    public float speed = 5f;

    Vector2 movement;
    private Rigidbody2D rigidBody2D;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 position = transform.position;
        cursorPos = cursorPos.normalized * speed * Time.deltaTime;
        rigidBody2D.MovePosition(position + cursorPos);

    }
}
