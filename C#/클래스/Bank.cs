using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    internal class Bank
    {
        // 멤버 변수 : 같은 클래스에 소속된 메소드(함수) 이 변수를 공용으로 사용할 수 있다.
        // 생성하고 싶은 멤버 변수를 전부 드래그한 다음에 "ctrl + ." 단축키, 또는 마우스 우클릭 빠른 작업 리팩토링 - 생성자 생성
        public string name;
        public int money;

        // 생성자 오버로딩
        public Bank(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public Bank()
        {

        }
        // 소멸자 : 객체가 소멸될 때 호출되는 메소드
        ~Bank()
        {

        }

        // 접근 지정자
        // public    : 외부에서 클래스를 통해 접근을 허용한다.
        // private   : 외부에서 클래스 접근을 허용하지 않고, 자식 클래스에도 접근이 불가능
        // protected : 외부에서 클래스 접근을 허용하지 않고, 자식 클래스에는 버근을 허용

        // 접근 지정자를 왜 사용 하는가?
        // 기능을 제한하는 것도 한 가지 기능. 
        // 사람은 항상 실수를 할 수 있다. 사람이 할 수 잇는 실수를 원척적으로 막고 싶어요.
        // 기능을 제한하는 기능을 구현하면 실수를 막을 수 있다.



        public void Deposit(int depositMoney)
        {
            money = money + depositMoney;
        }

        // 외부에서 이 클래스를 사용하는 사람이.. 알 필요가 없는 녀석은 숨겨 두는 것.
        private void InternalFunc()
        {
            // ATM 출금해줘!
            // 소리를 내고, 돈을 찾는 것 같은 시간 후에, 금액을 출금해줍니다.
        }

        public void Withdraw(int withdrawMoney)
        {
            if (money < withdrawMoney)
            {
                Console.WriteLine("통장 잔고보다 큰 금액을 인출하려고 했습니다.");
                return;
            }

            money = money - withdrawMoney;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name}에 {money}원이 들어 있습니다.");
        }
    }
}
