using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LNumber : MonoBehaviour
{
    [SerializeField]
    Text codeText;
    string codeTextValue = "";

    public GameObject ControlSet;//컨트롤 세트떄문에 만든 거//잠깐 다른데로 옮길 예쩡이라

    public QManager questManager;//안 되면 지우기

    void Update()
    {
        ControlSet.SetActive(false);//안 되면 지우기//잠깐 다른데로 옮길 예쩡이라
        codeText.text = codeTextValue;

        if (codeTextValue == "1002")
        {
            

            PlayerAction.isStage1_DoorOpened = true;
            ControlSet.SetActive(true);//잠깐 다른데로 옮길 예쩡이라

            questManager.questObject[5].SetActive(true);//안 되면 지우기

            questManager.questObject[19].SetActive(true);//분수대




        }
        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
