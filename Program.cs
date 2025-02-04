using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace TextRPG
{
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
