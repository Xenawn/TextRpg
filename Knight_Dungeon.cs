using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
   
    public partial class Knight
    {
        public void Dungeon()
        {
            //던전
            Console.Clear();
            Random random = new Random(); // 체력 감소 난수 생성
            int minusHp = random.Next(20, 36);  // 체력 감소 20 ~35
            int supGold;
            bool clear = false;
         
            while (true)
            {
                if (hp <= 0)
                {
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("휴식하세요 던전을 돌 수 있는 체력이 아닙니다.");
                    Console.WriteLine("===================================================================");
                    break;
                }
                Console.WriteLine("던전입장");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine("1. 쉬운 던전     | 방어력 5 이상 권장");
                Console.WriteLine("2. 일반 던전     | 방어력 11 이상 권장");
                Console.WriteLine("3. 어려운 던전    | 방어력 17이상 권장");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                string input = Console.ReadLine();
                int beforeHp;
                int befoeGold;
                int appDef; // 방어력 체력소모 반영앙
                if (input == "1") // 쉬운 던전 입장
                {
                    if (def >= 5)
                    {
                        Console.Clear();
                        Console.WriteLine("던전 클리어");
                        Console.WriteLine("축하합니다!!");
                        Console.WriteLine("쉬운 던전을 클리어 하였습니다.");
                        Console.WriteLine("[탐험결과]");
                        Console.WriteLine();
                        beforeHp = hp;
                        befoeGold = gold;
                        appDef = minusHp - (defEquip - 5);
                        hp -= appDef;
                        if (hp <= 0)
                        {
                            hp = 0;
                        }
                        gold += 1000;
                        clear = true;
                        Console.WriteLine($"체력 {beforeHp} -> {hp}");
                        Console.WriteLine($"Gold {befoeGold} -> {gold}");
                       
                        supGold = random.Next(((int)atkEquip), ((int)atkEquip)*2+1);
                        double goldPercent = (double)supGold / 100;
                        Console.WriteLine("!!!!!!"+1000 * goldPercent +"추가 보상입니다.!!!");
                        befoeGold = gold;
                        gold += (int)(1000 * goldPercent);
                        Console.WriteLine($"Gold {befoeGold} -> {gold}");
                      
                        clearTime++;
                        LevelUp();
                        Console.WriteLine();
                        Console.WriteLine("0. 나가기 ");
                        Console.WriteLine("1. 계속 던전돌기");
                        Console.WriteLine();
                    }
                    else
                    {
                        //권장 방어력보다 낮다면
                        //권장 방어력 보다 낮다면
                        Console.Clear();
                        int dPercent = random.Next(1, 11);

                        if (dPercent <= 4)
                        {
                            Console.Clear();
                            Console.WriteLine("던전 실패했습니다.");
                            hp /= 2;
                            Console.WriteLine("0. 나가기 ");

                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine("던전 클리어");
                            Console.WriteLine("축하합니다!!");
                            Console.WriteLine("쉬운 던전을 클리어 하였습니다.");
                            Console.WriteLine("[탐험결과]");
                            Console.WriteLine();
                            beforeHp = hp;
                            befoeGold = gold;
                            appDef = minusHp - (defEquip - 5);
                            hp -= appDef;
                            if (hp <= 0)
                            {
                                hp = 0;
                            }
                            gold += 1000;
                            clear = true;
                            Console.WriteLine($"체력 {beforeHp} -> {hp}");
                            Console.WriteLine($"Gold {befoeGold} -> {gold}");

                            supGold = random.Next(((int)atkEquip), ((int)atkEquip) * 2 + 1);
                            double goldPercent = (double)supGold / 100;
                            Console.WriteLine("!!!!!!" + 1000 * goldPercent + "추가 보상입니다.!!!");
                            befoeGold = gold;
                            gold += (int)(1000 * goldPercent);
                            Console.WriteLine($"Gold {befoeGold} -> {gold}");
                       
                            clearTime++;
                            LevelUp();
                            Console.WriteLine();
                            Console.WriteLine("0. 나가기 ");
                            Console.WriteLine("1. 계속 던전돌기");
                            Console.WriteLine();
                        }
                    }
                }
              

                else if (input == "2") // 어려움 던전 입장
                {
                    if (def >= 11) // 권장 방어력
                    {
                        Console.Clear();
                        Console.WriteLine("던전 클리어");
                        Console.WriteLine("축하합니다!!");
                        Console.WriteLine("일반 던전을 클리어 하였습니다.");
                        Console.WriteLine("[탐험결과]");
                        Console.WriteLine();
                        beforeHp = hp;
                        befoeGold = gold;
                        appDef = minusHp - (defEquip - 11);
                        hp -= appDef;
                        gold += 1700;
                        if (hp <= 0)
                        {
                            hp = 0; // 체력 음수 보정
                        }
                        Console.WriteLine($"체력 {beforeHp} -> {hp}");
                        Console.WriteLine($"Gold {befoeGold} -> {gold}");

                        supGold = random.Next(((int)atkEquip), ((int)atkEquip) * 2 + 1);
                        double goldPercent = (double)supGold / 100;
                        Console.WriteLine("!!!!!!" + 1700 * goldPercent + "추가 보상입니다.!!!");
                      
                        befoeGold = gold;
                        gold += (int)(1700 * goldPercent);

                        Console.WriteLine($"Gold {befoeGold} -> {gold}");
                      
                        clearTime++;
                        LevelUp();
                        Console.WriteLine();
                        Console.WriteLine("0. 나가기 ");
                        Console.WriteLine("1. 계속 던전돌기");
                        Console.WriteLine();
                    }
                    else
                    {
                        //권장 방어력 보다 낮다면
                        Console.Clear();
                        int dPercent = random.Next(1, 11);

                        if( dPercent <= 4)
                        {
                            Console.Clear();
                            Console.WriteLine("던전 실패했습니다.");
                            hp /= 2;
                            Console.WriteLine("0. 나가기 ");

                        }
                        else
                        {
                           
                            Console.WriteLine("던전 클리어");
                            Console.WriteLine("축하합니다!!");
                            Console.WriteLine("일반 던전을 클리어 하였습니다.");
                            Console.WriteLine("[탐험결과]");
                            Console.WriteLine();
                            beforeHp = hp;
                            befoeGold = gold;
                            appDef = minusHp - (defEquip - 11);
                            hp -= appDef;
                            gold += 1700;
                            if (hp <= 0)
                            {
                                hp = 0; // 체력 음수 보정
                            }

                            Console.WriteLine($"체력 {beforeHp} -> {hp}");
                            Console.WriteLine($"Gold {befoeGold} -> {gold}");

                            supGold = random.Next(((int)atkEquip), ((int)atkEquip) * 2 + 1);
                            double goldPercent = (double)supGold / 100;
                            Console.WriteLine("!!!!!!" + 1700 * goldPercent + "추가 보상입니다.!!!");
                            befoeGold = gold;

                            gold += (int)(1700 * goldPercent);
                            Console.WriteLine($"Gold {befoeGold} -> {gold}");
                         
                            clearTime++;
                            LevelUp();

                            Console.WriteLine();
                            Console.WriteLine("0. 나가기 ");
                            Console.WriteLine("1. 계속 던전돌기");
                            Console.WriteLine();
                        }
                    }
                }
                else if (input == "3")
                {
                    if (def >= 17) // 권장 방어력
                    {
                        Console.Clear();
                        Console.WriteLine("던전 클리어");
                        Console.WriteLine("축하합니다!!");
                        Console.WriteLine("일반 던전을 클리어 하였습니다.");
                        Console.WriteLine("[탐험결과]");
                        Console.WriteLine();
                        beforeHp = hp;
                        befoeGold = gold;
                        appDef = minusHp - (defEquip - 17);
                        hp -= appDef;
                        gold += 2500;
                     
                        if (hp <= 0)
                        {
                            hp = 0; // 체력 음수 보정
                        }
                        Console.WriteLine($"체력 {beforeHp} -> {hp}");
                        Console.WriteLine($"Gold {befoeGold} -> {gold}");

                        supGold = random.Next(((int)atkEquip), ((int)atkEquip) * 2 + 1);
                        double goldPercent = (double)supGold / 100;
                        Console.WriteLine("!!!!!!" + 2500 * goldPercent + "추가 보상입니다.!!!");
                        befoeGold = gold;
                        gold += (int)(2500 * goldPercent);
                        
                        Console.WriteLine($"Gold {befoeGold} -> {gold}");
                        Console.WriteLine();
                    
                        clearTime++;
                        LevelUp();
                        Console.WriteLine();
                        Console.WriteLine("0. 나가기 ");
                        Console.WriteLine("1. 계속 던전돌기");
                        Console.WriteLine();
                    }
                    else
                    {
                        //권장 방어력 보다 낮다면
                        Console.Clear();
                        int dPercent = random.Next(1, 11);

                        if (dPercent <= 4)
                        {
                            Console.Clear();
                            Console.WriteLine();
                           
                            Console.WriteLine("던전 실패했습니다.");
                            hp /= 2;
                            Console.WriteLine("0. 나가기 ");
                        }
                        else
                        {
                            Console.WriteLine("던전 클리어");
                            Console.WriteLine("축하합니다!!");
                            Console.WriteLine("일반 던전을 클리어 하였습니다.");
                            Console.WriteLine("[탐험결과]");
                            Console.WriteLine();
                            beforeHp = hp;
                            befoeGold = gold;
                            appDef = minusHp - (defEquip - 17);
                            hp -= appDef;

                            gold += 2500;
                   
                            if (hp <= 0)
                            {
                                hp = 0; // 체력 음수 보정
                            }
                            Console.WriteLine($"체력 {beforeHp} -> {hp}");
                            Console.WriteLine($"Gold {befoeGold} -> {gold}");

                            supGold = random.Next(((int)atkEquip), ((int)atkEquip) * 2 + 1);
                            double goldPercent = (double)supGold / 100;
                            Console.WriteLine("!!!!!!" + 2500 * goldPercent + "추가 보상입니다.!!!");
                            befoeGold = gold;
                            gold += (int)(2500 * goldPercent);
                          
                            Console.WriteLine($"Gold {befoeGold} -> {gold}");
                         
                            clearTime++;
                            LevelUp();

                            Console.WriteLine();
                            Console.WriteLine("0. 나가기 ");
                            Console.WriteLine("1. 계속 던전돌기");
                            Console.WriteLine();
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
              
                Console.Write(">> ");

                input = Console.ReadLine();

                if (input == "0")
                {
                    Console.Clear();
                    break;
                }
                else if (input == "1")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }
    }
}
