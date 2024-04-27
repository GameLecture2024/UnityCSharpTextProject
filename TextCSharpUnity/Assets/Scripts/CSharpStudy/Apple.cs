using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruits, IExpired
{
    void InitData()
    {
        name = "사과";
        price = 1000;
        description = "빨갛다";
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        InitData();
        Rotted();
        base.Start();
    }

    public void Rotted()
    {
        description += "\n 이 과일을 썩을 수 있습니다";
    }
}
