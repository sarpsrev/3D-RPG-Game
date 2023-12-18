using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [Header("Enemy && Player")]

    public float radius;
    bool isTarget = false;
    bool hasInteracrted = false;
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        if (isTarget)
        {
            float distance = Vector3.Distance(player.transform.position,transform.position);
            if (distance<=radius && !hasInteracrted)
            {
                Debug.Log("interaction enabled");
                Interact();
                hasInteracrted=true;
            }
        }
        
    }
    // All Interacts can ovrride with this function
    public virtual void Interact()
    {

    }

    public void onTarget(Transform playerTransform)
    {
        isTarget=true;
        player=playerTransform;
        hasInteracrted=false;
    }

    public void noTarget()
    {
        isTarget=false;
        player=null; 
        hasInteracrted=false;
    }
    
    private void OnDrawGizmosSelected() {
       Gizmos.color = Color.red;
       Gizmos.DrawSphere(transform.position,radius);
    }

}
