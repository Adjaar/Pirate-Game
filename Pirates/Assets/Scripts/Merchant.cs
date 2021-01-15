using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Merchant : MonoBehaviour
{
    public NavMeshAgent agent;

    GameObject[] nearGameObjects;
    GameObject closestObject;
    private float oldDistance = 9999;


    void Start()
    {
        if (nearGameObjects == null)
        {
            nearGameObjects = GameObject.FindGameObjectsWithTag("Ammunition");
        }

        CheckNearest();

        agent = GetComponent<NavMeshAgent>();

        //fixes the rotation in place of the agent, otherwise they flip planes of existence
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (closestObject != null)
        {

            transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
            transform.LookAt(closestObject.transform.position, transform.up);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation 

            agent.SetDestination(closestObject.transform.position);
            //move towards the player
            if (Vector3.Distance(transform.position, closestObject.transform.position) < 3f) //move if distance from target is greater than 3
            {
              //  closestObject = null;
                //CheckNearest();
            }

        }
        ChangeWayPoints();
    }

   void ChangeWayPoints()
    {
        if (closestObject == null)
        {
            CheckNearest();
        }
    }

    void CheckNearest()
    {
        foreach (GameObject g in nearGameObjects)
        {
            float dist = Vector3.Distance(this.gameObject.transform.position, g.transform.position);
            if (dist < oldDistance)
            {
                closestObject = g;
                oldDistance = dist;
            }
        }
    }
}

