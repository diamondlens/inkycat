using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class playercam : MonoBehaviour
{

    private Vector3 mousepos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Mouse0)) // ping movent location
        {
            //need to add a second camera for screen to world point.
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Physics.Raycast(mousepos, transform.TransformDirection(Vector3.forward), Mathf.Infinity))
            {
                print("sucess");
            }
            Debug.DrawRay(mousepos, transform.TransformDirection(Vector3.forward) *100, Color.white);
        }
        */
        if (Input.GetKeyDown(KeyCode.Mouse1)) //ROTATE CAM
        {
         print("hi");
        }
    }
}
