using TMPro;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text player1Text;
    public TMP_Text player2Text;
    public static UIManger instance;
    public GameObject pins;
    public static int score = 0;
    public static int totalScore = 10;
    public static int player1Score = 0;
    public static int player2Score = 0;
    public static int totalPlayer1Score = 300;
    bool hasRun = false;
    ResetBall resetBall;
    FloorCode floorCode;
    bool player1 = true;
    bool player2 = false;
    void Awake()
    {
        instance = this;
        resetBall = GetComponent<ResetBall>();
        floorCode = GetComponent<FloorCode>();

    }
    public static void AddScore(int amount)
    {
        // Debug.Log("YOU DID IT");
        score += amount;
        // UI_Manager.UpdateUI(score, totalScore);
        UIManger.instance.UpdateUI(score, totalScore);

    }
    public static void MinusScore(int amount)
    {
        // Debug.Log("YOU DID IT");
        score -= amount;
        // UI_Manager.UpdateUI(score, totalScore);
        UIManger.instance.UpdateUI(score, totalScore);

    }
    public static void AddPlayer1(int amount)
    {
        player1Score += amount;



        UIManger.instance.UpdateUI1(player1Score);
        Debug.Log("it's running but not doing anything");
    }

    public static void AddPlayer2(int amount)
    {

        player2Score += amount;
        
        UIManger.instance.UpdateUI2(player2Score);
    }
    


    void Update()
    {
       // FloorCode.p1Score = player1Score;
        
       // Debug.Log(score);
        
        if (ResetBall.amountOfThrows == -1 && player1 == true)
        {
            
            AddPlayer1(score);

            if (score!= 0)
            {
                MinusScore(score);


            }
            //pinCheck.SetActive(true);

        }

        else if (ResetBall.amountOfThrows == -1 && player1 == false)
        {


            AddPlayer2(score);


            if (score != 0)
            {
                MinusScore(score);


            }

            //pinCheck.SetActive(true);

        }
        else if (ResetBall.amountOfThrows == 0&& player1==false)
        {
            Debug.Log("Player 1 turn");
            player1 = true;
        }
        else if (ResetBall.amountOfThrows == 0 && player1 == true)
        {

            Debug.Log("Player 2 turn");
            player1 = false;

        }

        if (score == 10 && ResetBall.amountOfThrows == 1 && player1 == false)
        {
            Debug.Log("strike");
            AddPlayer2(score);
            ResetBall.amountOfThrows += 1;

        }
        if (score == 10 && ResetBall.amountOfThrows == 1 && player1 == true)
        {
            Debug.Log("strike");
            AddPlayer1(score);
            ResetBall.amountOfThrows += 1;

        }
        /*if (ResetBall.amountOfThrows==1)
        {

            hasRun = false;

        
        }
        
        */

        if (ResetBall.amountOfThrows == -1)
        {

            /*
            if (player1 == true&&hasRun==false)
            {
               
                
                


            }
            if (player2 == true&& hasRun == false)
            {
               
                
            }

            
            */


        }





    }

    // Update is called once per frame
    public void UpdateUI(int score, int totalScore)
    {
        scoreText.text = "Score:" + score + "/" + totalScore;


    }
    public void UpdateUI1(int player1Score)
    {
        player1Text.text = "Player 1 Score " + player1Score;

    }

    public void UpdateUI2(int player2Score)
    {

        player2Text.text = "Player 2 Score " + player2Score;

    }






}
