using UnityEngine;

namespace jeff
{
    public class Exerclsr_7_Property : MonoBehaviour
    {
        [SerializeField]
        private int _hp = 100;

        public int hp
        {
            get 
            { 
                if(_hp <=0) Debug.Log("<color=#000>玩家死亡</color>");
                return _hp;
            }
        }


        public void Update()
        {
            Debug.Log(hp);
            
            
        }
    }

    
 }
