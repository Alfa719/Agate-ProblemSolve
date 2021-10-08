using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyAndRespawn : MonoBehaviour
{
    public float speed = 5f;
    public GameObject Triangle;

    private Text scoreText;
    Vector2 movement;
    private Rigidbody2D rigidBody2D;
    void Start()
    {
        ScoreScript.score = 0;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Triangle"))
        {
            ScoreScript.AddScore(1);
            scoreText.text = "Score : " + ScoreScript.score;
            Destroy(collision.gameObject);

            StartCoroutine(EdoTensei(collision.gameObject));
        }
    }
    IEnumerator EdoTensei(GameObject prefab)
    {
        yield return new WaitForSeconds(3);
        Instantiate(Triangle, new Vector2(Random.Range(6.32f, -6.32f), Random.Range(3.37f, -3.37f)), Quaternion.identity);
    }
}
