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
            faceTarget();
        }
    }

    public void playerMove(Vector3 point)
    {
        navMeshAgent.SetDestination(point);
    }

    public void followTarget(Interactable newTarget)
    {
        target = newTarget.transform;
        navMeshAgent.stoppingDistance = newTarget.radius;
        navMeshAgent.updateRotation=false;
    }

    public void stopFollow()
    {
        target = null;
        navMeshAgent.stoppingDistance = 0f;
        navMeshAgent.updateRotation=true;
    }

    public void faceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0f,direction.z));
        transform.rotation=Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * 5f);
    }
}
