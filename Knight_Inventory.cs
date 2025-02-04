using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public partial class Knight
    {
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
                        Console.WriteLine("번호를 눌러 아이템을 착용 or 미착용 할 수 있습니다.");
                        Console.WriteLine("===================================================================");
                        Console.WriteLine();
                        Console.WriteLine();
                   
                        if (equipment != null)
                        {

                            for (int i = 0; i < equipment.Length; i++) // 아이템 목록 확인
                            {
                                if (status[i] == true) //장착
                                    Console.WriteLine($"- [{i + 1}] [E]{equipment[i]}   | {information[i]} | {description[i]}");
                                else // 미장착
                                    Console.WriteLine($"- [{i + 1}] {equipment[i]}   | {information[i]} | {description[i]}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("0. 나가기");
                            Console.WriteLine();
                            Console.WriteLine("원하시는 행동을 입력해주세요.");
                            Console.Write(">> ");
                            num = int.Parse(Console.ReadLine());

                            if (num == 0) { Console.Clear(); break; }

                            else if (num <= equipment.Length) // 선택인덱스가 장비크기보다 작거나 같아야함
                            {


                                if (status[num - 1] == false) // 입기
                                {
                                    Console.Clear();

                                    string[] stat = information[num - 1].Split(" ");
                                    if (stat[0] == "공격력" && atkOverlap == true) // 이미 공격력장비를 입고있다면
                                    {
                                        Console.Clear();
                                        Console.WriteLine("===================================================================");
                                        Console.WriteLine("중복 불가! 공격력 장비는 하나씩만 입으세요!");
                                        Console.WriteLine("===================================================================");

                                        continue;
                                    }
                                    if (stat[0] == "방어력" && defOverlap == true) // 이미 방어력 장비를 입고 있다면
                                    {
                                        Console.Clear();
                                        Console.WriteLine("===================================================================");
                                        Console.WriteLine("중복 불가! 방어력 장비는 하나씩만 입으세요!");
                                        Console.WriteLine("===================================================================");
                                        continue;
                                    }

                                    status[num - 1] = true;
                                    if (stat[0] == "공격력")
                                    {
                                        atkOverlap = true;

                                    }
                                    else if (stat[0] == "방어력")
                                    {
                                        defOverlap = true;
                                    }
                                }
                                else // 벗기 
                                {
                                    Console.Clear();
                                    status[num - 1] = false;
                                    string[] stat = information[num - 1].Split(" ");
                                    if (stat[0] == "공격력") // 공격력 감소 
                                    {
                                        totalAtk -= int.Parse(stat[1]);
                                        atkOverlap = false; // 중복확인용


                                    }
                                    else if (stat[0] == "방어력") // 방어력 감소 
                                    {

                                        totalDef -= int.Parse(stat[1]);
                                        defOverlap = false; // 중복확인용
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

    }
}
