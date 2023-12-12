using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Camera cam;

    [Header("Interacatable")]
    public Interactable target;

    [Header("Other Scripts")]
    PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        playerMovement=GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                playerMovement.playerMove(raycastHit.point);

                Interactable ınteractable = raycastHit.collider.GetComponent<Interactable>();

                if(ınteractable != null)
                {
                    SetTarget(ınteractable);
                }
                else
                {
                    removeTarget();
                }
            }
        }
    }

    public void SetTarget(Interactable newTarget)
    {
        target = newTarget;
        playerMovement.followTarget(newTarget);
    }

    private void removeTarget()
    {
        target = null;
        playerMovement.stopFollow();
    }
}
