using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Fruits
{
    void InitData()
    {
        name = "바나나";
        price = 2000;
        description = "노랗다";
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        InitData();
        base.Start();
    }

}
