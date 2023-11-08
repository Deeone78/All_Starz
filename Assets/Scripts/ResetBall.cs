using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using TL.Core;

public class ResetBall : MonoBehaviour
{
    // Start is called before the first frame update
    public static int amountOfThrows = 0;
    public GameObject ballpos;
    Vector3 ballSpawn;
    public TMP_Text throwAmount;
    bool passthrough =true;


    void Start()
    {

        ballSpawn = ballpos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(amountOfThrows);
        // Debug.Log (MoveController.throwTime);

        //  throwAmount = amountOfThrows;
    }

    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name == "TRIG" && passthrough == true)
        {
            Debug.Log("went through");
            //prefabBall.transform.position = new Vector3(ballSpawn.position.y, ballSpawn.position.x, ballSpawn.position.z);
            // Destroy(other.gameObject);
            //  Instantiate(prefabBall, ballSpawn.position, ballSpawn.rotation);
            StartCoroutine(TRIG1());
            passthrough = false;
        }

    }
    IEnumerator TRIG1()
    {
        yield return new WaitForSeconds(5);
        this.transform.position = ballSpawn;
        amountOfThrows = amountOfThrows + 1;
        passthrough = true;
        


    }
}
