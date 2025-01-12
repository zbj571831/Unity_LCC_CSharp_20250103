﻿using UnityEditor.Search;
using UnityEngine;
//三斜線是摘要 (XML語言) 用來簡短說明，可加在類別與變數上方
/// <summary>
/// 認識資料類別
/// </summary>
public class Class_2_DataType : MonoBehaviour 
{
    //變數語法:
    //修飾詞 變數資料類型 變數名稱 指定 預設值;
    //四大常用資料類別
    //整  數:儲存沒有小數點的數值int
    //浮點數:儲存有小數點的數值 float 後面要加f例如:0.1f
    //字  串:儲存文字，需用雙引號 string 前後需加" "例如:( "hi")
    //布林值:儲存正與反bool 只有2個值 true 與 false
    public int count =  7;
    public float moveSpeed = 3.5f;      //浮點數必須加F後綴\
    public float turnSpeed = 30.7F;     //大小f都可
    public string characcter = "蓋倫";
    public bool isDead = false;         //是否死亡 : 是
    public bool gameOver = true;        //是否結束 : 否

    //整數資料類型
    public byte lv = 16;                //byte 型別，範圍 0~255，大小 8 byte
    public uint coin = 9999;            //uint型別，範圍  0~ 4***， 大小 32 byte
    public long items = 3000;           //uint型別，範圍  0 ~ 92***， 大小 64 byte

    //字串與字元
    public string playerName = "多個字元";   //字串:儲存多個文字，需用雙引號
    public char a = 'a';                    //字元:儲存一個文元，需用單引號

    //溢位
    //public sbyte number = 128;             //溢位導致錯誤，會出現紅色蚯蚓
}
