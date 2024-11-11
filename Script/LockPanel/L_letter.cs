using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L_letter : MonoBehaviour
{
    [SerializeField]
    Text codeText2;
    string codeTextValue2 = "";

    public GameObject ControlSet2;//컨트롤 세트떄문에 만든 거//잠깐 다른데로 옮길 예쩡이라

    public QManager questManager2;//안 되면 지우기

    void Update()
    {
        ControlSet2.SetActive(false);//안 되면 지우기//잠깐 다른데로 옮길 예쩡이라
        codeText2.text = codeTextValue2;

        if (codeTextValue2 == "Sunjin")
        {


            PlayerAction.isStage2_DoorOpened = true;
            ControlSet2.SetActive(true);//잠깐 다른데로 옮길 예쩡이라

            questManager2.questObject[45].SetActive(true);



        }
        if (codeTextValue2.Length >= 6)
        {
            codeTextValue2 = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue2 += digit;
    }
}