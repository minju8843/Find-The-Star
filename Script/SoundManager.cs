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
                BgSoundPlay(bglist[i]);//��������� �̸��� ���� �̸��� ���� ���� ���
        }
    }

    /*public void BGSoundVolume(float val)//�� �̰��� ��� ���� ���� �޴� �׸��� �־�� �ϴµ� ���� �����Ƿ� ������
    {
        mixer.SetFloat("BGSoundVolume", Mathf.Log10(val)*20);//�ͼ��� �Ķ���� ���� �Ǽ��� ���� �Ѱ���
        //�̶� �Ѱ��ִ� ���� ������ ���ε� mix�� ������ LogScale�� ����ϹǷ� 
        //������ ���� ���� ��ȯ�� ���� �Ѱ��־���� ����� ���� ��ȭ�� �̷������.

    }*/

    /*public void SFXPlay(string sfxName, AudioClip clip)//����� �ƴ�
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audiosource = go.AddComponent<AudioSource>();
        audiosource.outputAudioMixerGroup=mixer.FindMatchingGroups("SFX")[0];//�׷� �̸��� mixer���� ã�ƿ��� ��
        audiosource.clip = clip;
        audiosource.Play();
    }*/

    public void BgSoundPlay(AudioClip clip)//�����
    {
        bgSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGSound")[0];
        bgSound.clip = clip;
        bgSound.loop = true;
        bgSound.volume = 0.1f;
        bgSound.Play();

        /*if (TitleSet.activeSelf)//Ÿ��Ʋ ���� ������
        {
            TitleSet.SetActive(true);//Ÿ��Ʋ�� ���ּ���
            bgSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGSound")[0];
            bgSound.clip = clip;
            bgSound.loop = true;
            bgSound.volume = 0.1f;
            bgSound.Pause();
        }


        else
        {
            TitleSet.SetActive(false);//�ƴϸ� Ÿ��Ʋ�� �Ѽ���
            bgSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGSound")[0];
            bgSound.clip = clip;
            bgSound.loop = true;
            bgSound.volume = 0.1f;
            bgSound.Play();
        }*/
            

    }

}