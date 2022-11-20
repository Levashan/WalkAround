using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTarget : MonoBehaviour
{
    public void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (Input.GetButtonUp("Fire1"))
            {
                Material selectedMaterial = hit.collider.GetComponent<MeshRenderer>().sharedMaterial;
               // selectedMaterial = Color.red;
            }
        }
    }
}
