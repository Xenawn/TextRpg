using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    
    public partial class Knight
    {
        public void LevelUp()
        {
            if (levelTime == clearTime)
            { // 클리어횟수와 현재 레벨이 같으면 
                level++; // 레벨업
                defEquip += 1;
                atkEquip += 0.5;
                Console.WriteLine("축하합니다!");
                Console.WriteLine($"레벨업하여 현재 [레벨]은 {level}이고 [최종 공격력]은 {atkEquip}!! [최종 방어력] {defEquip} 입니다!!");
               levelTime=level;
                clearTime = 0;
            }
            else
            {
                return ;
            }
        }
    }
}
