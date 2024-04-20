using System.ComponentModel;

class Calculator
{
    static void Main()
    {
        // 함수를 왜 쓰는가?

        //Console.WriteLine . 콘솔 창에 텍스트를 출력하는 무언가.
        // 함수. 반복적인 실행을 줄이기 위해 사용하는데,
        // 결과 값을 반환할 수도 있고, 안할 수 도 있습니다.

        int a = 10;
        int b = 20;

        // 반환 값이 없는 함수

        void Start() { }
        void Update() { }

        // 반환 값이 있는 함수


        Console.WriteLine("Hello World!");
        Console.WriteLine("안녕하세요, 제 이름은 xxx입니다.");

        int result = Add2(10, 20);

        Console.WriteLine("Add2 함수를 사용한 결과 값은 " + result);

        Add(10, 20);

        // Boolean 타입

        bool isBoy = true;
        Console.WriteLine(isBoy);

        // 동전의 앞면은 1,  동전의 뒷면 0


        string myString = Console.ReadLine();
        Console.WriteLine(myString);
        int coinNumber = int.Parse(Console.ReadLine());  //"1"이 int 1로 변한되어서 coinNumber

        // 주석 : 코드는 사람이 보는 것이기 때문에 설명을 달아둘 수 있다.
        // 연속으로 주석을 달아 둘 수 있다.

        // ctrl + k + c   : 일괄 주석 처리
        // ctrl + k + u   : 일괄 주석 처리 해제
        // alt를 누른상태로 마우스 커서 : 이동 일괄 처리 가능
        // 이동 하고 싶은 코드를 드래그 한 후 alt를 누른 상태로 키보드 화살표 위 아래 사용

        if (coinNumber == 1)
        {
            Console.WriteLine("왼손으로 휘두른다.");
        }
        else if (coinNumber == 0)
        {
            Console.WriteLine("오른손으로 휘두른다.");
        }

        // 두 수를 비교를 해보도록 할게요.

        int front = 10;
        int after = 25;

        bool isFrontValueBiggerThanAfter = front > after; // false
        bool isSame = front == after;
        // bool 데이터 자료형에 !를 앞에 붙여 주면, true -> flase, false -> true로 바뀐다.

        bool isSameAndBigger = front >= after;

        // Quiz2. 다음 결과 값의 결과는 무엇이 나올까요?
        var number = 100;
        var resultB = !(number < 20);

        // Quiz3. a와 b를 더한 결과가 n보다 크거나 같은지 리턴하는 함수를 만들어 보겠습니다.
        Console.WriteLine("불 확인 함수의 결과 값" + BooleanTypeAndOperator(3, 5, 7));

    }

    // Ctrl + M + M : 함수 접거나 펴기
    static void Add(int a, int b) // 결과 값을 반환하지 않는다.
    {
        int sum = a + b;
        Console.WriteLine(sum);
    }
    static int Add2(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // 함수의 문법

    // 반환 값 함수의 이름()
    // {
    //     코드 블럭
    //     실제로 코드를 처리하는 부분을 코드 블럭이라 한다. { 열렸으면, } 닫혀야 합니다. EOF에러.
    // }

    // 반환 값....
    // 함수를 실행하고 나서 결과 값을 반환해주고 싶으면, void 대신 반환하고 싶은 데이터 타입(자료형)을 적어주면 된다.
    // 반환 값이 있는 함수는 반드시 해당 데이터를 return 해줘야 합니다.

    static bool BooleanTypeAndOperator(int a, int b, int n)
    {
        // 두 수를 더한 값이 n 보다 크거나 같으면 true를 리턴하고, 아니면 false를 리턴하도록 만드는 함수,
        if( a+b >= n)
        {
            return true;
        }
        else       
        {
            return false;
        }
    }

}

