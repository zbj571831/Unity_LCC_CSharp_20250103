using UnityEngine;

namespace jeff 
{
    /// <summary>
    /// ���йB�⳯�z�� : �j��
    /// for ` foreach ` do �P while
    /// </summary>
    public class Class_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {
            //�j��Цb�@���ʨƥ󤺨ϥ� Awake ` Start
            //while �j�� : ���L�Ȭ� true �ɷ|�������
            //while (���L��) { �{���϶� }
            //�L���j�� : ���L�Ȥ@���O true
            //�ŧi�ϰ��ܼ� i �� 0 
            int i = 0;
            i = 5;              //���� while �P do ���t��
            //�� i < 5 �N���� {}
            while (i < 5)
            {
                Debug.Log($"<color=#f33>while �j��A i :{i}</color>");
                //i ���W (i + 1)
                i++;
            }

            //do �j�� :
            //do { �{���϶� } while (���L��)
            int j = 0;
            j = 5;              //���� while �P do ���t��
            do
            {
                Debug.Log($"<color=#f79>do �j��A j :{j}</color>");
            }
            while (j < 5);

            //for �j�� :
            //for (��l�� ; ���L�� ; ���N��) {�{���϶�}
            for (int k = 0; k < 5; k++)
            {
                Debug.Log($"<color=#78f>for �j��A k :{k}</color>");
            }
        }

    }

}

