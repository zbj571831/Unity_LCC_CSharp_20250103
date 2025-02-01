using UnityEngine;

//命名空間
//將類別分類，類似倉庫的概念。不同倉庫可以有相同名稱類別。
//語法 : namespace 命名空間名稱{ 內容 }
namespace jeff
{
    /// <summary>
    /// 選取陳訴 Selection Statement
    /// 1. if判斷式
    /// 2. Switch判斷式
    /// </summary>
    public class Class_5_1_Selectlion : MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp;
        [SerializeField, Header("武器")]
        private string weapon;

        private void Awake()
        {
            //if判斷式
            //if (布林值) {陳訴式}
            if (true)
            {
                Debug.Log("當布林值為true，會執行這裡");
            }
            // 快速完成 : 輸入 IF 選取 IF 陳述式按 Enter 或  Tab
            if (false)
            {
                Debug.Log("當布林值為false，會執行這裡");
            }
        }
        //更新事件 : 一秒執行約60次 (60FPS) Frame Per Second
        private void Update()
        {
            //常用快捷
            // 1. 格式化 (排版) Ctrl + k d
            // 2. 程式碼 ctrl + K S 選 region
            #region 判斷式 if
            Debug.Log("<color=#79f>更新事件</color>");

            //如果 isOpen布林值等於 True ，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            //否則 isOpen 布林值等於 false，就顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }

            //比較運算子 ` 邏輯運算子 結果為布林值
            //if 會在最上方， else 在最下方，中間可以有多個 else if
            //如果 分數 >= 60 就 c# 課程過了
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你的 c# 課程過了</color>");
            }
            //否則 如果 分數 >= 40 可以補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>可以補考</color>");
            }
            //否則 如果 分數 >= 20 可以補考但是要做一個 c# 小專題
            else if (score >= 20)
            {
                Debug.Log("<color=#f9a>可以補考但是要做一個 c# 小專題</color>");
            }
            //否則 當掉 
            else
            {
                Debug.Log("<color=#f33>你的 c# 課程被當了</color>");
            }
            #endregion

            #region 練習題
            if (hp >= 80)
            {
                Debug.Log("<color=#3f3>血量安全</color>");
            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#3f3>健康有狀況</color>");
            }
            else if (hp >= 40)
            {
                Debug.Log("<color=#3f3>警告，快喝水</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#3f3>你死掉了</color>");
            }
            if (hp >= 80)
            {
                Debug.Log("<color=#3f3>血量安全</color>");
            }
            else if (hp >= 60 && hp < 80)
            {
                Debug.Log("<color=#3f3>健康有狀況</color>");
            }
            else if (hp >= 40 && hp < 60)
            {
                Debug.Log("<color=#3f3>警告，快喝水</color>");
            }
            else if (hp >= 10 && hp < 40)
            {
                Debug.Log("<color=#3f3>你快死掉了</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#3f3>你死掉了</color>");
            } 
            #endregion

            #region switch判斷式
            //switch 判斷式
            //switch (要判斷的值) {陳述式}
            //快速完成 : switch Tab * 2
            switch (weapon)
            {
                //case 值:
                //當判斷的值等於時會執行這裡
                //break; 跳出判斷式
                //如果武器等於小刀 攻擊力20
                //蝴蝶刀會與小刀一樣
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color-#ff3>攻擊力 : 20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color-#ff3>攻擊力 : 10</color>");
                    break;
                case "屠龍刀":
                    Debug.Log("<color-#ff3>攻擊力 : 999</color>");
                    break;
                default:
                    Debug.Log("<color-#ff3>這是不能使用的武器</color>");
                    break;



            }
            #endregion
        }
    }

}


