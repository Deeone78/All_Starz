using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace TL.Core
{
    public class MoveController : MonoBehaviour
    {
        public NavMeshAgent agent;
        public Transform destination;
        public Transform destination1;
        public static bool throwTime=false;
        bool readyTOBowl = true;
        bool readyTOBowl1 = true;
        public Rigidbody npcBall;
        public Transform bowlBall;
        UIManger uiManager;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            uiManager = GetComponent<UIManger>();
        }

        // Update is called once per frame
        void Update()
        {
            float distance = Vector3.Distance(transform.position, destination.transform.position);
            Vector3 dirToPlayer1 = transform.position - destination1.transform.position;
            Vector3 newPos1 = transform.position - dirToPlayer1;


            Debug.Log(UIManger.player1);
            if (UIManger.player1 == false && UIManger.player2 == true)
            {
                Debug.Log("YOU ARE WORTHY");
                readyTOBowl=true;
                readyTOBowl1 = true;


                Vector3 dirToPlayer = transform.position - destination.transform.position;

                Vector3 newPos = transform.position - dirToPlayer;
                agent.SetDestination(newPos);



            }

            else if (UIManger.player1 == true && UIManger.player2 == false)
            {

                agent.SetDestination(newPos1);

            }



            if (distance < 1f && readyTOBowl == true)
            {

                Debug.Log("I'm ready to bowl");
                Instantiate(npcBall, bowlBall.position, bowlBall.rotation);
                readyTOBowl = false;
            }

            if (ResetBall.amountOfThrows == 1&&readyTOBowl1 == true)
            {
                Instantiate(npcBall, bowlBall.position, bowlBall.rotation);

                readyTOBowl1 = false;

            }
            if (ResetBall.amountOfThrows == -1)
            {

                

            }


            /*
            public void MoveTo(Vector3 position)
            {
                agent.destination = position;
            }
            */

        }
    }
}
