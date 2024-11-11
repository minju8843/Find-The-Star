using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class Normal3 : MonoBehaviour
{
    public DialogManager2 DialogManager2;
    public GameObject[] Example;

    private void Awake()
    {

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("��� ������ �ƴ� �ٸ� ������ ������,", "Me"));

        dialogTexts.Add(new DialogData("�� �ʸ� �ִٸ� ������ �� �� �־�.", "Me"));

        dialogTexts.Add(new DialogData("��� �� �� �� ���� ����� �̰��� ã�ƿ�����...", "Next"));


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
