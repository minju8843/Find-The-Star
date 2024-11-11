using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioSource bgSound;
    public AudioClip[] bglist;
    public static SoundManager instance;




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        for (int i = 0; i < bglist.Length; i++)
        {
            if (arg0.name == bglist[i].name)
                BgSoundPlay(bglist[i]);//배경음악의 이름과 씬의 이름이 같은 것이 재생
        }
    }

    /*public void BGSoundVolume(float val)//단 이것의 경우 볼륨 값을 받는 그림이 있어야 하는데 여기 없으므로 무쓸모
    {
        mixer.SetFloat("BGSoundVolume", Mathf.Log10(val)*20);//믹서에 파라미터 값과 실수형 값을 넘겨줌
        //이때 넘겨주는 값이 볼륨의 값인데 mix의 볼륨은 LogScale을 사용하므로 
        //간단한 식을 통해 변환한 값을 넘겨주어야지 제대로 음량 변화가 이루어진다.

    }*/

    /*public void SFXPlay(string sfxName, AudioClip clip)//배경음 아님
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audiosource = go.AddComponent<AudioSource>();
        audiosource.outputAudioMixerGroup=mixer.FindMatchingGroups("SFX")[0];//그룹 이름을 mixer에서 찾아오면 됨
        audiosource.clip = clip;
        audiosource.Play();
    }*/

    public void BgSoundPlay(AudioClip clip)//배경음
    {
        bgSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGSound")[0];
        bgSound.clip = clip;
        bgSound.loop = true;
        bgSound.volume = 0.1f;
        bgSound.Play();

        /*if (TitleSet.activeSelf)//타이틀 켜져 있으면
        {
            TitleSet.SetActive(true);//타이틀을 꺼주세요
            bgSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGSound")[0];
            bgSound.clip = clip;
            bgSound.loop = true;
            bgSound.volume = 0.1f;
            bgSound.Pause();
        }


        else
        {
            TitleSet.SetActive(false);//아니면 타이틀을 켜세요
            bgSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGSound")[0];
            bgSound.clip = clip;
            bgSound.loop = true;
            bgSound.volume = 0.1f;
            bgSound.Play();
        }*/
            

    }

}