using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class True_E3 : MonoBehaviour
{
    public DialogManager2 DialogManager2;

  
    public GameObject[] Example;

    private void Awake()
    {
        
        var dialogTexts = new List<DialogData>();


        dialogTexts.Add(new DialogData("(���� �����̰� �� �׸� ī�带 ��� �ϴ��� �÷��ٺ��Ҵ�.)", "Me"));

        dialogTexts.Add(new DialogData("/speed:down/.../speed:init/���õ��� ���� �� ���̳�.", "Next"));


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
