using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    // Start is called before the first frame update
    private float amountOfThrows =0f ;
   // public GameObject prefabBall;
    public Vector3 ballSpawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log (amountOfThrows);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BallCheck")
        {
            //this.transform.position = new Vector3(20.8f, 0.27f, 4.87f);
            transform.position = ballSpawn;
            amountOfThrows = amountOfThrows + 1;
        }

        //prefabBall.transform.position = new Vector3(ballSpawn.position.y, ballSpawn.position.x, ballSpawn.position.z);
        // Destroy(other.gameObject);
        //  Instantiate(prefabBall, ballSpawn.position, ballSpawn.rotation);
    }

}
