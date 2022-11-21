using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignObjectMaterial : MonoBehaviour
{

    public bool materialUpdate, modelUpdate;
    [SerializeField]
    private MaterialHolder[] matHolder;
    [SerializeField]
    private ModelHolder[] modHolder;
    [SerializeField]
    private GameObject[] materialOptions;
    [SerializeField]
    private GameObject[] modelOptions;
    
    private void Start() => HideMaterialOptions();
    public void DisplayMaterialOptions()
    {
        if (materialUpdate)
        {
            for (int i = 0; i < matHolder.Length; i++)
            {
                materialOptions[i].SetActive(true);
                materialOptions[i].GetComponent<Image>().sprite = matHolder[i].MaterialSprite;
            }
        }
        if (modelUpdate)
        {
            for (int i = 0; i < modHolder.Length; i++)
            {
                modelOptions[i].SetActive(true);
                modelOptions[i].GetComponent<Image>().sprite = modHolder[i].ModelSprite;
            }
        }
    }
    public void HideMaterialOptions()
    {
        for (int i = 0; i < materialOptions.Length; i++)  materialOptions[i].SetActive(false);
        for (int i = 0; i < modelOptions.Length; i++)  modelOptions[i].SetActive(false);
    }
    public void ChangeMaterial(int index)
    {
        GetComponent<MeshRenderer>().material = matHolder[index].MaterialsAvailable;
    }
    public float PriceUpdater(int index)
    {
        return matHolder[index].MaterialPrice;
    }
    public void ChangeModelAndSize(int index)
    {
        GetComponent<MeshFilter>().mesh = modHolder[index].ObjectMesh;
        this.transform.localScale = modHolder[index].ObjectScale;
    }
}
[System.Serializable]
public class MaterialHolder
{
    public float MaterialPrice;
    public Material MaterialsAvailable;
    public Sprite MaterialSprite;
}
[System.Serializable]
public class ModelHolder
{
    public Mesh ObjectMesh;
    public Sprite ModelSprite;
    public Vector3 ObjectScale;
}