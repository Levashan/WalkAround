using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class RaycastTarget : MonoBehaviour
{
    public List<GameObject> selectedObject = new List<GameObject>();
    private bool canRaycast = true;
    [SerializeField]
    private TextMeshProUGUI name;
    public void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.red, 50);
        RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 50))
            {
                if (Input.GetMouseButton(0))
                {
                    selectedObject.Clear();
                    hit.transform.GetComponent<AssignObjectMaterial>().HideMaterialOptions();
                    hit.transform.GetComponent<AssignObjectMaterial>().DisplayMaterialOptions();
                    selectedObject.Add(hit.transform.gameObject);
                    name.text = hit.transform.name;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
    }
    public void ResetCursor()
    {
        for (int i = 0; i < selectedObject.Count; i++)
        {
            selectedObject[i].GetComponent<AssignObjectMaterial>().HideMaterialOptions();
        }
        selectedObject.Clear();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        canRaycast = true;
    }
}
