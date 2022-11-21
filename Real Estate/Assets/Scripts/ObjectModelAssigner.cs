using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectModelAssigner : MonoBehaviour
{
    private RaycastTarget  raycastTarget;
    [Range(0, 8)]
    public int indexNumber;

    private void Start() => GetComponent<Button>().onClick.AddListener(() => AssignMod());
    private void AssignMod()
    {
        raycastTarget = FindObjectOfType<RaycastTarget>();
        for (int i = 0; i < raycastTarget.selectedObject.Count; i++)
        {
            var assign = raycastTarget.selectedObject[i].GetComponent<AssignObjectMaterial>();
            if(assign != null)
            {
                if (assign.modelUpdate)
                    assign.ChangeModelAndSize(indexNumber);
            }
         }
    }
}
