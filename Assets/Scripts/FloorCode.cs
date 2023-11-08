using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCode : MonoBehaviour
{
    bool knockedOver;
    public bool player1=true;
    //public bool player2=false;
    public int p1Score = 0;
    public int p2Score = 0;
    private int one = 1;
    
    ResetBall resetBall;
    public GameObject pinCheck;
    // Start is called before the first frame update
    void Awake()
    {
        resetBall = GameObject.Find("Pin").GetComponent<ResetBall>();
    }
    void Start()
    {
        knockedOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ResetBall.amountOfThrows == 1)
        {    
            if (knockedOver == true)
            {
                pinCheck.SetActive(false);

            }
        }
        if (ResetBall.amountOfThrows == 2)
        {
            if (knockedOver == true)
            {
                pinCheck.SetActive(false);

            }
        }

        
        if (ResetBall.amountOfThrows == -1&& player1 ==true)
        {
            Debug.Log("Player 2 turn");
            player1 = false;
            
            //pinCheck.SetActive(true);

        }

        if (ResetBall.amountOfThrows == -1 && player1 == false)
        {
            Debug.Log("Player 1 turn");
            
            player1 = true;
            //pinCheck.SetActive(true);

        }

        if (ResetBall.amountOfThrows == -1)
        {

            knockedOver = false;
        }
      
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BowlingAlly" && knockedOver == false)
        {
            knockedOver = true;
            UIManger.AddScore(1);

            /*  if (player1 == true)
              {
                  one+=p1Score;


              }
              if(player1 == false)
              {

                  one+=p2Score;
              }

              */
        }
        
        
    }
}
