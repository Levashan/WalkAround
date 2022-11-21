using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PriceHolder : MonoBehaviour
{
    [SerializeField] private List<AssignObjectMaterial> objectPricesToCalculate = new List<AssignObjectMaterial>();
    private TextMeshProUGUI priceText;

    private void Start() => priceText = GetComponent<TextMeshProUGUI>(); 
    private void FixedUpdate()
    {
        float price = 0f;
        for (int i = 0; i < objectPricesToCalculate.Count; i++)  price += objectPricesToCalculate[i].GetPrice();
        priceText.text = price.ToString();
    }
}
