using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform movePos;
    public NavMeshAgent meshAgent;
    public Camera cam;
    RaycastHit hit;
    private void Start()
    {
        meshAgent.SetDestination(movePos.position);

    }
    private void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                meshAgent.SetDestination(hit.point);
            }
        }

        if (meshAgent.transform.position.x == hit.point.x && meshAgent.transform.position.z == hit.point.z)
        {
            meshAgent.SetDestination(movePos.position);
        }
    }
}
