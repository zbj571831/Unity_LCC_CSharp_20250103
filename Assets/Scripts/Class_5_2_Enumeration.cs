using UnityEngine;

namespace jeff 
{
    /// <summary>
    /// �C�| : enumeration�AC# ������r��²�g enum
    /// </summary>
    public class Class_5_2_Enumeration : MonoBehaviour
    {
        #region �{�ѦC�|
        //�C�| : �w�q�U�Կ�檺�ﶵ (�q�`���O���)
        //�y�k :
        //�׹��� ����r enum �C�|�W�� { �C�|�ﶵ }
        //�w�q�@�ӦC�|�A�W�٥s�u�`
        //�C�|���O�ƭȡA�w�]�q 0 �}�l
        private enum Season
        {
            //�w�q�C�|�ﶵ
            Spring, Summer, Autumn, Winnter
        }
        //�ŧi�ܼơA�������u�`�C�|�A�w�]�Ȭ��L��
        [SerializeField, Header("�u�`")]
        private Season season = Season.Summer;

        private void Awake()
        {
            //���o�C�|���� (Get) ��X��
            Debug.Log(season);
            //���o�C�|����
            Debug.Log((int)season);

            //�]�w�C�|����ƭ� (Set) �ק�� 
            season = Season.Winnter;
            Debug.Log(season);
            //�q�L�ƭȳ]�w�C�|
            season = (Season)2;
            Debug.Log(season);
        } 
        #endregion

        private enum Item
        {
            None = 0, Coin = 1,RedWater = 10 ,BlueWater = 15 , Chicken = 20
        }
        [SerializeField , Header("�D��")]
        private Item item = Item.Chicken;

        //���涶�� : Awake > Start >Update
        //�}�l�ƥ� : �b����ƥ�����@��  (��l��)
        private void Start()
        {
            Debug.Log(item);
            Debug.Log ((int)item);
            item = Item.BlueWater;
        }

    }

    

}

