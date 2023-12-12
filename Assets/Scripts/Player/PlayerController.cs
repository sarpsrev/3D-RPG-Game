using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Camera cam;
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
            }
        }
    }
}
