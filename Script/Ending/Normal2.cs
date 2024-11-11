using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class Normal2 : MonoBehaviour
{
    public DialogManager2 DialogManager2;
    public GameObject[] Example;
    public GameObject fadeOutPanel;//���̵� �ƿ�->��ο�������

    private void Awake()
    {

        



        StartCoroutine(NofadeOut());//��� �� ��Ʈ�ѷ� ���� �ð��� ���� ���� ���� ��

        IEnumerator NofadeOut()//��� �� ��Ʈ�ѷ� �������� ���� �Լ�
        {
            yield return new WaitForSeconds(1.8f);//2�� �Ŀ� ��Ʈ�ѷ��� �ҷ��´�
            fadeOutPanel.SetActive(false);

        }

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/speed:down/��... ��... ", "None"));

        dialogTexts.Add(new DialogData("��------", "No"));

        dialogTexts.Add(new DialogData("��, �̰� ����/speed:down/... /speed:init/���Ѻ� ȯ��, �ƹ��� ���� �ʽ��ϴ�! ȣ�� ���� �����ƽ��ϴ�!", "nurse"));

        dialogTexts.Add(new DialogData("�и� ���� �̻��� �� ������ �ɰ��� ���°� �ƴϾ��µ�... ��� �̷� ����...", "doctor"));

        dialogTexts.Add(new DialogData("(�� �� �ִ� óġ�� �� �غ�����, ȯ���� ���´� �������� �ʴ´�...)", "doctor"));

        dialogTexts.Add(new DialogData("/speed:down/.../speed:init/��ȣ�ںв� �����ϼ���.", "doctor"));

        dialogTexts.Add(new DialogData("���� �ð� 22�� 2��,/speed:down/ /speed:init/ȯ�ں� ����ϼ̽��ϴ�.", "doctor"));

        dialogTexts.Add(new DialogData("/speed:down/...��?", "doctor"));

        dialogTexts.Add(new DialogData("(�̰��� �� ���� �ص� ���� ������ ���� ���̾��µ�/speed:down/... /speed:init/��°�� ������ ���� �ִ� ����...?) ", "Next"));


        DialogManager2.Show(dialogTexts);


    }


    private void Show_Example(int index)//�̰� ���� ȭ�鿡 �׸� ��Ÿ����
    {
        Example[index].SetActive(true);

    }

    private void Not_Show_Example(int index)//�̰� ���� ȭ�鿡 �׸� ����
    {
        Example[index].SetActive(false);

    }
}
