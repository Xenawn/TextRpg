using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Knight
    {
        private string name = "나이트셔";
        private string occupation = " 전사 ";
        private int level = 1;
        private int atk = 10;
        private int def = 5;
        private int hp = 20;
        private int gold = 1500;
        private string[] equipment = { "무쇠갑옷", "스파르타의 창", "낡은 검" };
        private string[] information = { "방어력 +5", "공격력 +7", "공격력 +2" };
        private string[] description = { "무쇠로 만드어져 튼튼한 갑옷입니다.", "스파르타의 전사들이 사용했다는 전설의 창입니다.", "쉽게 볼 수 있는 낡은 검입니다." };
        private bool[] status = { false, false, false };
        private int totalAtk = 0;
        private int totalDef = 0;
        private int totalHp = 0;
        private string[] marketProduct = { "수련자 갑옷", "무쇠갑옷", "스파르타의 갑옷", "낡은 검", "청동 도끼", "스파르타의 창", "피자 폭탄", "군주의 갑옷" }; //상점 상품
        private string[] marketInfo = { "방어력 +5", "방어력 +9", "방어력 +15", "공격력 +2", "공격력 +5", "공격력 +7", "공격력 +5", "방어력 +20" }; // 상점 스탯 정보
        private string[] marketDescription = { "수련에 도움 주는 갑옷입니다.", "무쇠로 만들어져 튼튼한 갑옷입니다.", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.",
                "쉽게 볼 수 있는 낡은 검 입니다." ,"어디선가 사용됐던거 같은 도끼입니다.", "스파르타의 전사들이 사용했다는 전설의 창입니다.", "명군이 썼던 피자 폭탄입니다.", "전설의 군주가 입었던 갑옷입니다."};
        private string[] marketGold = { "1000", "구매완료", "3500", "구매완료", "1500", "구매완료", "500", "1000" };

        public void PrintInformation()
        {
            string input;
            bool inform = true;
            while (true)
            {

                if (inform)
                {
                    Console.Clear();
                    Console.WriteLine();
                    if (level < 10)
                    {
                        Console.WriteLine($"Lv. 0{level}");
                    }
                    else
                    {
                        Console.WriteLine($"Lv. {level}");
                    }

                    Console.WriteLine($"Chad ( {occupation} )");
                    totalDef = 0;
                    totalAtk = 0;
                    for (int i = 0; i < equipment.Length; i++) //  장비 합산
                    {

                        string[] stat = information[i].Split(" ");
                        if (stat[0] == "공격력" && status[i] == true)
                        {
                            totalAtk += int.Parse(stat[1]);



                        }
                        else if (stat[0] == "방어력" && status[i] == true)
                        {
                            totalDef += int.Parse(stat[1]);
                        }

                    }
                    if (totalAtk == 0)
                    {
                        Console.WriteLine($"공격력 : {atk}");
                    }
                    else
                    {
                        Console.WriteLine($"공격력 : {atk + totalAtk} +({totalAtk})");
                    }
                    if (totalDef == 0) // 스탯 추가 x
                    {
                        Console.WriteLine($"방어력 : {def}");
                    }
                    else
                    {
                        Console.WriteLine($"방어력 : {def + totalDef} +({totalDef})");
                    }
                    Console.WriteLine($"체력 : {hp}");
                    Console.WriteLine($"Gold : {gold} G");

                    inform = false;
                }

                Console.WriteLine();

                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("===================================================================");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                input = Console.ReadLine();
                Console.WriteLine("===================================================================");

                if (input == "0")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine("다시 입력해주세요.");
                }

            }

        }

        public void Inventory()
        {
            Console.Clear();
            while (true)
            {

                Console.WriteLine("===================================================================");
                Console.WriteLine();
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("===================================================================");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine();


                if (equipment != null)
                {
                    for (int i = 0; i < equipment.Length; i++)
                    {
                        if (status[i] == true)
                            Console.WriteLine($"- [E]{equipment[i]}   | {information[i]} | {description[i]}");
                        else
                            Console.WriteLine($"- {equipment[i]}   | {information[i]} | {description[i]}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Console.Clear();
                    while (true)
                    {
                        int num;


                        Console.WriteLine("===================================================================");
                        Console.WriteLine("인벤토리 - 장착관리");
                        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                        Console.WriteLine("===================================================================");
                        Console.WriteLine();
                        if (equipment != null)
                        {

                            for (int i = 0; i < equipment.Length; i++)
                            {
                                if (status[i] == true)
                                    Console.WriteLine($"- [{i + 1}] [E]{equipment[i]}   | {information[i]} | {description[i]}");
                                else
                                    Console.WriteLine($"- [{i + 1}] {equipment[i]}   | {information[i]} | {description[i]}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("0. 나가기");

                            num = int.Parse(Console.ReadLine());

                            if (num == 0) { Console.Clear(); break; }

                            else if (num <= equipment.Length)
                            {
                                if (status[num - 1] == false)
                                {
                                    Console.Clear();
                                    status[num - 1] = true;
                                }
                                else
                                {
                                    Console.Clear();
                                    status[num - 1] = false;
                                    string[] stat = information[num - 1].Split(" ");
                                    if (stat[0] == "공격력")
                                    {
                                        totalAtk -= int.Parse(stat[1]);



                                    }
                                    else if (stat[0] == "방어력")
                                    {

                                        totalDef -= int.Parse(stat[1]);
                                    }


                                }
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("===================================================================");
                                Console.WriteLine("잘못된 입력입니다.");
                            }

                        }

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

                }


            }
        }

        public void Market()
        {
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
        public void Purchase()  //구매
        {
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

        public void Rest()
        {
            
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
                
                if(input == "1")
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
                else if(input == "0")
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
