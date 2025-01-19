using UnityEngine;

public class Exercise_4_Function : MonoBehaviour
{
    private void Awake()
    {
        bool a = kk(true);
        Debug.Log($"{a}");

        Debug.Log($"{boo()}");
    }
    private bool  kk( bool a = true)
    {
        return  a;
    }
    private bool boo(bool a=true, bool b = false)
    {
        return a && b;
    }
}
