﻿
//單行註解
/*多行註解
 * 
 */
/// <summary>
/// 引用Uniey函式庫
/// </summary>
using UnityEngine;
//修飾詞 類別關鍵字 (腳本)  類別名稱 (腳本)
// 在腳本後添加 : MonoBehaviour 可以讓此腳本掛在Uniey的物件上
public class Class_1_Variable : MonoBehaviour
{
    //程式內的括號都是成對的() {} [] < > '' " "
    //class{}此類別的程式內容

    //變數:會改變的數值，用來存放遊戲或系統的訊息
    //例如:lol的玩家金幣 500，隨這遊戲改變增加，例如小兵+??
    //定義一個記憶體內的空間用存放資訊

    /*變數語法:
     *修飾詞 變數資料類型 變數名稱:
     **修飾詞 變數資料類型 變數名稱 指定 預設值; (指定 預設值 可省略)
     *資料類型:告訴記憶體可以入哪些資料，例如:int可以放整數
     *變數名稱:習慣用小寫開頭命名，規則與腳本名稱相同
     *公開:允許其他類別存取，顯示在屬性面板上public
     *私人:不允許其他類別存取，隱藏在屬性面板上private (預設)
     */
    public int coin = 500;
    private int Level = 3;

    
}

//類別外,不要將程式寫在這
