using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignObjectMaterial : MonoBehaviour
{
    [SerializeField]
    private Material[] materialsAvailable;
    [SerializeField]
    private Sprite[] materialSprites;
    [SerializeField]
    public GameObject[] materialOptions;

    private void Start() => HideMaterialOptions();
    public void DisplayMaterialOptions()
    {
        for (int i = 0; i < materialsAvailable.Length; i++)
        {
            materialOptions[i].SetActive(true);
            materialOptions[i].GetComponent<Image>().sprite = materialSprites[i];
        }
    }
    public void HideMaterialOptions()
    {
        for (int i = 0; i < materialOptions.Length; i++)
        {
            materialOptions[i].SetActive(false);
        }
    }
    public void ChangeMaterial(int index) => GetComponent<MeshRenderer>().material = materialsAvailable[index];
}
