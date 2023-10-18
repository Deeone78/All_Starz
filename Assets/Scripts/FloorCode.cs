using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCode : MonoBehaviour
{
    bool knockedOver;
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
