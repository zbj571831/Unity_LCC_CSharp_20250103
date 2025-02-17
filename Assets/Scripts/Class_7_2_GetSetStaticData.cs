using UnityEngine;
namespace jeff
{
    /// <summary>
    /// 練習取得與設定靜態資料
    /// </summary>
    public class Class_7_2_GetSetStaticData : MonoBehaviour
    {
        //取得非靜態資料類別的變數
        //1. 先定義要獲得資料類別的變數
        //2. 透過變數取得非靜態資料(成員)
        public Class_7_2_Static class_7_2;

        private void Awake()
        {
            Debug.Log($"<color=#f3d>非靜態成員 :{class_7_2.inventorvWater}</color>");
            //取得靜態資料(成員)
            //類別名稱.靜態成員
            Debug.Log($"<color=#f3d>靜態成員 :{Class_7_2_Static.inventoryProp}</color>");
            //呼叫非靜態變數方法
            class_7_2.Punch();

            //類別名稱.靜態變數
            //取得靜態變數
            Debug.Log($"<color=#f3d>靜態成員 :{Class_7_2_Static.inventoryProp}</color>");
            //取得靜態屬性
            Debug.Log($"<color=#f3d>靜態成員 :{Class_7_2_Static.skillSecond}</color>");
            //呼叫靜態方法
            Class_7_2_Static.Kick();
        }
    }
}

