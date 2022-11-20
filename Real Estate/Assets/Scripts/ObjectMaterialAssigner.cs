using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMaterialAssigner : MonoBehaviour
{
    private RaycastTarget  raycastTarget;
    [Range(0, 8)]
    public int indexNumber;

    private void Start()
    {

        GetComponent<Button>().onClick.AddListener(() => AssignMat());
    }

    private void AssignMat()
    {
        raycastTarget = FindObjectOfType<RaycastTarget>();
        for (int i = 0; i < raycastTarget.selectedObject.Count; i++)
        {
            raycastTarget.selectedObject[i].GetComponent<AssignObjectMaterial>().ChangeMaterial(indexNumber);
         }
    }
}
