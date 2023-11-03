using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace TL.Core
{
    public class MoveController : MonoBehaviour
    {
        public NavMeshAgent agent;
        public Transform destination;
        public static bool throwTime=false;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            float distance = Vector3.Distance(transform.position, destination.transform.position);
            Vector3 dirToPlayer = transform.position - destination.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;
            agent.SetDestination(newPos);
            if (distance <1f)
            {

                Debug.Log("I'm ready to bowl");

            }
        }
        /*
        public void MoveTo(Vector3 position)
        {
            agent.destination = position;
        }
        */
        
        }
}
