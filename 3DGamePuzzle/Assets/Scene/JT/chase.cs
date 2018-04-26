using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class chase : MonoBehaviour {
    public Transform[] Waypoints;
    private int destPoint = 0;
    public Transform player;
    public float timer;
    public float TimeScare;
    public GameObject Scarecanvas1;
    public bool Scare;

    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponentInParent<NavMeshAgent>();
        agent.autoBraking = false;
        GotoNextPoint();
        timer = 6;
    }
	
	void Update () 
	{
        timer += Time.deltaTime;
        Vector3 tempforward = this.transform.forward;
        tempforward.y = 0;
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
		float angle = Vector3.Angle(direction,this.transform.forward);
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
        if (Vector3.Distance(player.position, this.transform.position) < 10 && angle < 30)
		{
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, player.transform.position - this.transform.position, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "Player")
                {
                    agent.destination = player.position;
                    direction.y = 0;
                    timer = 0;
                }
                else
                {
                    Debug.DrawRay(transform.position, direction * 10, Color.white);
                }
            }
        }
         if (timer <= 5)
         {
             agent.destination = player.position;
             direction.y = 0;
         }
    }
    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (Waypoints.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = Waypoints[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % Waypoints.Length;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Scare = true;
            TimeScare += Time.deltaTime;
            if (Scare && TimeScare <= 3)
            {
                Scarecanvas1.GetComponent<Canvas>().enabled = true;
            }
            else
            {
                Scarecanvas1.GetComponent<Canvas>().enabled = false;
              //  TimeScare = 0;
            }
        }
    }
}
