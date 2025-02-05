using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
   
    public partial class Knight
    {
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
                        Console.WriteLine($"공격력 : {atkEquip}");
                    }
                    else
                    {
                        Console.WriteLine($"공격력 : {atkEquip} +({totalAtk})");
                    }
                    if (totalDef == 0) // 스탯 추가 x
                    {
                        Console.WriteLine($"방어력 : {defEquip}");
                    }
                    else
                    {
                        Console.WriteLine($"방어력 : {defEquip} +({totalDef})");
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

    }
}
