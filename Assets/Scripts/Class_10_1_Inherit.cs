using jeff.Tools;
using UnityEngine;

namespace jeff
{
    /// <summary>
    /// 繼承 ingerit
    /// </summary>
    public class Class_10_1_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblint1 = new Goblin(10, 1);
            LogSystem.LogWithColor($"哥布林1號的攻擊 : {goblint1.attack}", "#f3d");
            var slime1 = new Slime(3, 2);
            LogSystem.LogWithColor($"史萊姆1號的攻擊 : {slime1.attack}", "#f3d");
            goblint1.Move();
            slime1.Move();
            slime1.Initlize();

            var slime1IsGolbin = slime1 is Goblin;
            LogSystem.LogWithColor($"史萊姆1是否為哥布林:{slime1IsGolbin}", "#f33");//slime1IsGolbin

            var spider1 = new Spider(15, 3);
            var spider1IsSlime = spider1 is Slime;  
            var spidef1IsGolbin = spider1 is Goblin;
            LogSystem.LogWithColor($"蜘蛛1號是否為史萊姆:{spider1IsSlime}", "#f33");
            LogSystem.LogWithColor($"蜘蛛1號是否為哥布林:{spidef1IsGolbin}", "#f33");
            
        }
    }

    public class Goblin
    {
        public int attack;         //公開 : 所有類別可以存取
        public int defense;
        private float moveSoeed;   //私人 : 此類別可以存取
        protected float hp;        //保護 : 子類別可以存取
        protected int lv = 5;

        public Goblin (int _attack, int _defense)
        {
            attack = _attack;
            defense = _defense;
        }

        // virtual 虛假 : 允許子類別覆寫
        public virtual void Move()
        {
            LogSystem.LogWithColor("兩條腿移動",  "#9f9");
        }
    }

    //繼承讓類別可以繼承另一個類別，擁有該類別的成員
    //子類別 : 父類別
    //C# 僅提供單一繼承 (只能繼承一個類別)
    public class Slime : Goblin
    {
        protected int lv = 10;       //綠色蚯蚓 :提示父類別有相同的成員名稱

        
        public Slime (int _attack, int _defense) : base(_attack,_defense)
        {

        }
         
        public void Initlize()
        {
            attack = 7;          // 公開 : 可以存取
            //moveSpeed = 3.5f;  // 私人 : 無法存取
            hp = 10;             // 保護 : 可以存取
            LogSystem.LogWithColor($"等級 :{lv}", "#78f");
            LogSystem.LogWithColor($"等級 :{base.lv} (父類別)", "#78f");
        }

        //override 覆寫 : 覆寫父類別有 virtual 關鍵字的成員
        //override 選擇要覆寫的成員 > 按下 enter 自動完成
        public override void Move()
        {
            //base.Move();       //覆寫父類別有的內容
            LogSystem.LogWithColor("爬行", "#3f3");
        }
    }

    public class Spider : Slime
    {
        public Spider(int _attack, int _defense) : base(_attack, _defense)
        {

        }
    }
}

