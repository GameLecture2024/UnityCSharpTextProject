using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruits, IExpired
{
    void InitData()
    {
        name = "���";
        price = 1000;
        description = "������";
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
        description += "\n �� ������ ���� �� �ֽ��ϴ�";
    }
}
