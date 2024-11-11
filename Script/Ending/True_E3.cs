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


        dialogTexts.Add(new DialogData("(나는 선진이가 준 그림 카드를 쥐며 하늘을 올려다보았다.)", "Me"));

        dialogTexts.Add(new DialogData("/speed:down/.../speed:init/오늘따라 별이 잘 보이네.", "Next"));


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
