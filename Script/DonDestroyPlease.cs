using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDestroyPlease : MonoBehaviour
{
    static public DonDestroyPlease instance;//�� �̵������� ����
    private void Awake()
    {
        if (instance == null)//�� �̵������� �ۼ��ϴ� ����
        {
            DontDestroyOnLoad(this.gameObject);//�� ���� �־���
            instance = this;//�� �̵������� �ۼ��ϴ� ����
        }
        else//�� �̵������� �ۼ��ϴ� ����
        {
            Destroy(gameObject);//�� �̵������� �ۼ��ϴ� ����
        }

        

    }
}
