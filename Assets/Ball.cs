using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public Text Scoreboard;

    public GameObject PaddleOne;
    public GameObject PaddleTwo;

    



    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>();
        
        StartCoroutine(Pause());

        PaddleOne = GameObject.FindWithTag("PaddleOne");
        PaddleTwo = GameObject.FindWithTag("PaddleTwo");
        CountScore.CanAddScore = true;


        //TODO LIMIT BALL SPEED TO CONSTANT
        //TODO SHOOT BALL TO THE LOSE SIDE



    }


    void Update()
    {
        rb.velocity = speed * (rb.velocity.normalized);

        if (this.transform.position.y >= 5.2f || this.transform.position.y <= -5.2f)
        {
            

            CountScore.CanAddScore = true;
            Spawn();
           
            
        }
        
    }
    void Spawn()
    {
        this.transform.position = new Vector3(0f, 0f, 0f);
        StartCoroutine(Pause());
    }

IEnumerator Pause()
    {

        int directionX = Random.Range(-5, 6);
        int[] directionY = new[]{ -1,1};

        
        

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(1);
        rb.velocity = new Vector2(directionX, speed*directionY[Random.Range(0,directionY.Length)]);

        print(rb.velocity);

    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "PaddleOne")
        {
            if (PaddleOne.GetComponent<Rigidbody2D>().velocity.x > 0.5f)
            {
                rb.velocity = new Vector2(10f, 10f);
            }
            else if (PaddleOne.GetComponent<Rigidbody2D>().velocity.x < -0.5f)
            {
                rb.velocity = new Vector2(10f, 10f);
            }
        
        }
        if (hit.gameObject.tag == "Paddletwo")
        {
            if (PaddleTwo.GetComponent<Rigidbody2D>().velocity.x > 0.5f)
            {
                rb.velocity = new Vector2(10f, -10f);
            }
            else if (PaddleTwo.GetComponent<Rigidbody2D>().velocity.x < -0.5f)
            {
                rb.velocity = new Vector2(10f, -10f);
            }
           

        }
    }
}







