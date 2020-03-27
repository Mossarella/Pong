using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour

{
    public Rigidbody2D rb;
    [SerializeField] float speed;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1f, 0f)*speed*Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1f, 0f)*speed*Time.deltaTime;

        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
   
}
