namespace 반복문
{
    internal class Program
    {
        // 반복문
        // 조건이 거짓이 될 때 까지 코드 블록 내부를 반복해서 실행
        // 종류 : for, while, do ~ while

        static void Main(string[] args)
        {
            // 0. 반복문 왜 필요한가?
            // 1부터 5까지 숫자를 출력하고 싶다.

            // case 1. for 반복문
            // for(초기화식; 조건식; 증감식)
            // { }


            // Tip : 변수의 이름을 일괄적으로 한번에 변경하고 싶습니다!
            // ctrl + R + R : 이름을 일괄적으로 변경해주는 단축키 바꾸고자 하는 이름의 앞에
            // 마우스 커서를 두고 단축키를 입력해주세요.
            for (int number = 1; number <= 5; number++)
            {
                if (number == 3) continue;

                // 조건식이 통과 되었을 때 아래의 코드 블록이 실행된다.
                Console.WriteLine($"출력될 숫자 {number}");
            }

            // case2. 중첩 for 반복문
            for (int x = 1; x < 10; x++)
            {
                for(int y = 1; y < 10; y++)
                {
                    Console.WriteLine($"{x} x {y} = {x*y}");
                }
            }

            // case3. while 반복문
            // while(조건식) 참이면 계속 반복하는 녀석

            int whileNumber = 0;
            int whileSum = 0;
            while(whileNumber < 5)
            {
                int test = 10;

                whileSum += whileNumber;
                test++;
                whileNumber++;
                Console.WriteLine($"test : {test}");
            }
            Console.WriteLine(whileSum);

            // case4 do. while 반복문
            // 반드시 do를 한번은 실행하고 while 조건을 체크하는 녀석

            int doIndex = 15;

            do
            {
                Console.WriteLine($"doIndex : {doIndex}");
                doIndex++;
            }
            while (doIndex < 10);

            
            // case5. 무한 반복문 -> 유니티가 멈추고 강제 종료가 되버립니다.
            // 우리가 무한 반복문이 발생하지 않게 처리를 해야한다.

            //while (true)
            //{
            //    if (조건) return;
            //}

            // case6. 점프문 : 코드를 특정 위치로 이동시키는 명령문
            // break, continue, return, goto

            // break - switch문과 같이 쓰이고, break를 만나면 해당 코드블록으로부터 빠져나온다.
            // continue - 반복문에 쓰이고, continue를 만나면 반복문의 처음으로 돌아갑니다.
            // goto - 특정 레이블로 이동하는 명령문 -> 사용하기를 지양한다.
            // return - 메서드를 종료하고, 메서드를 호출한 곳으로 돌아가는 명령문
        }
    }
}
