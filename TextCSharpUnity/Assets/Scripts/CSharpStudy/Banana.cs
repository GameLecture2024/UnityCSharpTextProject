using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Fruits
{
    void InitData()
    {
        name = "�ٳ���";
        price = 2000;
        description = "�����";
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        InitData();
        base.Start();
    }

}
