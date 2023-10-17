using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ResetBall : MonoBehaviour
{
    // Start is called before the first frame update
    public static int amountOfThrows =0 ;
    public GameObject ballpos;
    Vector3 ballSpawn;
    public TMP_Text throwAmount;

    void Start()
    {
        
        ballSpawn = ballpos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log (amountOfThrows);
      //  throwAmount = amountOfThrows;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BallCheck")
        {
            //this.transform.position = new Vector3(20.8f, 0.27f, 4.87f);
            this.transform.position = ballSpawn;
            amountOfThrows = amountOfThrows + 1;
        }

        //prefabBall.transform.position = new Vector3(ballSpawn.position.y, ballSpawn.position.x, ballSpawn.position.z);
        // Destroy(other.gameObject);
        //  Instantiate(prefabBall, ballSpawn.position, ballSpawn.rotation);
    }

}
