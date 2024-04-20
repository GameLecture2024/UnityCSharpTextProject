﻿using System.Diagnostics;

namespace 조건문
{
    internal class Program
    {
        // 주석을 빠르게 작성하는 법    
        // shift + ALt + 키보드 아래키
        // ctrl + k + c : 드래그한 코드 전체 주석 처리
        // ctrl + k + U : 드래그한 코드 전체 주석 해제

        // 조건문
        // 설정한 조건이 참 또는 거짓일 때 코드를 실행하거나 실행하지 않고 넘어가서 프로그램의 흐름을 제어하는 문 
        // 종류 : if, switch

        // case1. if문 기본 사용법 : 조건이 true일 때 중괄호 내부를 실행하고 false이면 넘어갑니다.

        // case2. if문 중괄호가 없는 경우? : if 조건 뒤의 한 문장만 if에 포함되는 것으로 간주한다.

        // case3. if문 조건 연산 식뒤에 세미클론을 붙이면 어떻게 되는가? if문장이 끝난 것으로 간주하는 것

        // case4. if ~ else if ~ else

        static void Main(string[] args)
        {
            // 조건식 : true 또는 false 값을 반환하도록 하는 식
            if (false)
            {
                // 코드 1
                Console.WriteLine("코드1 실행");
            }

            // 코드 2
            Console.WriteLine("코드 2 실행");

            //int ifNumber = int.Parse(Console.ReadLine()); 

            if (15 < 10)
                Console.WriteLine("코드 3 실행");
            Console.WriteLine("코드 4 실행");

            // case3

            if (15 < 10) ;   
            Console.WriteLine("코드 5 실행");

            // case4 : 학생 성적 출력하는 코드

            Console.WriteLine("다음 입력은 0 ~ 100사이의 숫자를 입력해주세요");
            int score = int.Parse(Console.ReadLine()); // 학생의 점수를 입력하면 된다.
            
            // 프로그래밍에서는 실행 순서가 정말 정말 중요합니다.
            if(score > 50)
            {
                // 문자열 보간

                Console.WriteLine($"현재 학생의 점수 : {score}");
            }
            else if(score > 60)
            {
                Console.WriteLine($"60보다 수가 큰 학생의 점수 : {score}  ");
            }
            else if(score == 10)
            {
                Console.WriteLine("현재 학생의 점수는 10점입니다");
            }
            else // 위의 조건문에서 놓친 코드를 일괄적으로 처리할 수 있다.
            {
                Console.WriteLine($"현재 학생의 점수 : {score}");
            }

            // Switch ~ case문
            // 1. switch에 조건을 검사할 변수를 설정해줍니다.
            // 2. 변수의 조건에 해당하는 녀석을 case에 설정합니다.
            // 3. 조건을 모두 만족하지 않으면 default로 넘어갑니다.
            // 4. break녀석을 만나면 switch문을 빠져나갑니다.

            Console.WriteLine("switch문을 테스트 하기 위한 숫자 1 ~ 5를 입력해주세요");
            int switchNumber = int.Parse(Console.ReadLine());
            string stringNumner = "3";
            switch(switchNumber)
            {
                case 1:
                    Console.WriteLine("2를 입력하셨습니다.");
                    break;
                case 2:
                    Console.WriteLine("2를 입력하셨습니다.");
                    break;
                case 3:
                    Console.WriteLine("3을 입력하셨습니다.");
                    break;
                case 4:
                    Console.WriteLine("4를 입력하셨습니다.");
                    break;
                case 5:
                    Console.WriteLine("5를 입력하셨습니다.");
                    break;
                default:
                    Console.WriteLine("1 ~ 5 사이의 숫자를 입력해주세요");
                    break;
            }   
        }
    }
}
