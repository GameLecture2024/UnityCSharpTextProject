using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : Goods
{
    protected virtual void Start()
    {
        nameText.text = $"과일의 이름 : {name}";
        descriptionText.text = $"상품설명 : {description}";
        priceText.text = $"과일 가격 : {price}";
    }
}

public interface IExpired
{
    void Rotted(); // 과일이 썩었다.
}
