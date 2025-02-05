using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public partial class Knight
    {
        public void Rest()
        {
            // 휴식
            Console.Clear();
            while (true)
            {
                Console.WriteLine("휴식하기");
                Console.WriteLine($"500 G 를 내면 체력을 회복할 수 있습니다. (보유 골드: {gold} G)");
                Console.WriteLine($"현재 당신의 체력은 {hp}입니다.");
                Console.WriteLine();
                Console.WriteLine("1. 휴식하기");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    if (gold >= 500)
                    {
                        Console.Clear();
                        Console.WriteLine("===================================================================");
                        gold -= 500;
                        Console.WriteLine("휴식을 완료했습니다.");
                        hp = 100;
                        Console.WriteLine($"현재 보유 골드는 {gold}입니다.");
                        Console.WriteLine($"현재 당신의 체력은 {hp}입니다.");
                        Console.WriteLine("===================================================================");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("Gold가 부족합니다.");
                        Console.WriteLine("===================================================================");
                    }
                }
                else if (input == "0")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine("===================================================================");
                    Console.WriteLine();
                }

            }
        }

    }
}
