using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Transform target;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }

    public void playerMove(Vector3 point)
    {
        navMeshAgent.SetDestination(point);
    }

    public void followTarget(Interactable newTarget)
    {
        target = newTarget.transform;
    }

    public void stopFollow()
    {
        target = null;
    }
}
