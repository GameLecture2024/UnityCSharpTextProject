using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 메소드_심화
{
    // ctrl + r + r : 참조되어 있는 모든 이름 일괄 변경 단축키
    // 클래스와 함수의 이름 시작을 대문자
    internal class Parent
    {
        public void Method1() 
        {
            Console.WriteLine("parent의 Method1");
        }
        // virtual : 지금 클래스가 자신의 클래스가 아니라면 (자식이라면) 자식의 함수를 실행하라.
        public virtual void Method2() 
        {
            Console.WriteLine("Parent의 Method2");
        }

        // 함수의 사용 방법. return 있으면 반환 값에 해당하는 데이터 없으면 void
        // 2개 이상의 반환 값을 리턴 해주기 위한 문법 : ref, out

        // ref를 사용하기 위해서는 변수를 미리 선언을 해줘야 한다.
        int shareNumber = 0;       // 몫 저장
        int remainderNumber = 0;   // 나머지 저장

        // reference(참조). 매개 변수로 넘겨준 데이터를 참조해서 저장해두었다가 반환 2개 이상의 데이터를 반환할 수 있게 되는 겁니다.
        public void Divide(int first, int second, ref int shareNumber, ref int remainderNumber) // 몫, 나머지
        {
            // 지역 변수 선언 : 고정된 값만 처리..
            // 매개 변수로 받아와서 : 함수의 결과가 외부에서 받아온 값에 따라 바꾸게 설정.
            first = 3;
            second = 2;

            shareNumber = first / second;  // 몫의 데이터가 shaerNumber에 저장 -> ref 키워드로 보관
            remainderNumber = first % shareNumber; // 수 - 몫 뺀 값 = 나머지를 remainderNumber 저장 - > ref 보관

            // return 1개의 데이터만 반환해주기 때문에.. 2개 이상의 데이터를 반환할 수가 없다.
        }

        // Out 키워드 ref 키워드 역할이 완벽하게 똑같지만, 다른점이 존재합니다.
        // 출력 전용 매개 변수 (ref, out) 함수 내부에서 결과 값을 변환된 내용을 리턴하는 목적.
        // out 키워드로 선언한 변수를 바꾸지 않고 있다!
        // out 키워드로 선언한 변수는 반드시 내부에서 사용되기 때문에, 함수가 선언될 때 변수를 초기화 할 수 있다는 특징
        public void Divide2(int first, int second, out int shareNumber, out int remainderNumber) // 몫, 나머지
        {
            // 지역 변수 선언 : 고정된 값만 처리..
            // 매개 변수로 받아와서 : 함수의 결과가 외부에서 받아온 값에 따라 바꾸게 설정.
            first = 3;
            second = 2;

            shareNumber = first / second;  // 몫의 데이터가 shaerNumber에 저장 -> ref 키워드로 보관
            remainderNumber = first % shareNumber; // 수 - 몫 뺀 값 = 나머지를 remainderNumber 저장 - > ref 보관

            // return 1개의 데이터만 반환해주기 때문에.. 2개 이상의 데이터를 반환할 수가 없다.
        }
    }

    class Child : Parent
    {
        // 내부적 base의 void Method1()을 포함하고 있기 때문에.. 구별해줘야 할 필요가 있습니다.
        // 변수는 base, this 키워드로 구별을 해주었다.

        // new 키워드 : 클래스 선언의 new와는 다른 new입니다. 같은 이름의 키워드여도 문법의 쓰임에 따라 다르게 사용될 수 있다.
        public new void Method1() 
        {
            Console.WriteLine("Child의 Method1");
        } // 부모의 method1 사용하고 싶었는대... new.. Child 클래스만 접근 가능하게 선언

        // override : 부모의 함수 중에서 virtual 명시된 녀석이 있으면 이 키워드가 선언된 함수를 실행한다.
        // override 하고 나서, 부모에 같은 함수가 없으면 에러를 띄워줍니다.
        public override void Method2() 
        {
            Console.WriteLine("Child의 method2");
        }
    }
}
