using TMPro;
using UnityEngine;

public class PriceHolder : MonoBehaviour
{
    private static TextMeshProUGUI priceText;

    private void Start()
    {
        priceText = GetComponent<TextMeshProUGUI>();
    }
    private static float price;
    public static float OverAllPrice
    {
        get => price;
        set
        {
            price = value;
            priceText.text = value.ToString();
        }
    }
}
