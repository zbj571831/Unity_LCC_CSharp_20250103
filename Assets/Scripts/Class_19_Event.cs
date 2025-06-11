using jeff.Tools;
using System;
using UnityEngine;

namespace jeff
{
    /// <summary>
    ///  事件: 當一件事發生後會通知所有系統
    ///  需要對應處理的系統可以訂閱並做出處理
    ///  遊戲規範 : 死亡事件
    ///  玩家系統 > 死亡事件 ，當玩家死亡會執行死亡事件通知其他系統
    ///  控制系統 > 訂閱死亡事件 > 停止控制系統
    ///  音樂系統 > 訂閱死亡事件 > 變更 BGM
    /// </summary>
    public class Class_19_Event : MonoBehaviour
    {
        // 事件使用步驟:
        // 1. 宣告事件 (委派)
        // 2. 呼叫事件 (什麼時間要觸發)
        // 3. 其他系統訂閱事件

        private float hp = 10;
        // 步驟1. 宣告事件
        public delegate void delegateMethod();
        // 事件關鍵字 : event
        public event delegateMethod onDead;

        public event Action<string, float> onDeadAction;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) Damage(5);
        }

        private void Damage(float damage)
        {
            hp -= damage;

            if (hp <= 0)
            {
                LogSystem.LogWithColor("玩家死亡", "#f99");
                //步驟 2. 呼叫事件
                onDead?.Invoke();                   // ? 問號 l判斷 onDead 如果有訂閱者才會呼叫

                onDeadAction?.Invoke("玩家", hp);   // 事件有參數時呼叫要帶入
            }
        }
    }

}
