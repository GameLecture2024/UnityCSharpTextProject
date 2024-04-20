using System;   // ~ System을 사용하겠다. Syste nameSpace 사용하겠다.
using A;
using B;
using System.Collections.Generic;

namespace UnityCSharplearn
{
    class MyClassNameISWhatIsmyName
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Player가 공격할 때 주는 데미지 수치를 저장시키고 싶다.
            // 데이터를 저장하고 저장한 데이터를 사용하기 위해서는 저장을 해야한다.
            // 변수 : 데이터를 저장하는 공간이다. "기본 데이터"
            // 변수에 데이터를 저장하기 위해서는 이름과 데이터 타입을 지정해줘야 합니다.
            int damage =  -100;          // (음수 양수)int - 정수형 데이터를 저장할 수 있다.  long
            float time = 3.14f;
            string name = "김동훈"; // 문자열을 저장하는 데이터 타입
            bool isBoy = true;       // 참, 거짓을 저장하는 데이터 타입

            byte sData = 127; // -128 ~ 127
            Console.WriteLine(sData);

            sData = (byte)(sData + 1);
            Console.WriteLine(sData);
             
            short ShortData = 32767; // -32768 ~ 32767 -> 실수하기 좋은 부분입니다.
            Console.WriteLine(ShortData); // 던전앤 파이터.. 데미지 100,200,300..  10억 100억 21억..... 

            int hp = 100;
            //int MYdamage = (int)100000000000; // 21-> -21억 -> 21억 -> 100억 ( - )
            //hp = hp - MYdamage;


            ShortData = (short)(ShortData + 1);
            Console.WriteLine(ShortData);
            // 프로그래밍에서 입문 단계 변수를 작성하는 부분에서 에러가 많이 발생합니다.
            // 변수는 대, 소문자를 구분합니다.

            int Damage = 20;

            var item = 100;
            var character = "루니";
            var isGirl = false;
            var myClassNameISWhatIsmyName = new MyClassNameISWhatIsmyName();

            // 아주 반복적인을 하는 것을 싫어합니다. 타이핑을 길게 하는 것도 싫어하는 족속.

            // 변수는 숫자로 이름을 시작할 수 없습니다.

            //int Damage;

            // 변수의 이름을 작성할 때는 의미있는 이름으로 작성하는 것이 좋다.
            // 프로그래밍 언어가 컴퓨터에게 명령을 내리기 위해 배운다.
            // 작성하는 자는 사람입니다. 

            // 변수에 값을 미리 할당해 주는 것이 좋습니다.
            // 처음 변수에 데이터를 할당해주는 것. 초기화한다.

            // 게임에 필요한 데이터를 사용해야 하는 이유.
            // 가장 큰 범위를 가지는 데이터로 전부다 선언해서 사용하면 되지 않는가?
            // 빈 공간이 너무 많이 생기게 됩니다.

            Object obj = new object();
        }
    }
}


