using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class chase : MonoBehaviour {

	public Transform player;

    // Use this for initialization
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponentInParent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () 
	{
        //agent = GetComponent<NavMeshAgent>();
        Vector3 tempforward = this.transform.forward;
        tempforward.y = 0;
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
		float angle = Vector3.Angle(direction,this.transform.forward);
		if(Vector3.Distance(player.position, this.transform.position) < 10 && angle < 30)
		{
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, player.transform.position - this.transform.position, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.transform.gameObject.name);
                if(hit.transform.gameObject.tag == "Player")
                {
                    agent.destination = player.position;
                    direction.y = 0;
                }
                else
                {
                    Debug.DrawRay(transform.position, direction * 10, Color.white);
                }
            }



            //this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
            //Quaternion.LookRotation(direction), 0.1f);
        }

	}
}
