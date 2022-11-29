using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PriceHolder : MonoBehaviour
{
    [SerializeField] private ObjectInformation[] _objectInfo;
    [SerializeField] private TextMeshProUGUI pricelist;
    private TextMeshProUGUI priceText;


    private void Start() => priceText = GetComponent<TextMeshProUGUI>(); 
    private void FixedUpdate()
    {
        float price = 0f;
        pricelist.text = null;
        for (int i = 0; i < _objectInfo.Length; i++)
        {
            price += _objectInfo[i].objectPriceToCalculate.GetPrice();          
            pricelist.text += $"{_objectInfo[i].objectName} : R {_objectInfo[i].objectPriceToCalculate.GetPrice()} \n";
        }
        priceText.text = price.ToString();
    }
}
[System.Serializable]
public class ObjectInformation
{
    public string objectName;
    public AssignObjectMaterial objectPriceToCalculate;
}