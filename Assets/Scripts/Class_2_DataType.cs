using UnityEngine;
//�T�׽u�O�K�n (XML�y��) �Ψ�²�u�����A�i�[�b���O�P�ܼƤW��
/// <summary>
/// �{�Ѹ�����O
/// </summary>
public class Class_2_DataType : MonoBehaviour 
{
    //�ܼƻy�k:
    //�׹��� �ܼƸ������ �ܼƦW�� ���w �w�]��;
    //�|�j�`�θ�����O
    //��  ��:�x�s�S���p���I���ƭ�int
    //�B�I��:�x�s���p���I���ƭ� float �᭱�n�[f�Ҧp:0.1f
    //�r  ��:�x�s��r�A�ݥ����޸� string �e��ݥ[" "�Ҧp:( "hi")
    //���L��:�x�s���P��bool �u��2�ӭ� true �P false
    public int count =  7;
    public float moveSpeed = 3.5f;      //�B�I�ƥ����[F���\
    public float turnSpeed = 30.7F;     //�j�pf���i
    public string characcter = "�\��";
    public bool isDead = false;         //�O�_���` : �O
    public bool gameOver = true;         //�O�_���� : �_
}
