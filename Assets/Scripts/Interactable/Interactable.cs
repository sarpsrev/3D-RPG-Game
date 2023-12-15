using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [Header("Enemy && Player")]

    public float radius;
    bool isTarget = false;
    bool hasInteracrted = false;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTarget)
        {
            float distance = Vector3.Distance(player.transform.position,transform.position);
            if (distance<=radius && !hasInteracrted)
            {
                Debug.Log("interaction enabled");
                hasInteracrted=true;
            }
        }
        
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
