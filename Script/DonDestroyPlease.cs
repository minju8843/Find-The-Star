using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDestroyPlease : MonoBehaviour
{
    static public DonDestroyPlease instance;//맵 이동때문에 만듧
    private void Awake()
    {
        if (instance == null)//맵 이동때문에 작성하는 거임
        {
            DontDestroyOnLoad(this.gameObject);//얜 원래 있었음
            instance = this;//맵 이동때문에 작성하는 거임
        }
        else//맵 이동때문에 작성하는 거임
        {
            Destroy(gameObject);//맵 이동때문에 작성하는 거임
        }

        

    }
}
