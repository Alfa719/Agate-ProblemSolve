using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUseKey : MonoBehaviour
{
    public float speed = 1f;
    Vector2 movement;
    private Rigidbody2D rigidBody2D;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Momement(h, v);
    }
    void Momement(float h, float v)
    {
        movement.Set(h, v);
        movement = movement.normalized * speed * Time.deltaTime;
        Vector2 position = transform.position;
        rigidBody2D.MovePosition(position + movement);
    }
}
