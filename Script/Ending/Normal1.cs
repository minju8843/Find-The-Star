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

        dialogTexts.Add(new DialogData("난... 나가지 않을래.", "Me"));//미소 울기 전

        dialogTexts.Add(new DialogData("/emote:Sad/어떻게 너와 다시 만났는데...", "Me"));//미소 운다

        dialogTexts.Add(new DialogData("/emote:Sad/우리 이대로 헤어지지 말고 같이 있자.", "Me"));//미소 운다

        dialogTexts.Add(new DialogData("우리 이대로 헤어지지 말고 같이 있자. - 예전처럼. ", "Me"));//미소 울기 전

        dialogTexts.Add(new DialogData("/emote:Fast/.....", "NPC"));//선진이 너무 일찍왔음

        dialogTexts.Add(new DialogData("그래.", "NPC"));//선진이 울기 전

        dialogTexts.Add(new DialogData("다시 잘 지내보자, 형.", "Next"));//선진이 울기 전



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
