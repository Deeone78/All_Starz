using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinRespawn : MonoBehaviour
{
  
    ResetBall resetBall;
    public GameObject pinPos;
    FloorCode floorCode;
    // Start is called before the first frame update
    private Vector3 startPos;
    private Quaternion rStartPos;
    public GameObject pinCheck1;
    private bool refreash =false;
    

    void Awake()
    {
        resetBall = GetComponent<ResetBall>();
        floorCode = GetComponent<FloorCode>();
        startPos = pinPos.transform.position;
        rStartPos = pinPos.transform.rotation;
    }

    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (ResetBall.amountOfThrows == 1)
        {
           // this.transform.position = startPos;
           // this.transform.rotation = rStartPos;
        }

        if (ResetBall.amountOfThrows == -1)
        {

            refreash = true;
            pinCheck1.transform.position = startPos;
            pinCheck1.transform.rotation = rStartPos;
            

        }

    

        if (ResetBall.amountOfThrows == 0)

        {
            refreash = false;
            StopCoroutine(PlusOne());
          //  this.transform.position = startPos;
          //  this.transform.rotation = rStartPos;

        }


        if (ResetBall.amountOfThrows == 2)
        {


            // pinCheck1.SetActive(true);
            ResetBall.amountOfThrows = -1;
           // this.transform.position = startPos;
          // this.transform.rotation = rStartPos;


        }
        if (refreash == true)

        {
            RespawnP();
            Debug.Log("repostioned");



        }
        if (refreash == false)
        {
          //  pinCheck1.transform.position = pinCheck1.transform.position;
          // pinCheck1.transform.rotation = pinCheck1.transform.rotation;


        }

    }   
    void RespawnP()
    {

        //ResetBall.amountOfThrows = ResetBall.amountOfThrows + 1;
        if (ResetBall.amountOfThrows == -1)
        {
            
        }
            
            StartCoroutine( PlusOne());



    }
    IEnumerator PlusOne()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Smartest in the world");
        refreash = false ; 
        ResetBall.amountOfThrows = 0;

        
    }

}
