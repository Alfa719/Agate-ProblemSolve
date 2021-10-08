using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScriptRb : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //this.transform.Translate(Vector2.one * Time.timeScale * 0.1f);
        rigidBody2D.AddForce(new Vector2(3, 1));
    }
}
