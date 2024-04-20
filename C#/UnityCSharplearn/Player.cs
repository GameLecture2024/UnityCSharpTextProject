using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    static internal class Player // A 개발자
    {
        public static void MyNameSpace()
        {
           // 기능을 작성한다.
        }

    }
    // 캐릭터가 가져야할 특징 => nameSpace
    // 공격, 이동, 정찰, 순찰
}

namespace B
{
    static class Player // B 개발자
    {
        // 플레이가 무엇을 가져야 할까요?
        // 체력            -> 속성
        // 공격력

        // 공격해! 받은 대상의 체력을 공격력 만큼 깍아!
        // 대상의 체력이 0보다 작거나 같니? -> 대상이 죽는다.
        // 기능을 구현합니다.

        public static void Attack()
        {

        }
    }
}
