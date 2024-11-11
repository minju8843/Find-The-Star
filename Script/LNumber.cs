using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LNumber : MonoBehaviour
{
    [SerializeField]
    Text codeText;
    string codeTextValue = "";

    public GameObject ControlSet;//��Ʈ�� ��Ʈ������ ���� ��//��� �ٸ����� �ű� �����̶�

    public QManager questManager;//�� �Ǹ� �����

    void Update()
    {
        ControlSet.SetActive(false);//�� �Ǹ� �����//��� �ٸ����� �ű� �����̶�
        codeText.text = codeTextValue;

        if (codeTextValue == "1002")
        {
            

            PlayerAction.isStage1_DoorOpened = true;
            ControlSet.SetActive(true);//��� �ٸ����� �ű� �����̶�

            questManager.questObject[5].SetActive(true);//�� �Ǹ� �����

            questManager.questObject[19].SetActive(true);//�м���




        }
        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
