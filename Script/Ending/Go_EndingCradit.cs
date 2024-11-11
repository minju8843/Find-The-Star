using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_EndingCradit : MonoBehaviour
{
    public GameObject fadeInPanel;//페이드 아웃->어두워질거임
    //public GameObject fadeOutPanel;

    public void go_Ending_Cradit()//내가 추가한 거. 트루 엔딩을 위해 다음 씬으로 ㄱㄱ
    {
        //fadeOutPanel.SetActive(true);
        fadeInPanel.SetActive(true);

        StartCoroutine(GO_Ending_Cra());//대사 후 컨트롤러 나올 시간을 벌기 위해 만든 거

        IEnumerator GO_Ending_Cra()//대사 후 컨트롤러 생성위해 만든 함수
        {
            yield return new WaitForSeconds(1.0f);//2초 후에 컨트롤러를 불러온다
            SceneManager.LoadScene("EndingCradit");

        }

    }
}
