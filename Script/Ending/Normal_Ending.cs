using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Normal_Ending : MonoBehaviour
{
    public GameObject fadeInPanel;//���̵� �ƿ�->��ο�������
    //public GameObject fadeOutPanel;

    public void Ending_Cradit()//���� �߰��� ��. Ʈ�� ������ ���� ���� ������ ����
    {
        //fadeOutPanel.SetActive(true);
        fadeInPanel.SetActive(true);

        StartCoroutine(Ending_Cra());//��� �� ��Ʈ�ѷ� ���� �ð��� ���� ���� ���� ��

        IEnumerator Ending_Cra()//��� �� ��Ʈ�ѷ� �������� ���� �Լ�
        {
            yield return new WaitForSeconds(1.0f);//2�� �Ŀ� ��Ʈ�ѷ��� �ҷ��´�
            SceneManager.LoadScene("EndingCradit");

        }

    }
}
