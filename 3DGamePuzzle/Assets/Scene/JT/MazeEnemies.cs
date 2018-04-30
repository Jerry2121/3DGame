using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class MazeEnemies : MonoBehaviour
{
    public Transform[] Waypoints;
    private int destPoint = 0;
    public Transform player;
    public GameObject Test;
    public float timer;
    public float TimeScare;
    public float TimeScareInt;
    public bool ScareAct;
    public bool ScarTrig;

    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponentInParent<NavMeshAgent>();
        agent.autoBraking = false;
        GotoNextPoint();
        timer = 6;
    }

    void Update()
    {
        TimeScareInt += Time.deltaTime;
        TimeScare += Time.deltaTime;
        timer += Time.deltaTime;
        Vector3 tempforward = this.transform.forward;
        tempforward.y = 0;
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (TimeScareInt >= 2)
        {
            ScarTrig = false;
        }
        if (TimeScare >= 3 && TimeScareInt >= 2)
        {
            ScareAct = false;
        }

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
                    TimeScare = 0;
                    TimeScareInt = 0;
                    ScareFunction();
                }
                else
                {
                    Debug.DrawRay(transform.position, direction * 10, Color.white);
                }
            }
        }
        if (timer <= 2)
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
    void ScareFunction()
    {
        ScareAct = true;
        if (ScareAct == true && ScarTrig == false)
        {
            AudioSource Audio = Test.GetComponent<AudioSource>();
            Audio.Play();
            ScarTrig = true;
        }
    }
}
