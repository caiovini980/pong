using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 200f;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        Launch();
    }

    public void Reset()
    {
        //rb.velocity = new Vector2(0, 0);
        transform.position = startPosition;
        Launch();
    }

    public void Launch()
    {
        float randomX = Random.Range(0, 2) == 0 ? -1 : 1;
        float randomY = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(randomX * speed, randomY * speed) * Time.deltaTime;
    }
}
