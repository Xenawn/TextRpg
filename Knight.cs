using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace TextRPG
{
    public partial class Knight
    {
        protected string name = "나이트셔";
        protected string occupation = " 전사 ";
        protected static int level = 1;
        protected static double atk = 10;
        protected static int def = 5;
        protected int hp = 20;
        protected int gold = 1500;
        protected string[] equipment = { "무쇠갑옷", "스파르타의 창", "낡은 검" };
        protected string[] information = { "방어력 +5", "공격력 +7", "공격력 +2" };
        protected string[] description = { "무쇠로 만드어져 튼튼한 갑옷입니다.", "스파르타의 전사들이 사용했다는 전설의 창입니다.", "쉽게 볼 수 있는 낡은 검입니다." };
        protected int[] equipGold = { 1000, 500, 300 };
        protected bool[] status = { false, false, false };
        protected bool atkOverlap = false; //중복
        protected bool defOverlap = false; // 아이템 개선
        protected static int totalAtk = 0;
        protected static int totalDef = 0;
        protected int totalHp = 0;
        protected string[] marketProduct = { "수련자 갑옷", "무쇠갑옷", "스파르타의 갑옷", "낡은 검", "청동 도끼", "스파르타의 창", "피자 폭탄", "군주의 갑옷" }; //상점 상품
        protected string[] marketInfo = { "방어력 +5", "방어력 +9", "방어력 +15", "공격력 +2", "공격력 +5", "공격력 +7", "공격력 +5", "방어력 +20" }; // 상점 스탯 정보
        protected string[] marketDescription = { "수련에 도움 주는 갑옷입니다.", "무쇠로 만들어져 튼튼한 갑옷입니다.", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.",
                "쉽게 볼 수 있는 낡은 검 입니다." ,"어디선가 사용됐던거 같은 도끼입니다.", "스파르타의 전사들이 사용했다는 전설의 창입니다.", "명군이 썼던 피자 폭탄입니다.", "전설의 군주가 입었던 갑옷입니다."};
        protected string[] marketGold = { "1000", "구매완료", "3500", "구매완료", "1500", "구매완료", "500", "1000" };
        private int clearTime = 0; // 던전 횟수 
        private double atkEquip = atk + totalAtk; // 장비와 내 공격력 합산
        private int defEquip = def + totalDef; // 장비와 내 방어력 합산
        private int levelTime = level; // 레벨 횟수만큼 던전 횟수를 돌아야 레벨업
    }

    }

