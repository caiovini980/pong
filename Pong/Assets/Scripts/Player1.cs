using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
            if (transform.position.y >= 4.33f)
            {
                transform.position = new Vector3(transform.position.x, 4.33f, transform.position.z);
            }
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
            if (transform.position.y <= -4.33f)
            {
                transform.position = new Vector3(transform.position.x, -4.33f, transform.position.z);
            }
        }

        else
        {
            return;
        }
    }
}
