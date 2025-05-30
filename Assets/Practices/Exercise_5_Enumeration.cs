using UnityEngine;

namespace jeff 
{
    public class Exercise_5_Enumeration : MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp;

        private void Update()
        {
            switch (hp) 
            {
                case >= 80:
                    Debug.Log("<color=#3f3>血量安全</color>");
                    break;
                case >= 60:
                    Debug.Log("<color=#3f3>健康有狀況</color>");
                    break;
                case >= 40:
                    Debug.Log("<color=#3f3>警告，快喝水</color>");
                    break;
                case >= 10:
                    Debug.Log("<color=#3f3>你快死掉了</color>");
                    break;
                case 0:
                    Debug.Log("<color=#3f3>你死掉了</color>");
                    break;
                
                
                
                
                    
                
                    
            }
        }
    }
}