using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L_letter : MonoBehaviour
{
    [SerializeField]
    Text codeText2;
    string codeTextValue2 = "";

    public GameObject ControlSet2;//��Ʈ�� ��Ʈ������ ���� ��//��� �ٸ����� �ű� �����̶�

    public QManager questManager2;//�� �Ǹ� �����

    void Update()
    {
        ControlSet2.SetActive(false);//�� �Ǹ� �����//��� �ٸ����� �ű� �����̶�
        codeText2.text = codeTextValue2;

        if (codeTextValue2 == "Sunjin")
        {


            PlayerAction.isStage2_DoorOpened = true;
            ControlSet2.SetActive(true);//��� �ٸ����� �ű� �����̶�

            questManager2.questObject[45].SetActive(true);



        }
        if (codeTextValue2.Length >= 6)
        {
            codeTextValue2 = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue2 += digit;
    }
}