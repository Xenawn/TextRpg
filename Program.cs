using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace TextRPG
{

    // [구현한 것]
    // 1. 모든 필수 기능 
    // 2. 도전 기능
    //      1)아이템 정보를 클래스/ 구조체로 활용해보기  (o) - Knight 클래스 생성후 행위로 메소드로 아이템이나 상태를 필드로 관리
    //      2)아이템 정보를 배열로 관리 (o)
    //      3)아이템 추가(o) - 나만의 아이템 marketProduct 변수에 상품들 피자폭탄 군주의 갑옷 추가
    //      4)휴식 기능 추가(o) Rest 함수 500 G를 써서 체력을 회복하게 끔 구현
    //      5)장착 개선(o) // atkOverlap, defOverlap 변수로 중복 관리
    //      6)판매하기 (o)
    //      7) 레벨업
    //      8)던전입장
    //      저장 (x)

    // hp가 - 구간으로 가면 0으로 보정했습니다
    // hp가 0이면 던전입장이 불가하여 휴식을 강제해서 참여할 수 있게 끔 만들었습니다.
    
    internal class Program
    {
      
        static void Main(string[] args)
        {
            string input;
            int a = 1;
            int b = -2;

            Knight knight = new Knight();
            while (true)
            {

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("4. 휴식하기");
                Console.WriteLine("5. 던전입장");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요. ");
                Console.Write(">> ");
                input = Console.ReadLine();
                if (input == "1")
                {

                    knight.PrintInformation();
                }
                else if (input == "2")
                {

                    knight.Inventory();
                }
                else if (input == "3")
                {

                    knight.Market();
                }
                else if(input == "4")
                {
                    knight.Rest();
                }
                else if(input =="5")
                {
                    knight.Dungeon();
                }
                else
                {
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine("===================================================================");
                    Console.WriteLine();
                }
            }
        }
    }
}
