using UnityEngine;
using UnityEngine.UI;

public class ObjectMaterialAssigner : MonoBehaviour
{
    private RaycastTarget  raycastTarget;
    [Range(0, 8)] public int indexNumber;
    private void Start() => GetComponent<Button>().onClick.AddListener(() => AssignMat());
    private void AssignMat()
    {
        raycastTarget = FindObjectOfType<RaycastTarget>();
        for (int i = 0; i < raycastTarget.selectedObject.Count; i++)
        {
            var assign = raycastTarget.selectedObject[i].GetComponent<AssignObjectMaterial>();
            if(assign != null)
            {
                if (assign.materialUpdate)  assign.ChangeMaterial(indexNumber);
            }
         }
    }

}
