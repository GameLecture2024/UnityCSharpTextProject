namespace 메소드_심화
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 클래스 변수 이름에 . 을 붙이면, 클래스 멤버에 접근을 할 수 있습니다.
            // 접근 지정자가 허용하는 데이터만 접근이 가능합니다.

            int shareNumber = 0;
            int remainNumber = 0;
            
            Parent parent = new Parent();
            parent.Method1();
            parent.Method2();
            parent.Divide(3, 2, ref shareNumber, ref remainNumber); // ref 할당되지 않은 변수를 매개 변수 넘겨줄 수 없지만
            parent.Divide2(3, 2, out int s1, out int r1);           // out 매개 변수에 선언하면서 넘겨줄 수 있다.
                                                                    // out 키워드를 사용해서.. 총을 쐇을 때 충돌한 점의 정보 out 반환

            Console.WriteLine($"나눈 결과 값 확인 :  몫 : {shareNumber} \n나머지:{remainNumber}");

            Parent child = new Child();
            child.Method1();
            child.Method2();

        }
    }
}
