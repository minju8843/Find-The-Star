using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class True_E2 : MonoBehaviour
{
    public DialogManager2 DialogManager2;


    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Surprise/�ǻ簡 ���� �� ���¸� ���Ѻ��� �Ѵ�µ�... ����ص� �����ھ�?", "NPC"));

        dialogTexts.Add(new DialogData("������. �� ���Ҿ�.", "Me"));

        dialogTexts.Add(new DialogData("/speed:down/.../speed:init/����?", "NPC"));

        dialogTexts.Add(new DialogData("�����ٴϱ�? ����.", "Me"));

        dialogTexts.Add(new DialogData("/emote:EyeSmile/(���� ��ģ �ո��� �丮���� ������ ��� ������.)", "Me", () => Not_Show_Example(0)));

        dialogTexts.Add(new DialogData("/emote:Surprise//speed:down/��... /speed:init/���� ���� �޶��� �� ����.", "NPC"));

        dialogTexts.Add(new DialogData("�׷�?", "Me"));

        dialogTexts.Add(new DialogData("/emote:Surprise/Ȥ�� �� �� �����̾�?", "NPC"));

        dialogTexts.Add(new DialogData("/emote:SadSmile//speed:down/.../speed:init/��.", "Me"));

        dialogTexts.Add(new DialogData("/emote:MouthSmile/�޿� ������ ���԰ŵ�.", "Me"));

        dialogTexts.Add(new DialogData("/emote:Surprise//speed:down/.../speed:init/�����̰�?", "NPC"));

        dialogTexts.Add(new DialogData("/emote:SadSmile//speed:down/��./speed:init/ �ڱ� ������ ���� ���� ���� �� �дٴ���.", "Me"));

        dialogTexts.Add(new DialogData("/emote:Smile//speed:down/.../speed:init/�� ���.", "NPC"));

        dialogTexts.Add(new DialogData("��, �׷��� ���� ���ǿ��� �� �Ź� ���� �̰� ������ �־��µ� Ȥ�� �� �ž�?", "NPC"));

        dialogTexts.Add(new DialogData("/speed:down/�̰�...", "Nothing"));

        //dialogTexts.Add(new DialogData("/speed:down/�̰�...", "Nothing", () => Show_Example(0)));

        dialogTexts.Add(new DialogData("(�׶� �����̰� �� �׸� ī���...)", "Taro2"));

        dialogTexts.Add(new DialogData("/emote:SadSmile//speed:down/...��./speed:init/ �� �ž�.", "Me"));

        dialogTexts.Add(new DialogData("���� ���̶�� �����ߴµ�...", "Next"));


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
