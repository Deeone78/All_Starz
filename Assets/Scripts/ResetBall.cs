using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabBall;
    public Transform ballSpawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
                
        Destroy(other.gameObject);
        Instantiate(prefabBall, ballSpawn.position, ballSpawn.rotation);
    }

}
