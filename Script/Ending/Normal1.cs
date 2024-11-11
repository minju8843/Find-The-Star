using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class Normal1 : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject[] Example;

    private void Awake()
    {

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("��... ������ ������.", "Me"));//�̼� ��� ��

        dialogTexts.Add(new DialogData("/emote:Sad/��� �ʿ� �ٽ� �����µ�...", "Me"));//�̼� ���

        dialogTexts.Add(new DialogData("/emote:Sad/�츮 �̴�� ������� ���� ���� ����.", "Me"));//�̼� ���

        dialogTexts.Add(new DialogData("�츮 �̴�� ������� ���� ���� ����. - ����ó��. ", "Me"));//�̼� ��� ��

        dialogTexts.Add(new DialogData("/emote:Fast/.....", "NPC"));//������ �ʹ� �������

        dialogTexts.Add(new DialogData("�׷�.", "NPC"));//������ ��� ��

        dialogTexts.Add(new DialogData("�ٽ� �� ��������, ��.", "Next"));//������ ��� ��



        DialogManager.Show(dialogTexts);


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
