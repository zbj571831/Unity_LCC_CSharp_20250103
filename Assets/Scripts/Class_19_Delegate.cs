using jeff.Tools;
using System;
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

        // Func
        // 可以存放有傳回並且有 0 個參數以上的方法
        // 宣告一個委派，有一個參數 float，並取傳回值 float
        // <參數，回傳值>
        private Func<float, float> funcCalc;

        // Action
        // 可以存放無傳回並且有 0 個參數以上的方法
        // 宣告一個委派，無參數也沒有傳回值
        private Action actionMetohd;

        // Predicate
        // 可以存放有布林值傳回並且有 0 個參數以上的方法
        // 宣告一個委派，有一個參數 float，並且傳回值為 bool
        private Predicate<float> predicate;
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

            #region 多播委派與泛型委派
            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            calculate(10, 3);
            calculate(100, 70);

            CalcuteNumber(Sub, 3, 7);
            delegateCombineFloat = Combine<float>;
            delegateCombineFloat(3.5f);
            delegateCombineInt = Combine<int>;
            delegateCombineInt(999);
            #endregion

            #region 匿名方法
            // 匿名方法
            // delegate (參數) { 陳述式 }
            DelegateMethod anonymousMethod = delegate () { };
            Calculate anonymousCalc = delegate (float a, float b) { return a * b; };
            // 簡寫方法
            DelegateMethod anonymousMethod2 = () => { };
            Calculate anonymousCalc2 = (a, b) => { return a * b; };

            CalcuteNumber(Add, 3, 7);
            CalcuteNumber(anonymousCalc, 3, 7);
            CalcuteNumber(anonymousCalc2, 3, 7);

            // 在參數上面使用匿名方法
            CalcuteNumber(delegate (float a, float b) { return a / b; }, 9, 3);
            CalcuteNumber((a, b) => { return a / b; }, 9, 3); 
            #endregion

            funcCalc = delegate (float x) { return x * 10; };
            LogSystem.LogWithColor($"Func 委派 : {funcCalc(3.5f)}", "#f33");

            actionMetohd = delegate () { LogSystem.LogWithColor("Action 委派", "#f33"); };
            actionMetohd();

            predicate = delegate (float x) { return (x > 0); };
            LogSystem.LogWithColor($"Predicate 委派 : 7 是否大於零 - {predicate(7)}", "#f33");

            // Lambda 運算子 =>
            // (參數) => { 陳述式 }
            Action action = () => { LogSystem.LogWithColor("Lambda", "#ff3"); };
            action();

            Func<int, string> func = (x) => { return $"Lambbda 練習，數字 : {x}"; };
            LogSystem.LogWithColor($"{func(77)}", "#ff3");

            Predicate<string> predicateTest = (x) => { return x.Length > 0; };
            LogSystem.LogWithColor($"{predicateTest("KID")}", "#ff3");

        }
        // 委派 : 將方法當作參數
        private void CalcuteNumber(Calculate calculate, float a, float b)
        {
            var result = calculate(a, b);
            LogSystem.LogWithColor(result, "#ff3");
        }
    }
}

