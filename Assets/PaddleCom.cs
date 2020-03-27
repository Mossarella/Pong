using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleCom : MonoBehaviour

{
    public Rigidbody2D rb;
    [SerializeField] float speed;
    public GameObject saball;
    public GameObject leftbound;
    public GameObject rightbound;
    private Vector2 startingPosition = new Vector2(0.029f, 4.19f);
   

    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
        saball = GameObject.FindWithTag("BallTag");
        leftbound = GameObject.FindWithTag("LeftBound");
        rightbound = GameObject.FindWithTag("RightBound");
        transform.localPosition = (Vector2)startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
    }

    void Move()
    {


        if (saball.gameObject.transform.position.x >= rightbound.gameObject.transform.position.x+0.1f&& saball.gameObject.transform.position.y >=-1.2f)
        {
            rb.velocity= new Vector2 (1f,0f)*speed * Time.deltaTime;
            print("A");
        }
        else if (saball.gameObject.transform.position.x <= leftbound.gameObject.transform.position.x-0.1f && saball.gameObject.transform.position.y >= -1.2f)
        {
            rb.velocity = new Vector2(-1f, 0f) * speed * Time.deltaTime;
            print("B");
        }
        else if (rightbound.gameObject.transform.position.x <= saball.gameObject.transform.position.x  &&saball.gameObject.transform.position.x >= leftbound.gameObject.transform.position.x)
        {
            rb.velocity = new Vector2(0f, 0f);
            print("C");
        }
        
    }
}
