using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleUI : MonoBehaviour
{
    public TextMeshProUGUI DdayText;
    public TextMeshProUGUI DdayTextValue;
    public TextMeshProUGUI ItemInfoText;
    public TextMeshProUGUI ResultText;
    public TextMeshProUGUI TimeText;

    // ��� ����
    int currentDday = 1;
    string curretItem = "�ռҵ�";
    int result = 1000;

    float seconds = 50;    
    float minutes;
    float hours;

    // Start is called before the first frame update
    void Start()                      // ������ �����ϰ� �ѹ��� ����Ǵ� �̺�Ʈ �Լ�
    {
        NextDday(9);
        DdayText.text = "D-day" + " " + currentDday;
        DdayTextValue.text = "1";
        ItemInfoText.text = curretItem;
        ResultText.text = "���� ��� " + result + "��";
    }

    // Update is called once per frame
    void Update()  // ��� ����Ǵ� �κ��� �������ִ� �Լ�
    {
        FlowTime();

        TimeText.text = $"{hours} : {minutes} : {seconds}";
    }

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    } 

    void FlowTime()
    {
        seconds += Time.deltaTime; // ���� �ð� ���� �ð��� �����ش�.

        // seconds�� 60�ʰ� �Ǹ� minutes�� 1���� ��Ű�� seconds�� 0�� �ǵ��� �������ִ� �ڵ�.
        if(seconds >= 60)
        {
            seconds = 0;
            minutes = minutes + 1;
        }

        if(minutes >= 60)
        {
            minutes = 0;
            hours = hours + 1;
        }

        Debug.Log($"���� �ð� : {hours} : {minutes} : {seconds}");

    }
}
