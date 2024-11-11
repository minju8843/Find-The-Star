using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class Normal2 : MonoBehaviour
{
    public DialogManager2 DialogManager2;
    public GameObject[] Example;
    public GameObject fadeOutPanel;//페이드 아웃->어두워질거임

    private void Awake()
    {

        



        StartCoroutine(NofadeOut());//대사 후 컨트롤러 나올 시간을 벌기 위해 만든 거

        IEnumerator NofadeOut()//대사 후 컨트롤러 생성위해 만든 함수
        {
            yield return new WaitForSeconds(1.8f);//2초 후에 컨트롤러를 불러온다
            fadeOutPanel.SetActive(false);

        }

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/speed:down/삐... 삐... ", "None"));

        dialogTexts.Add(new DialogData("삐------", "No"));

        dialogTexts.Add(new DialogData("이, 이게 무슨/speed:down/... /speed:init/김한별 환자, 맥박이 뛰지 않습니다! 호흡 또한 정지됐습니다!", "nurse"));

        dialogTexts.Add(new DialogData("분명 생명에 이상이 갈 정도로 심각한 상태가 아니었는데... 어떻게 이런 일이...", "doctor"));

        dialogTexts.Add(new DialogData("(할 수 있는 처치를 다 해봤지만, 환자의 상태는 나아지지 않는다...)", "doctor"));

        dialogTexts.Add(new DialogData("/speed:down/.../speed:init/보호자분께 연락하세요.", "doctor"));

        dialogTexts.Add(new DialogData("현재 시각 22시 2분,/speed:down/ /speed:init/환자분 사망하셨습니다.", "doctor"));

        dialogTexts.Add(new DialogData("/speed:down/...어?", "doctor"));

        dialogTexts.Add(new DialogData("(이곳에 올 때만 해도 삶을 포기한 듯한 얼굴이었는데/speed:down/... /speed:init/어째서 지금은 웃고 있는 거지...?) ", "Next"));


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
