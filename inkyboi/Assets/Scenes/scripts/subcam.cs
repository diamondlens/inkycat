using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class subcam : MonoBehaviour
{
    public GameObject indicator;


    private Vector3 mousepos;
    public LayerMask whatisground;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0)) // ping movent location
        {
            
            RaycastHit hit;
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 100, whatisground))
            
            {
                    //move marker 

                //Debug.Log(hit.point);
                indicator.transform.position = hit.point;
            }
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.white);
        }

    }
}
