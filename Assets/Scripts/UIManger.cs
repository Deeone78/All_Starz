using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateUI(int score, int totalScore)
    {
        scoreText.text = "Score" + score + "/" + totalScore;
    }
}
