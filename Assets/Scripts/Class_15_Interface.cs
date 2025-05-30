﻿using jeff.Tools;
using UnityEngine;

namespace jeff.Class_15


{
    /// <summary>
    /// 介面 interface
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        public object invertoryFirst;
        public object invertorySecond;

        private void Awake()
        {
            int random = Random.Range(0, 3);       // 隨機  0 ~ 3 (不會出現 3)
            LogSystem.LogWithColor($"隨機:{random}", "#f33");

            if (random == 0) invertoryFirst = new Prop();
            else if (random == 1) invertoryFirst = new Equipment();
            else if (random == 2) invertoryFirst = new Map();

            int randomSecond = Random.Range(0, 3);       // 隨機  0 ~ 3 (不會出現 3)


            if (randomSecond == 0) invertoryFirst = new Weapon();
            else if (randomSecond == 1) invertorySecond = new Potion1();
            else if (randomSecond == 2) invertorySecond = new Chest();
        }

        private void Update()
        {
            //按下數字鍵 1 可以使用第一個的物品
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                //如果第一個是道具， 就使用道具
                if (invertoryFirst is Prop) ((Prop)invertoryFirst).Use();

                ////如果第一個是裝備， 就使用裝備
                else if (invertoryFirst is Equipment) ((Equipment)invertoryFirst).Use();

                //如果第一個是地圖， 就使用地圖
                else if (invertoryFirst is Map) ((Map)invertoryFirst).Use();

                //當遊戲的物品種類變多的時候，這邊的判斷是會很恐怖的....
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                // 如果第二格道具的物品有實作介面 就 使用
                if (invertorySecond is IUse) ((IUse)invertorySecond).Use();

                if (invertorySecond is IDestroy) ((IDestroy)invertorySecond).Destroy();
                // 如果擴充物品，判斷式不需要添加，只需要讓物件都實作介面即可
            }
        }


        public class Prop
        {
            public void Use()
            {
                LogSystem.LogWithColor("使用道具，恢復體力", "#f96");
            }
        }

        public class Equipment
        {
            public void Use()
            {
                LogSystem.LogWithColor("使用裝備，裝到對應位置", "#9f6");
            }

        }

        public class Map
        {
            public void Use()
            {
                LogSystem.LogWithColor("使用地圖，開啟地域功能", "#96f");
            }
        }
    }
}


