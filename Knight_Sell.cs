using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
  
    public partial class Knight
    {
        public void Sell()
        {
            // 상점 팔기
            Console.Clear();
            while (true)
            {
                Console.WriteLine("상점 - 아이템판매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{gold} G");

                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                Console.WriteLine("++++ 판매하고 싶은 아이템의 번호를 입력해주세요 ++++ 원가의 85 %의 가격으로 판매 할 수 있습니다 ++++");
                for (int i = 0; i < equipment.Length; i++)
                {
                    if (status[i] == true)
                        Console.WriteLine($"- [{i + 1}] [E]{equipment[i]}   | {information[i]} | {description[i]}");
                    else
                        Console.WriteLine($"- [{i + 1}] {equipment[i]}   | {information[i]} | {description[i]}");
                }

                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요");
                Console.Write(">> ");

                string input = Console.ReadLine();
                int num = int.Parse(input);
                if (input == "0")
                {
                    Console.Clear();
                    break;
                }
                if (int.Parse(input) != 0 && equipment.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++ ");
                    Console.WriteLine("++++ 판매할 아이템이 없습니다!! ++++");
                    Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++ ");

                    continue;
                }


                else if (int.Parse(input) - 1 < equipment.Length)
                {

                    Console.Clear();
                    gold += (int)(equipGold[num - 1] * 0.85);
                    // 판매된 제품 배열 덮어 쓰기 

                    for (int i = num - 1; i < equipment.Length - 1; i++)
                    {
                        equipment[i] = equipment[i + 1];
                        information[i] = information[i + 1];
                        description[i] = description[i + 1];
                        status[i] = status[i + 1];
                        equipGold[num - 1] = equipGold[num];
                    }
                    Array.Resize(ref equipment, equipment.Length - 1);
                    Array.Resize(ref information, information.Length - 1);
                    Array.Resize(ref description, description.Length - 1);
                    Array.Resize(ref status, status.Length - 1);
                    Array.Resize(ref equipGold, equipGold.Length - 1);

                    Console.WriteLine("아이템이 성공적으로 판매되었습니다.");
                    Console.WriteLine($"현재 Gold는 {gold}입니다.");


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
