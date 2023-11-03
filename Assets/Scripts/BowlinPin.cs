using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class BowlinPin : MonoBehaviour
{
    UIManger uImanger;
    [SerializeField] GameObject pinpre;
    
    
    /*
    // Start is called before the first frame update
    public static int score = 0;
    public static int totalScore = 10;
    
    public static void AddScore(int amount)
    {
        score += amount;

        Debug.Log("UR NO2");
        // UI_Manager.UpdateUI(score, totalScore);
        UIManger.instance.UpdateUI(score, totalScore);
    }
    */
    void Awake ()
    {
       uImanger =pinpre.GetComponent<UIManger>();
    }
   

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "HitPath")
        {
            //UIManger.AddScore(1);
           
           // Destroy(gameObject, 1.5f);
        }
        
     
    }

    
    
    
   

    // Update is called once per frame
  
        
}
