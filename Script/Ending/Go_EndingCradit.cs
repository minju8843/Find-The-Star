using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_EndingCradit : MonoBehaviour
{
    public GameObject fadeInPanel;//���̵� �ƿ�->��ο�������
    //public GameObject fadeOutPanel;

    public void go_Ending_Cradit()//���� �߰��� ��. Ʈ�� ������ ���� ���� ������ ����
    {
        //fadeOutPanel.SetActive(true);
        fadeInPanel.SetActive(true);

        StartCoroutine(GO_Ending_Cra());//��� �� ��Ʈ�ѷ� ���� �ð��� ���� ���� ���� ��

        IEnumerator GO_Ending_Cra()//��� �� ��Ʈ�ѷ� �������� ���� �Լ�
        {
            yield return new WaitForSeconds(1.0f);//2�� �Ŀ� ��Ʈ�ѷ��� �ҷ��´�
            SceneManager.LoadScene("EndingCradit");

        }

    }
}
