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

                if (inform) // 잘 못 입력했을 때 반복적으로 정보 보여주는걸 막기 위해 조건문을 달음
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

                        /* 상태보기에서 제일 문제라고 생각되는 부분..리스트는 타입이 다른 값들이 들어갈 수 있으니  아이템을 리스트로 선언해서 방어력끼리 더하고 공격력끼리 더했어야했는데

                                                굳이 stat배열을 선언해서 string으로 공격력이 들어오면 공격력을 더하고

                                             방어력이 들어오면 방어력을 더하는 코드를 작성한게 진짜 큰 실수라고 생각 든다.*/

                        string[] stat = information[i].Split(" ");
                        if (stat[0] == "공격력" && status[i] == true) // 정보배열에 공격력이면 공격력 상승
                        {
                            totalAtk += int.Parse(stat[1]);



                        }
                        else if (stat[0] == "방어력" && status[i] == true) // 정보배열에 방어력이면 방어력 상승
                        {
                            totalDef += int.Parse(stat[1]);
                        }

                    }
                    if (totalAtk == 0) // 공격력 장비 착용 안했을 때
                    {
                        Console.WriteLine($"공격력 : {atkEquip}"); // 공격력만
                    }
                    else // 장비 장비 착용 했을때
                    {
                        Console.WriteLine($"공격력 : {atkEquip} +({totalAtk})");
                    }
                    if (totalDef == 0)  // 방어력 장비 착용 안했을 때
                    {
                        Console.WriteLine($"방어력 : {defEquip}");
                    }
                    else // 방어력 장비 착용 했을때
                    {
                        Console.WriteLine($"방어력 : {defEquip} +({totalDef})");
                    }
                    Console.WriteLine($"체력 : {hp}");
                    Console.WriteLine($"Gold : {gold} G");

                    inform = false; // 나가기 이외의 다른 값을 눌렀을 때 상태보기 반복을 방지하기 위한 불 값
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
