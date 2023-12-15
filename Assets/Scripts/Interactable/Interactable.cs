using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius;
    bool isTarget = false;
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
            if (distance<=radius)
            {
                Debug.Log("interaction enabled");
            }
        }
        
    }

    public void onTarget(Transform playerTransform)
    {
        isTarget=true;
        player=playerTransform;
    }

    public void noTarget()
    {
        isTarget=false;
        player=null; 
    }
    private void OnDrawGizmosSelected() {
       Gizmos.color = Color.red;
       Gizmos.DrawSphere(transform.position,radius);
    }
}
