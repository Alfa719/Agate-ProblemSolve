using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Movement();
        Turning();
    }
    //Player berjalan sesuai drag mouse
    void Movement()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 newPosition = transform.position;
        cursorPos = cursorPos.normalized * speed * Time.deltaTime;
        rb.MovePosition(newPosition + cursorPos);
    }
    //Player menghadap rotasi sesuai dengan posisi mouse
    void Turning()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = cursorPos + transform.position;
        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        rb.MoveRotation(targetAngle - 25);
        //if (targetAngle > 90)
        //{
          //  transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        //}
        //else if (targetAngle < -90)
        //{
          //  transform.localScale = new Vector3(transform.localScale.x, -transform.localScale.y, transform.localScale.z);
        //}
    }
}
