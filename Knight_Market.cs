using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public partial class Knight
    {
        public void Market()
        {
            //상점
            Console.Clear();
            while (true)
            {

                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine(gold + " G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < marketProduct.Length; i++)
                {
                    if (marketGold[i] != "구매완료")
                        Console.WriteLine($"- {marketProduct[i]}    | {marketInfo[i]} | {marketDescription[i]}    | {marketGold[i]} G");
                    else
                        Console.WriteLine($"- {marketProduct[i]}    | {marketInfo[i]} | {marketDescription[i]}    | {marketGold[i]}");
                }

                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("2. 아이템 판매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요");
                Console.Write(">> ");
                string input;
                input = Console.ReadLine();
                Console.WriteLine();


                if (input == "1")
                {
                    Console.Clear();
                    Purchase();
                }
                else if (input == "0")
                {
                    Console.Clear();
                    break;




                }
                else if (input == "2")
                {
                    Sell();
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
