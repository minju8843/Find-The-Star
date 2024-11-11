using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;


public class TestMessage : MonoBehaviour
{
    public DialogManager2 DialogManager2;


    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/speed:down/으... 으윽...", "Me"));

        dialogTexts.Add(new DialogData("/speed:down/...별아, /speed:init/한별아! 정신이 들어...?!", "NPC"));
        
        dialogTexts.Add(new DialogData("(걱정스러운 목소리를 내는 익숙한 실루엣이 눈앞에 나타났다.)", "Me"));

        dialogTexts.Add(new DialogData("/emote:Surprise/...임지은?", "Me"));

        dialogTexts.Add(new DialogData("그래, 나야! 얼마나 걱정했다고...!", "NPC"));

        dialogTexts.Add(new DialogData("/emote:Surprise/(지은에게 도움을 받아 힘겹게 몸을 일으킨 나는 주변을 둘러보았다.)", "Me"));

        dialogTexts.Add(new DialogData("/emote:Surprise//speed:down/(병실에 환자복... /speed:init/병원이다.)", "Me"));

        dialogTexts.Add(new DialogData("/emote:Surprise//speed:down/여긴... /emote:Sad//speed:init/현실이구나..", "Me"));

        dialogTexts.Add(new DialogData("그게 무슨 소리야? 안 좋은 꿈이라도 꿨어?", "NPC"));

        dialogTexts.Add(new DialogData("아니. 그립고/speed:down/... /emote:Tear//speed:init/행복한 꿈이었어.", "Next"));
        

        DialogManager2.Show(dialogTexts);


    }

   


    private void Show_Example(int index)//이걸 쓰면 화면에 그림 나타내고
    {
        Example[index].SetActive(true);
        
    }

    private void Not_Show_Example(int index)//이걸 쓰면 화면에 그림 없앰
    {
        Example[index].SetActive(false);

    }
}
