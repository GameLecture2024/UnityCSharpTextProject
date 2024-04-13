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

    int currentDday = 1;
    string curretItem = "롱소드";
    int result = 1000;

    // Start is called before the first frame update
    void Start()                      // 게임이 시작하고 한번만 실행되는 이벤트 함수
    {
        NextDday(9);
        DdayText.text = "D-day" + " " + currentDday;
        DdayTextValue.text = "1";
        ItemInfoText.text = curretItem;
        ResultText.text = "금일 결과 " + result + "원";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    } 
}
