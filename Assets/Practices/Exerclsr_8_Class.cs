using UnityEngine;

namespace jeff
{
    public class Exerclsr_8_Class : MonoBehaviour
    {
        private void Awake( ) 
        {
            Practice_8_Boss bossDeagon = new Practice_8_Boss("朱雀", "萬千火羽", 2999);
            Practice_8_Boss bossBird = new Practice_8_Boss("青龍", "青龍撕天手", 3999);

            Debug.Log($"<color=#f93>{bossDeagon.name}, 招式 : {bossDeagon.skill}, 血量 : {bossDeagon.hp}</color>");
            Debug.Log($"<color=#f93>{bossBird.name}, 招式 : {bossBird.skill}, 血量 : {bossBird.hp}</color>");
        }



    }

    public class Practice_8_Boss
    {
        public string name;
        public string skill;
        public float hp;

        public Practice_8_Boss(string _name, string _skill, float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }
    }
}

