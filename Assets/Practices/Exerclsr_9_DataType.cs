using jeff.Tools;
using UnityEngine;

namespace jeff
{
    public class Exerclsr_9_DataType : MonoBehaviour
    {
        private void Awake()
        {
            float number = -999.321f;
            sbyte byteNumber = (sbyte)number;
            LogSystem.LogWithColor(byteNumber, "#6f6");
        }
    }

}
