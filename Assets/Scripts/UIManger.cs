using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManger : MonoBehaviour
{
    public TMP_Text scoreText;
    public static UIManger instance;
    public GameObject pins;
    public static int score = 0;
    public static int totalScore = 10;
    void Awake()
    {
        instance = this;
    }
    public static void AddScore(int amount)
    {
        Debug.Log("YOU DID IT");
        score += amount;
        // UI_Manager.UpdateUI(score, totalScore);
        UIManger.instance.UpdateUI(score, totalScore);
    }

    void Update()
    {
       

    }

    // Update is called once per frame
    public void UpdateUI(int score, int totalScore)
    {
        scoreText.text = "Score:" + score + "/" + totalScore;
    }
}
