using jeff.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

namespace jeff
{
    /// <summary>
    /// 資料結構 
    /// </summary>
    public class Class_16_DataStruct : MonoBehaviour
    {
        #region 清單
        // 陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };

        // 清單 : 泛型集合
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playerDefens;

        #endregion
        private void Awake()
        {
            #region 清單
            // 清單存取 : 與陣列相同
            LogSystem.LogWithColor($"第三筆速度 : {speeds[2]}", "#3f3");
            speeds[0] = 10;
            LogSystem.LogWithColor($"第一筆速度 : {speeds[0]}", "#3f3");
            // 陣列初始化後就無法增減長度
            // 增加一筆道具
            props.Add("寶劍");
            // 刪除第一筆道具
            props.RemoveAt(1);
            //添加頭盔到編號 1 上
            props.Insert(1, "頭盔");

            foreach (var prop in props)
            {
                LogSystem.LogWithColor($"道具 : {prop}", "#f93");
            }

            //使用建構子帶入陣列
            playerDefens = new List<float>(defens);
            // 排序 : 由小到大
            playerDefens.Sort();
            // 反排序 : 由大到小
            playerDefens.Reverse();

            foreach (var itme in playerDefens)
            {
                LogSystem.LogWithColor($"資料 : {itme}", "#f93");
            }

            // Count 指清單內的資料 ， 根據 Add 或 Remove 改變
            LogSystem.LogWithColor($"數量 : {props.Count}", "#77f");
            // Capcity 指清單的容量，系統自動分配，預設為 4 並且以倍數成長 ( C# 各版本不同 )
            LogSystem.LogWithColor($"數量 : {props.Capacity}", "#77f");

            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                // Count 指清單內的資料 ， 根據 Add 或 Remove 改變
                LogSystem.LogWithColor($"數量 : {numbers.Count}", "#3a3");
                // Capcity 指清單的容量，系統自動分配，預設為 4 並且以倍數成長 ( C# 各版本不同 )
                LogSystem.LogWithColor($"數量 : {numbers.Capacity}", "#f39");
            }
            #endregion

            #region 堆疊
            // 堆疊 : 先進後出，類似椅子堆再一起
            Stack<string> enemys = new Stack<string>();
            // 放資料進入堆疊
            enemys.Push("史萊姆");
            enemys.Push("哥布林");
            LogStack<string>(enemys);
            // 拿資料並且不移除
            enemys.Peek();
            LogStack<string>(enemys);
            // 拿資料並且移除
            enemys.Pop();
            LogStack<string>(enemys);
            // 判斷是否包含某筆資料
            LogSystem.LogWithColor($"{enemys.Contains("哥布林")}", "#3F6");
            enemys.Clear();
            LogStack<string>(enemys);
            #endregion

            #region 拧列
            //Queue 拧列 : 先進先出，先放進來的資料會先被拿出去。(與排隊類似)
            Queue<string> player = new Queue<string>();
            player.Enqueue("盜賊");
            player.Enqueue("法師");
            player.Enqueue("戰士");
            LogQueue<string>(player);
            // 拿東西不刪除，與堆疊的 Peek 相同
            LogSystem.LogWithColor(player.Peek(), "#f33");
            LogQueue<string>(player);
            // 拿東西刪除，與堆疊的 Pop 相同
            LogSystem.LogWithColor(player.Dequeue(), "#f33");
            LogQueue<string>(player);
            #endregion

            #region 連結串列
            // LinkefList 連結串列
            string[] skillsArray = new string[] { "火球", "冰錐" };
            LinkedList<string> skills = new LinkedList<string>(skillsArray);
            LogLinkedList<string>(skills);
            skills.AddLast("落雷");
            LogLinkedList<string>(skills);
            skills.AddFirst("岩石");
            LogLinkedList<string>(skills);
            // 在火球後面加毒霧
            LinkedListNode<string> skillFire = skillFire = skills.Find("火球");
            skills.AddAfter(skillFire, "毒霧");
            // 在火球前面加瞬移
            skills.AddBefore(skillFire, "瞬移");
            LogLinkedList<string>(skills);
            #endregion

            #region 排序集合
            // 自動排序並且不重複的集合 (由小到大排序)
            SortedSet<int> counts = new SortedSet<int> { 9, 2, 80, 1 };
            LogSortedSet<int>(counts);
            counts.Add(77);
            counts.Add(123);
            counts.Add(9);
            LogSortedSet<int>(counts);
            LogSystem.LogWithColor($"最大 : {counts.Max}", "#f33");
            LogSystem.LogWithColor($"最小 : {counts.Min}", "#f33");

            SortedSet<int> lv = new SortedSet<int> { 7, 3, 75, 123, 5, 80 };
            // 交集與差集
            counts.IntersectWith(lv);
            LogSortedSet<int>(counts);          // 80, 123
            counts.ExceptWith(lv);              // 刪除 conuts 內的 { 7, 3 , 75, 123, 5, 8   }
            LogSortedSet<int>(counts);
            #endregion

            #region 字典
            Dictionary<int, string> deck = new Dictionary<int, string>()
            {
                { 10, "青眼白龍" }, {3 , "落穴"} , {1 , "黑魔導"}
            };
            LogDictionary<int, string>(deck);
            deck.Add(7, "死者甦醒");
            LogSystem.LogWithColor($"是否有編號 3 資料 : {deck.ContainsKey(0)}", "#3f3");
            LogSystem.LogWithColor($"是否有羽毛掃資料 : {deck.ContainsValue("黑魔導")}", "#3f3");

            #endregion

            //保持排序並且不混重複的鍵
            SortedList<string, int> board = new SortedList<string, int>();
            board.Add("KID", 90);
            board.Add("Kevin", 85);
            board.Add("Cherry", 85);
            //board.Add("KID", 77);               // 重複的鍵導致錯誤
            LogSortedList<string, int>(board);

            //保持排序並且不混重複的字典
            SortedDictionary<string, int> scores = new SortedDictionary<string, int>();
            scores.Add("KID", 80);
            scores.Add("Kevin", 85);
            scores.Add("Cherry", 85);
            //board.Add("KID", 77);               // 重複的鍵導致錯誤
            LogSortedDictionary<string, int>(scores);

            // SortedList 與 SortedDictionary 的差異
            // 1. SortedList 是使用陣列方式儲存，比較記憶體空間
            // 2. SortedDictionary 是使用樹狀結構方式儲存，比較占記憶體空間
            // 3. SortedList 可以使用索引值存取 [0]
            LogSystem.LogWithColor($"排名榜第一筆 : {board.Keys[0]}", "#f93");
            //LogSystem.LogWithColor($"排名榜第一筆 : {scores.Keys[0]}", "#f93");
            // 4.SortedList 大量資料增減時比較占記憶體空間
            // 如果資料不需要頻繁的增減建議使用 SortedList 反之建議使用 SortedDictionary
        }





        private void LogStack<T>(Stack<T> stack)
        {
            LogSystem.LogWithColor($"---------", "#fFF");
            foreach (var item in stack)
            {
                LogSystem.LogWithColor($"堆疊資料 : {item}", "#f77");
            }
        }

        private void LogQueue<T>(Queue<T> queue)
        {
            LogSystem.LogWithColor($"---------", "#fff");
            foreach (var item in queue)
            {
                LogSystem.LogWithColor($"拧列資料 : {item}", "#7f7");
            }
        }

        private void LogLinkedList<T>(LinkedList<T>linkedList)
        {
            
            foreach (var item in linkedList)
            {
                LogSystem.LogWithColor(item, "#fa3");
            }
            LogSystem.LogWithColor($"---------", "#fff");
        }

        private void LogSortedSet<T>(SortedSet<T> set)
        {
            foreach(var item in set) 
            {  
                LogSystem.LogWithColor(item, "#3f3"); 
            }
            LogSystem.LogWithColor("---------------", "#fff");
        }

        private void LogDictionary<T, U>(Dictionary<T, U> dict)
        {
            foreach(var item in dict)
            {
                LogSystem.LogWithColor($"卡牌的編號 : {item.Key}", "#3f3");
                LogSystem.LogWithColor($"卡牌的名稱 : {item.Value}", "#3f3");
            }
            LogSystem.LogWithColor($"-----------", "#faa");
        }

        private void LogSortedList<T, U>(SortedList<T, U> list)
        {
            foreach (var item in list) 
            {
                LogSystem.LogWithColor($"{item.Key} 的分數 {item.Value}", "#77f");
            }
            LogSystem.LogWithColor($"------------", "#fff");
        }

        private void LogSortedDictionary<T, U>(SortedDictionary<T, U> list)
        {
            foreach (var item in list)
            {
                LogSystem.LogWithColor($"{item.Key} 的分數 {item.Value}", "#77f");
            }
            LogSystem.LogWithColor($"------------", "#fff");
        }
    }
}

