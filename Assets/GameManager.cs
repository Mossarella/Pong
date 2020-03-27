using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball Ball;
    public Paddle PaddleOne;
    public Paddle PaddleTwo;
    
    void Start()
    {
        
        Instantiate (PaddleOne);
        Instantiate (PaddleTwo);
    }

}
