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

        dialogTexts.Add(new DialogData("뭐, 뭐야? 여긴 어디지?", "Me"));//미소 울기 전

        dialogTexts.Add(new DialogData(".....", "Me"));//미소 운다

        dialogTexts.Add(new DialogData("안녕하세요.", "NPC"));//미소 운다

        dialogTexts.Add(new DialogData("게임을 시작하기 전, 게임방법을 알려드리려 합니다.", "NPC"));//미소 울기 전

        dialogTexts.Add(new DialogData("먼저, 캐릭터는 왼쪽에 있는 '상하좌우 버튼'으로 움직일 수 있으며", "Key_Button"));//선진이 너무 일찍왔음

        dialogTexts.Add(new DialogData("오른쪽의 '빨간 버튼'으로 조사와 NPC와의 대화를 할 수 있습니다.", "Red_Button"));//선진이 울기 전

        dialogTexts.Add(new DialogData("대화 창의 경우 세 가지가 있습니다만, 현재의 대화창의 경우", "NPC"));

        dialogTexts.Add(new DialogData("대화창을 '터치'해야지만 다음 대화로 넘어갈 수 있습니다.", "NPC"));

        dialogTexts.Add(new DialogData("다음 아래 노란 화살표가 있는 대화창은", "Yellow_Arrow"));

        dialogTexts.Add(new DialogData("오른쪽의 '빨간 버튼'을 터치하여 대화를 진행할 수 있습니다.", "RedYellow"));

        dialogTexts.Add(new DialogData("그리고 대화창 오른쪽에 노란색 화살표가 등장하면", "Big_Arrow"));

        dialogTexts.Add(new DialogData("'노란색 화살표를 터치'하여 다음 장면으로 넘어갈 수 있습니다.", "Big_Arrow"));

        dialogTexts.Add(new DialogData("그 외에 조사할 것이 없거나 대화창이 보이지 않을 경우, '화면을 터치'하시면 됩니다.", "NPC"));

        dialogTexts.Add(new DialogData("마지막으로 저장 버튼은 핸드폰 내부의 '뒤로가기 버튼'을 누르시면 볼 수 있으며", "NPC"));

        dialogTexts.Add(new DialogData("게임 방법 또한 핸드폰 내부의 '뒤로가기 버튼'을 통해 다시 볼 수 있습니다.", "NPC"));

        dialogTexts.Add(new DialogData("이제 준비가 다 되셨으면, 오른쪽 화살표를 눌러주세요!", "Next"));//선진이 울기 전



        DialogManager.Show(dialogTexts);


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
