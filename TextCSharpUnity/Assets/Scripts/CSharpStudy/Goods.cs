using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goods : MonoBehaviour
{
    protected string name;              // 이름
    protected string description;       // 설명
    protected int price;                // 가격
    
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI priceText;
}
