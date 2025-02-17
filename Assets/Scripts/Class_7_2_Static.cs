using UnityEngine;
using UnityEngine.SceneManagement;

namespace jeff 
{ 
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour 
    {
        //成員 :
        // 變數 ` 屬性 ` 方法

        //非靜態變數
        public int inventorvWater = 10;
        //靜態變數 : 修飾詞後面添加關鍵字 static
        //靜態變數不顯示在屬性面板上
        public static int inventoryProp = 20;

        //非靜態屬性
        public string sjillMain => "火球術";
        //靜態屬性
        public static string skillSecond => "治癒術";

        private void Awake()
        {
            //inventorvWater = 7;
            //inventoryProp = 15;
            Debug.Log($"<color=#f31>藥水 :{inventorvWater}</color>");
            Debug.Log($"<color=#f31>道具 :{inventoryProp}</color>");
        }
        
        public void Punch()
        {
            Debug.Log("<color=#3f3>使用拳擊</color>");
        }

        public static void Kick()
        {
            Debug.Log("<color=#3f3>使用踢擊</color>");
        }

        private void Start()
        {
            //在 Unity 內的差異
            //場景切換時
            //非靜態成員會被釋放 (還原為預設值)
            inventorvWater++;  //藥水+1
            Debug.Log($"<color=#78f>藥水 :{inventorvWater}</color>");
            inventoryProp++;  //道具+1
            Debug.Log($"<color=#78f>道具 :{inventoryProp}</color>");
            

        }
        private void Update() 
        {
            //在Game 畫面按下數字1會重新載入場景 (切換為英文輸入法)
            //如果按下數字1 (左邊鍵盤)
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程_7_屬性與靜態");
            }
        }
    }
}