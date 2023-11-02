using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCode : MonoBehaviour
{
    bool knockedOver;
    bool player1=true;
    bool player2=false;
    
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
        
        if (ResetBall.amountOfThrows == 2&& player1 ==true)
        {
            Debug.Log("Player 2 turn");
            player1 = false;
            player2 = true;
            //pinCheck.SetActive(true);

        }

        if (ResetBall.amountOfThrows == 2 && player2 == true)
        {
            Debug.Log("Player 1 turn");
            player2 = false;
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
            

        }
        
        
    }
}
