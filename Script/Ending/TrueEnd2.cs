using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueEnd2 : MonoBehaviour
{
    public GameObject SoundManager;//����

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "True_Ending1")
        {

            SoundManager.SetActive(false);
        }

        /*if (SceneManager.GetActiveScene().name == "True_Ending2")
        {

            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "True_Ending3")
        {
            SoundManager.SetActive(false);
        }*/

        /*if (SceneManager.GetActiveScene().name == "True_Ending")
        {
            SoundManager.SetActive(false);
        }*/

        if (SceneManager.GetActiveScene().name == "Normal_Ending1")
        {
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Normal_Ending2")
        {
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Normal_Ending3")
        {
            
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "Normal_Ending")
        {
            
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "EndingCradit")
        {
            
            SoundManager.SetActive(false);
        }


        //�ٸ� ����������
        if (SceneManager.GetActiveScene().name == "Main")
        {

            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "bathroom")
        {
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "SampleScene")
        {

            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "SecondStage")
        {
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "ThirdScene")
        {

            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "FourthStage")
        {
            SoundManager.SetActive(false);
        }

        if (SceneManager.GetActiveScene().name == "FinalScene")
        {
            SoundManager.SetActive(false);
        }
    }
}
