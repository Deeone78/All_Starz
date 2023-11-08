using System.Collections;
using TL.UtilityAI.Actions;
using UnityEngine;
using UnityEngine.AI;

namespace TL.Core
{
    public class MoveController : MonoBehaviour
    {
        public NavMeshAgent agent;
        public Transform destination;
        public Transform destination1;
        public Transform destination2;
        public static bool throwTime = false;
        bool readyTOBowl = true;
        bool readyTOBowl1 = true;
        bool readyTOBowl2 = true;
        bool readyTOBowl3 = true;
        public Rigidbody npcBall;
        public Transform bowlBall;
        Vector3 lastPos;
        UIManger uiManager;
        bool isBowling =false;
        bool isPlaying =false;
        public Animator anim;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            uiManager = GetComponent<UIManger>();
            
        }

        // Update is called once per frame
        void Update()
        {
            float distance1 = Vector3.Distance(transform.position, destination2.transform.position);
            float distance = Vector3.Distance(transform.position, destination.transform.position);
            Vector3 dirToPlayer1 = transform.position - destination1.transform.position;
            Vector3 newPos1 = transform.position - dirToPlayer1;
           // Debug.Log(readyTOBowl);
            Debug.Log(isBowling);
           // Debug.Log(UIManger.player1);
          //  Debug.Log(UIManger.player2);
            float movementValueX = Vector3.Distance(transform.position, lastPos) / Time.deltaTime;
            lastPos = transform.position;
            anim.SetFloat("Speed",Mathf.Abs(movementValueX));
            anim.SetBool("IsBowling", isBowling);
            anim.SetBool("IsPlaying", isPlaying);
            
           
            if (distance1<0.5f)
            {
              isPlaying=true;
            }
            else
            {
                isPlaying=false;
            }

            if (UIManger.player1 == true && UIManger.player2 == false)
            {

                agent.SetDestination(newPos1);

            }
            else if (UIManger.player1 == false && UIManger.player2 == true)
            {
                Debug.Log("YOU ARE WORTHY");
                readyTOBowl = true;
                readyTOBowl1 = true;


                Vector3 dirToPlayer = transform.position - destination.transform.position;

                Vector3 newPos = transform.position - dirToPlayer;
                agent.SetDestination(newPos);



            }
            if (readyTOBowl == false)
            {
                StopCoroutine(Shot1());

            }
            if (readyTOBowl1 == false)
            {
                StopCoroutine(Shot2());

            }

            if (distance < 1f && readyTOBowl == true)
            {

                StartCoroutine(Shot1());
                readyTOBowl = false;

            }

            if (ResetBall.amountOfThrows == 1 && readyTOBowl1 == true && distance < 1f)
            {
                Debug.Log("I'm ready to bowl twice");
                StartCoroutine(Shot2());
                readyTOBowl1 = false;
            }

            if (ResetBall.amountOfThrows == -1)
            {



            }
            IEnumerator Shot1()
            {
                yield return new WaitForSeconds(5);
                Debug.Log("I'm ready to bowl"); 
                isBowling = true;
                Instantiate(npcBall, bowlBall.position, bowlBall.rotation);
                yield return new WaitForSeconds(2.5f);
                isBowling=false;


            }
            IEnumerator Shot2()
            {
                yield return new WaitForSeconds(10);
                isBowling = true;
                Instantiate(npcBall, bowlBall.position, bowlBall.rotation);
                yield return new WaitForSeconds(2.5f);
                isBowling = false;





                // isBowling = true;

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
