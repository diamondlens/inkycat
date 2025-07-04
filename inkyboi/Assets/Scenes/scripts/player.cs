using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{
    //[SerializeField] Transform target;

   // NavMeshAgent agent;


    private Vector3 mousepos;
    public LayerMask whatisground;

    public float jumpVert;

    Rigidbody rb;
    NavMesh navMesh;

    // Start is called before the first frame update
    void Start()
    {
/*
        agent = GetComponent<NavMeshAgent>();
        agent.updateUpAxis = false;
        agent.updateRotation = false;
*/
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //agent.SetDestination(target.position);


        if (Input.GetKeyDown(KeyCode.W)) // ping movent location
        {
            rb.velocity = new Vector3(0, jumpVert, 0);






            RaycastHit hit;
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 100, whatisground))
            {

            }

            //Debug.DrawRay(ray.origin, ray.direction * 100, Color.white);
            //}
        }
        else
        {

        }
    }
}
