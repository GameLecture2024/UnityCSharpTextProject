using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    // 유니티가 C#으로 코드를 작성할 수 있고, C++과 같은 언어가 메모리 관리에 더 효율적이기 때문이다.
    // 모든 코드 작성하는 부분은 공짜가 아닙니다.
    // 변수를 선언해서. 변수에 데이터를 할당했고, 할당한 데이터를 사칙연산, 비교연산으로 데이터를 가공을 했습니다.

    class Memory // 사용자 정의 타입
    {
        public int value = 10;
        public string name = "홍길동";
        public int attack = 100;
        public float attackRange = 3.14f;

        public void AddValue(int _value)
        {
            _value = _value + value;
        }

        public void SomeFunction(int value)
        {
            this.value = 100;
        }
    }
}
