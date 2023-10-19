using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinRespawn : MonoBehaviour
{
  
    ResetBall resetBall;
    FloorCode floorCode;
    // Start is called before the first frame update
    private Vector3 startPos;

    void Awake()
    {
        resetBall = GetComponent<ResetBall>();
        floorCode = GetComponent<FloorCode>();
    }

    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       if (ResetBall.amountOfThrows == 1 ) 
       { 
        this.transform.position = startPos;
        
        
       }

        if (ResetBall.amountOfThrows == 2)
        {
            this.transform.position = startPos;


        }
    }


}
