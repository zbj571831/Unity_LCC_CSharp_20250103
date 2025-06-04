using jeff.Tools;
using UnityEngine;

namespace jeff
{
    /// <summary>
    /// 委派
    /// </summary>
    public class Class_19_Delegate : MonoBehaviour
    {
        #region 複習可當參數的變數與元組
        private void Awake()
        {
            Cure(10);
            Card(("史萊姆", 7));
        }

        // 將 float 當作參數
        private void Cure(float cure)
        {
            LogSystem.LogWithColor($"治癒的值 : {cure}", "#3f3");
        }

        // 將 元祖 當作參數
        private void Card((string name, int index) card)
        {
            LogSystem.LogWithColor($"卡片 : {card.name} | {card.index}", "#3f3");
        }

        #endregion

        // 1. 宣告委派
        // 宣告一個無傳回與參數的委派
        private delegate void DelegateMethod();
        private delegate float Calculate(float numberA, float numberB);
        private delegate void DelegateCombine<T>(T a);

        // 2. 目標方法 : 簽章必須與委派相同
        #region 無傳回與無參數的方法
        private void Test()
        {
            LogSystem.LogWithColor("測試", "#f3f");
        }

        private void Talk()
        {
            LogSystem.LogWithColor("哈囉，你好 :D", "#f39");
        }

        private void MagicCard()
        {
            LogSystem.LogWithColor("召喚小兵", "#3f3");
        } 
        #endregion
        private float Add(float numberA , float numberB)
        {
            float result = numberA + numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }

        private float Sub(float numberA, float numberB)
        {
            float result = numberA - numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }

        private float Mul(float numberA, float numberB)
        {
            float result = numberA * numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }

        private void Combine<T>(T a)
        {
            LogSystem.LogWithColor(a, "#ff3");
        }

        // 3. 宣告變數存放方法 (預設為空值)
        private DelegateMethod delegateMethod;
        private Calculate calculate;
        private DelegateCombine<float> delegateCombineFloat;
        private DelegateCombine<int> delegateCombineInt;

        // 4. 呼叫委派
        private void Start()
        {
            #region 基本委派
            delegateMethod = Test;    // 將方法 Test 存放到變數 delegateMethod 內
            delegateMethod += Talk;
            delegateMethod += MagicCard;
            delegateMethod -= Test;

            delegateMethod();         // 呼叫委派 
            #endregion

            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            calculate(10, 3);
            calculate(100, 70);

            CalcuteNumber(Sub, 3, 7);
            delegateCombineFloat = Combine<float>;
            delegateCombineFloat  (3.5f);
            delegateCombineInt = Combine<int>;
            delegateCombineInt  (999);

        }
        // 委派 : 將方法當作參數
        private void CalcuteNumber(Calculate calculate, float a, float b)
        {
            var result = calculate(a, b);
            //LogSystem.LogWithColor(result, "#ff3");
        }
    }
}

