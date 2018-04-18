using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavFollow : MonoBehaviour {

    // Use this for initialization
    public Transform player;
    NavMeshAgent agent;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("foo");
        agent.destination = player.position;
        Debug.Log("fjidsfuhdbafubesbfuhye");
	}
}
