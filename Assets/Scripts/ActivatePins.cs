using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePins : MonoBehaviour
{
    // Start is called before the first frame update
    ResetBall resetBall;
    public GameObject pin;
    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public GameObject pin4;
    public GameObject pin5;
    public GameObject pin6;
    public GameObject pin7;
    public GameObject pin8;
    public GameObject pin9;
    void Awake()
    {
        resetBall = GetComponent<ResetBall>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ResetBall.amountOfThrows == 2)
        {
            Debug.Log("parent got there first");
            pin.SetActive(true);
            pin1.SetActive(true);
            pin2.SetActive(true);
            pin3.SetActive(true);
            pin4.SetActive(true);
            pin5.SetActive(true);
            pin6.SetActive(true);
            pin7.SetActive(true);
            pin8.SetActive(true);
            pin9.SetActive(true);
           

        }
    }
}
