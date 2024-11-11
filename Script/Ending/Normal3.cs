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

        dialogTexts.Add(new DialogData("비록 현실이 아닌 다른 공간에 있지만,", "Me"));

        dialogTexts.Add(new DialogData("난 너만 있다면 뭐든지 할 수 있어.", "Me"));

        dialogTexts.Add(new DialogData("비록 빛 한 점 없는 어둠이 이곳에 찾아오더라도...", "Next"));


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
