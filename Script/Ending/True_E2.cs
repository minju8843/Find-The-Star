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

        dialogTexts.Add(new DialogData("/emote:Surprise/의사가 조금 더 상태를 지켜봐야 한댔는데... 퇴원해도 괜찮겠어?", "NPC"));

        dialogTexts.Add(new DialogData("괜찮아. 다 나았어.", "Me"));

        dialogTexts.Add(new DialogData("/speed:down/.../speed:init/정말?", "NPC"));

        dialogTexts.Add(new DialogData("괜찮다니까? 봐봐.", "Me"));

        dialogTexts.Add(new DialogData("/emote:EyeSmile/(나는 다친 손목을 요리조리 돌리며 밝게 웃었다.)", "Me", () => Not_Show_Example(0)));

        dialogTexts.Add(new DialogData("/emote:Surprise//speed:down/너... /speed:init/뭔가 많이 달라진 것 같아.", "NPC"));

        dialogTexts.Add(new DialogData("그래?", "Me"));

        dialogTexts.Add(new DialogData("/emote:Surprise/혹시 그 꿈 때문이야?", "NPC"));

        dialogTexts.Add(new DialogData("/emote:SadSmile//speed:down/.../speed:init/응.", "Me"));

        dialogTexts.Add(new DialogData("/emote:MouthSmile/꿈에 동생이 나왔거든.", "Me"));

        dialogTexts.Add(new DialogData("/emote:Surprise//speed:down/.../speed:init/선진이가?", "NPC"));

        dialogTexts.Add(new DialogData("/emote:SadSmile//speed:down/응./speed:init/ 자기 만나러 일찍 오면 가만 안 둔다더라.", "Me"));

        dialogTexts.Add(new DialogData("/emote:Smile//speed:down/.../speed:init/걔 답네.", "NPC"));

        dialogTexts.Add(new DialogData("아, 그러고 보니 병실에서 네 신발 옆에 이게 떨어져 있었는데 혹시 네 거야?", "NPC"));

        dialogTexts.Add(new DialogData("/speed:down/이건...", "Nothing"));

        //dialogTexts.Add(new DialogData("/speed:down/이건...", "Nothing", () => Show_Example(0)));

        dialogTexts.Add(new DialogData("(그때 선진이가 준 그림 카드다...)", "Taro2"));

        dialogTexts.Add(new DialogData("/emote:SadSmile//speed:down/...응./speed:init/ 내 거야.", "Me"));

        dialogTexts.Add(new DialogData("그저 꿈이라고만 생각했는데...", "Next"));


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
