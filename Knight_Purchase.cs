using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
 
    public partial class Knight
    {
        public void Purchase()  //구매
        {
            //상점 - 구매
            while (true)
            {

                Console.WriteLine("상점 - 아이템 구매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine(gold + " G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");



                for (int i = 0; i < marketProduct.Length; i++)
                {
                    if (marketGold[i] != "구매완료")
                        Console.WriteLine($"- {i + 1} {marketProduct[i]}    | {marketInfo[i]} | {marketDescription[i]}    | {marketGold[i]} G");
                    else
                        Console.WriteLine($"- {i + 1} {marketProduct[i]}    | {marketInfo[i]} | {marketDescription[i]}    | {marketGold[i]}");
                }

                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요");

                Console.Write(">> ");


                string input = Console.ReadLine();

                int num = int.Parse(input);

                if (num == 0)
                {
                    Console.Clear();
                    break;
                }
                else if (num <= marketProduct.Length) // 사이즈 비교를 위해 int로 변환
                {
                    if (marketGold[num - 1] == "구매완료")
                    {
                        Console.Clear();
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("이미 구매한 아이템입니다.");
                        Console.WriteLine("===================================================================");
                    }
                    else
                    {
                        if (gold >= int.Parse(marketGold[num - 1]))
                        {
                            Console.Clear();
                            gold -= int.Parse(marketGold[num - 1]);
                            Console.WriteLine("===================================================================");
                            Console.WriteLine("구매를 완료했습니다.");
                            Console.WriteLine("===================================================================");
                            Array.Resize(ref equipment, equipment.Length + 1);
                            equipment[equipment.Length - 1] = marketProduct[num - 1];

                            Array.Resize(ref information, information.Length + 1);
                            information[information.Length - 1] = marketInfo[num - 1];

                            Array.Resize(ref description, description.Length + 1);
                            description[description.Length - 1] = marketDescription[num - 1];

                            Array.Resize(ref status, status.Length + 1);
                            status[status.Length - 1] = false;
                            marketGold[num - 1] = "구매완료";

                            Console.WriteLine("[인벤토리 목록]");
                            Console.WriteLine();
                            for (int i = 0; i < equipment.Length; i++)
                            {
                                Console.WriteLine($"{equipment[i]}");
                            }
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
