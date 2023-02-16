using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private LayerMask pickableLayerMask;

    private float hitRange = 10;

    private RaycastHit hit;

    public GameObject Camera;
    public GameObject lastHighlightedObject;

    // Update is called once per frame
    void ClearHighlighted()
    {
        if (lastHighlightedObject != null)
        {
            lastHighlightedObject.GetComponent<HighlightObject>()?.ToggleHighlight(false, lastHighlightedObject);
            lastHighlightedObject = null;
        }
    }

    void Update()
    {
        Debug.DrawRay(Camera.transform.position, Camera.transform.forward * hitRange, Color.red);

        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, hitRange, pickableLayerMask) & !Camera.GetComponent<MouseLookAround>().CamState)
        {
            hit.collider.GetComponent<HighlightObject>()?.ToggleHighlight(true, hit.transform.gameObject);
            lastHighlightedObject = hit.transform.gameObject;
            if(Input.GetKeyDown("space"))
            {
                Camera.GetComponent<MouseLookAround>().CamState = true;
                Camera.GetComponent<MouseLookAround>().m_CameraObject = lastHighlightedObject;
                ClearHighlighted();
            }
        } else if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, hitRange, pickableLayerMask) & Camera.GetComponent<MouseLookAround>().CamState)
        {
            if (Input.GetKeyDown("space"))
            {
                Camera.GetComponent<MouseLookAround>().CamState = false;
            }
        }
        else
        {
            ClearHighlighted();
        } 

      

    }
}
