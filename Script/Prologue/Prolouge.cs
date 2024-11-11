using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class Prolouge : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject[] Example;

    private void Awake()
    {

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("��, ����? ���� �����?", "Me"));//�̼� ��� ��

        dialogTexts.Add(new DialogData(".....", "Me"));//�̼� ���

        dialogTexts.Add(new DialogData("�ȳ��ϼ���.", "NPC"));//�̼� ���

        dialogTexts.Add(new DialogData("������ �����ϱ� ��, ���ӹ���� �˷��帮�� �մϴ�.", "NPC"));//�̼� ��� ��

        dialogTexts.Add(new DialogData("����, ĳ���ʹ� ���ʿ� �ִ� '�����¿� ��ư'���� ������ �� ������", "Key_Button"));//������ �ʹ� �������

        dialogTexts.Add(new DialogData("�������� '���� ��ư'���� ����� NPC���� ��ȭ�� �� �� �ֽ��ϴ�.", "Red_Button"));//������ ��� ��

        dialogTexts.Add(new DialogData("��ȭ â�� ��� �� ������ �ֽ��ϴٸ�, ������ ��ȭâ�� ���", "NPC"));

        dialogTexts.Add(new DialogData("��ȭâ�� '��ġ'�ؾ����� ���� ��ȭ�� �Ѿ �� �ֽ��ϴ�.", "NPC"));

        dialogTexts.Add(new DialogData("���� �Ʒ� ��� ȭ��ǥ�� �ִ� ��ȭâ��", "Yellow_Arrow"));

        dialogTexts.Add(new DialogData("�������� '���� ��ư'�� ��ġ�Ͽ� ��ȭ�� ������ �� �ֽ��ϴ�.", "RedYellow"));

        dialogTexts.Add(new DialogData("�׸��� ��ȭâ �����ʿ� ����� ȭ��ǥ�� �����ϸ�", "Big_Arrow"));

        dialogTexts.Add(new DialogData("'����� ȭ��ǥ�� ��ġ'�Ͽ� ���� ������� �Ѿ �� �ֽ��ϴ�.", "Big_Arrow"));

        dialogTexts.Add(new DialogData("�� �ܿ� ������ ���� ���ų� ��ȭâ�� ������ ���� ���, 'ȭ���� ��ġ'�Ͻø� �˴ϴ�.", "NPC"));

        dialogTexts.Add(new DialogData("���������� ���� ��ư�� �ڵ��� ������ '�ڷΰ��� ��ư'�� �����ø� �� �� ������", "NPC"));

        dialogTexts.Add(new DialogData("���� ��� ���� �ڵ��� ������ '�ڷΰ��� ��ư'�� ���� �ٽ� �� �� �ֽ��ϴ�.", "NPC"));

        dialogTexts.Add(new DialogData("���� �غ� �� �Ǽ�����, ������ ȭ��ǥ�� �����ּ���!", "Next"));//������ ��� ��



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
