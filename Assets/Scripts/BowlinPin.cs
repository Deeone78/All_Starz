using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class BowlinPin : MonoBehaviour
{
    
    // Start is called before the first frame update
    public static int score;
    int totalScore = 10;
    UIManger UI_Manager;

    void Start()
    {
        UI_Manager = GetComponent<UIManger>();
    }
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "HitPath")
        {
            AddScore(1);
            Destroy(gameObject, 2.0f);
        }
        
     
    }

    void AddScore(int amount)
    {
        score += amount;
        UI_Manager.UpdateUI(score, totalScore);
    }
    
    
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
