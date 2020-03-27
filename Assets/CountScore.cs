using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour
{
    public GameObject saball;
    public Text Scoreboard;


    public static bool CanAddScore = true;




    public int PaddleOneScore = 0;
    public int PaddleTwoScore = 0;

   
    void Start()
    {
        saball=GameObject.FindWithTag("BallTag");

    }


    void Update()
    {


        if (saball.gameObject.transform.position.y >= 5.1f && CanAddScore)
        {
            CanAddScore = false;
            PaddleOneScore += 1;
            

            //Debug.Log("scored");



        }
        else if (saball.gameObject.transform.position.y <= -5.1f && CanAddScore)
        {
            CanAddScore = false;
            PaddleTwoScore += 1;
            







        }
        


        //Debug.Log(PaddleOneScore + "-" + PaddleTwoScore);
        Scoreboard.text = PaddleOneScore.ToString() + "-" + PaddleTwoScore.ToString();

        if (PaddleOneScore>=7)
        {
            SceneManager.LoadScene(2);
        }
        if (PaddleTwoScore>=7)
        {
            SceneManager.LoadScene(3);
        }
    }

    

   
}

