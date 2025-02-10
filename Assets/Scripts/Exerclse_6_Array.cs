using UnityEngine;

namespace jeff
{
    public class Exerclse_6_Array : MonoBehaviour
    {
        public string[,,] decks = { 
            { {"皮卡丘" ,"列空座","快龍" },{"超夢" ,"夢幻","火焰鳥" }},
            
            { {"死神幽靈" ,"姑姑寶貝","上級魔法書" },{"黑肥肥" ,"黑翼龍" ,"不尋常的水獺"} },

            { {"易大師" ,"蓋倫" ,"維佳"},{"安妮" ,"雷茲" ,"愛希"} }

        };


        private void Start()
        {
            Debug.Log($"<color=#f3d> 皮卡丘出來吧:{decks[0, 0, 0]}</color>");
            Debug.Log($"<color=#f3d> 姑姑寶貝出來吧:{decks[1, 0, 1]}</color>");
            Debug.Log($"<color=#f3d> 蓋倫出來吧:{decks[2, 0, 1]}</color>");
            Debug.Log($"<color=#f3d> ????出來吧:{decks[1, 0, 2]}</color>");
        }
    }
}

