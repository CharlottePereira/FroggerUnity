using UnityEngine;

public class Car4 : MonoBehaviour
{

    public Rigidbody2D rb;

    public float minSpeed = 12f;
    public float maxSpeed = 18f;

    float speed = 1f;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

}