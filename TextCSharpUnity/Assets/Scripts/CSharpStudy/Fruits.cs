using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : Goods
{
    protected virtual void Start()
    {
        nameText.text = $"������ �̸� : {name}";
        descriptionText.text = $"��ǰ���� : {description}";
        priceText.text = $"���� ���� : {price}";
    }
}

public interface IExpired
{
    void Rotted(); // ������ �����.
}
