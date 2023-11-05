using System.Collections;
using System.Collections.Generic;
using TL.Core;
using UnityEngine;

public class ResetBallNPC : MonoBehaviour
{
    // Start is called before the first frame update
    
   // public GameObject ballpos;
    Vector3 ballSpawn;
    MoveController moveController;
    Rigidbody rb;
    bool hasRun = false;
    void Start()
    {
    
        moveController = GetComponent<MoveController>();
        rb= GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {
        float power = Random.Range(-0.01f,- 1.1f);
        float direction = Random.Range(-0.01f, 0.01f);
       
        /*
        
        if (MoveController.throwTime == false)
        {
            Debug.Log("IT WORKS VERY WELL");
            //this.transform.position = Vector3.MoveTowards(transform.position, ballSpawn.transform.position,.03);
            this.transform.position = ballSpawn ;
            hasRun = false;


            
        }
      
        */
       
            rb.AddForce(new Vector3(power, direction, 0f), ForceMode.Impulse);
            hasRun = true;
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BallCheck")
        {
            //this.transform.position = new Vector3(20.8f, 0.27f, 4.87f);


            
            ResetBall.amountOfThrows = ResetBall.amountOfThrows + 1;
            Destroy(gameObject);  


        }

        
    }
}
