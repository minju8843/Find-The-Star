using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class True_Ending : MonoBehaviour
{
    public GameObject ControlSet;//��Ʈ�� ��Ʈ
    public GameObject Player;//�÷��̾�
    public GameObject SoundManager;//����

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name== "True_Ending1")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "True_Ending2")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "True_Ending3")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "True_Ending")
        {
            ControlSet.SetActive(false);
            SoundManager.SetActive(false);
            Player.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Normal_Ending1")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Normal_Ending2")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Normal_Ending3")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Normal_Ending")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "EndingCradit")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Prologe")
        {
            ControlSet.SetActive(false);
            Player.SetActive(false);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }

        //���κ��� ���̳α���
        if (SceneManager.GetActiveScene().name == "Main")
        {
            ControlSet.SetActive(true);
            Player.SetActive(true);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "bathroom")
        {
            //ControlSet.SetActive(true);
            Player.SetActive(true);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            ControlSet.SetActive(true);
            Player.SetActive(true);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "SecondStage")
        {
            //ControlSet.SetActive(true);
            Player.SetActive(true);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "ThirdScene")
        {
            //ControlSet.SetActive(true);
            Player.SetActive(true);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "FourthStage")
        {
            // ControlSet.SetActive(true);
            Player.SetActive(true);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "FinalScene")
        {
            //ControlSet.SetActive(true);
            Player.SetActive(true);
            SoundManager.SetActive(true);
            //EndingCra.SetActive(false);
        }
    }
}
