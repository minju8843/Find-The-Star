using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestManager : MonoBehaviour
{


    public int questId; //���� �������� ����Ʈ id
    public int questActionIndex;//����Ʈ ��ȭ���� ���� ����

    //public GameObject[] questoOject=;

    public GameObject[] questObject;//����Ʈ ������Ʈ�� ������ ���� ����(�� ���ӿ��� ���谰����)

    Dictionary<int, QuestData> questList;//����Ʈ �����͸� ������ ��ųʸ� ���� ����

    //static public QuestManager instance;

   

    void Awake()
    {
        //questObject = GameObject.FindGameObjectsWithTag("Item");
        //DontDestroyOnLoad(this.gameObject);


        //DontDestroyOnLoad(this.gameObject);//�� ���� �־���
        //questObject = GameObject.FindGameObjectsWithTag("Item");
        questList = new Dictionary<int, QuestData>();//�� �ȵǸ� �ٽ� �츮��
        GenerateData();//�� �ȵǸ� �ٽ� �츮��
        



        //DontDestroyOnLoad(this.gameObject);

        //questList = new Dictionary<int, QuestData>();//�� �ȵǸ� �ٽ� �츮��
        //GenerateData();//�� �ȵǸ� �ٽ� �츮��

        //questList = new Dictionary<int, QuestData>();//�� �ȵǸ� �ٽ� �츮��
        //GenerateData();//�� �ȵǸ� �ٽ� �츮��

        /*if(instance==null)
        {

            DontDestroyOnLoad(this.gameObject);
            questList = new Dictionary<int, QuestData>();//�� �ȵǸ� �ٽ� �츮��
            GenerateData();//�� �ȵǸ� �ٽ� �츮��
            instance = this;
        }
        else if(instance!=null)
        {
            DontDestroyOnLoad(this.gameObject);
        }*/





        /*if(questObject.Length>1)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);*/





        //questObject = GameObject.FindGameObjectsWithTag("Item");










        /*if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject); // ���� ������Ʈ �ı�����
            questList = new Dictionary<int, QuestData>();//�� �ȵǸ� �ٽ� �츮��
            GenerateData();//�� �ȵǸ� �ٽ� �츮��

            instance = this;
        }
        else
        {
            Destroy(this.gameObject);

        }*/








    }





    void GenerateData()
    {

        questList.Add(10, new QuestData("���� ������ ���� ���� ���", new int[] {500, 10000 }));//Add�Լ��� QuestId, QuestData�����͸� ����
        //questList.Add(10, new QuestData("����Ʈ �̸�", new int[�ش� ����Ʈ�� ������ Id �з�] { })

        questList.Add(20, new QuestData("���� ã��", new int[] {100, 700}));

        questList.Add(30, new QuestData("����� �� ����", new int[] { 1600, 100 }));

        questList.Add(40, new QuestData("��Ʈ�� �����ϱ�", new int[] { 200}));

       // questList.Add(50, new QuestData("��Ʈ�� �ѱ�", new int[] { 200 }));

        questList.Add(50, new QuestData("���ϰ� å�� ����", new int[] { 1500, 400}));


        questList.Add(60, new QuestData("����� ������ �� �ٽ� Ȯ���ϱ�", new int[] { 1200, 400 }));

        questList.Add(70, new QuestData("�� Ŭ����", new int[] { 0 }));

    }

    public int GetQuestTalkIndex(int id)//NPC Id�� �ް� ����Ʈ��ȣ�� ��ȯ�ϴ� �Լ� ����
    {
        return questId + questActionIndex;//��ȭ ������ ���� ��ȭ�� ������ ���� ����Ʈ ��ȭ������ �ø�
    }

    public string CheckQuest(int id)//��簡 ������ questActionIndex++�� �ö󰡸鼭 ���� ����Ʈ�� �ҷ��´�.
    {
        if (id==questList[questId].npcId[questActionIndex])//�츮�� ������ NPC�� ��ȭ�� ���� ���� questActionIndex++�� �ö󰣴�.
            questActionIndex++;
        //�̾߱⸦ ������(��ȭ�� ������)//�ϳ��� �ö󰡸鼭


       
        //��ȭ�� ���� �Ŀ� �����ְų� ������ ����Ʈ ������Ʈ�� ������ �� �Լ�(ControlObject()) ����
        ControlObject();

        

        if (questActionIndex == questList[questId].npcId.Length)
            NextQuest();//���� ����Ʈ Ȯ��
        //questActionIndex�� npcId�� ũ��� ������ ����Ʈ ��ȣ�� ������Ų��.
        //==Npc�� ��ȭ�� �� ������ ���� ����Ʈ�� ��������ش�.

        return questList[questId].questName;//���� ����Ʈ �̸� ��ȯ

    }

    //�Ű������� ���� �ʴ� CheckQuest
    public string CheckQuest()
    {
        //����Ʈ�� �̸�
        return questList[questId].questName;

    }

    void NextQuest()//���� ����Ʈ�� ���� �Լ� ����
    {
        questId += 10;

        //���ο� ����Ʈ�� ����Ǳ� ������ 0���� �ʱ�ȭ��Ų��
        questActionIndex=0;
    }

    public void ControlObject()//����Ʈ ������Ʈ�� ������ �Լ� ���� //���� void���µ� ���嶧���� public��
    {

        switch (questId)
        {
            case 10:
                if (questActionIndex == 2)//2�� ��ȭ ������ ��(��, ����Ʈ ��ȭ�� ������ ��)
                  
                    questObject[0].SetActive(false);
                break;
            case 20:
                if (questActionIndex == 2)
                    questObject[0].SetActive(true);
                //������ �����ϸ� ����Ʈ ������Ʈ(���踦 �����ش�.)
                break;
            case 30:
                //if (questActionIndex == 0)
                    //questObject[0].SetActive(true);

                if (questActionIndex == 1)
                    questObject[0].SetActive(false);
                //questObject[0].SetActive(false);
                //���踦 �Ծ��� �� ���� ���ֱ�
                else if (questActionIndex == 2)
                {
                    questObject[2].SetActive(true);

                }
                    
                break;
            case 40:

                if (questActionIndex == 0)
                {
                    questObject[2].SetActive(true);

                }

                else if (questActionIndex == 1)
                {
                    questObject[1].SetActive(true);
                    questObject[2].SetActive(true);

                }
                    

                    
                break;
            case 50:
                if (questActionIndex == 0)
                {
                    questObject[2].SetActive(false);
                    questObject[1].SetActive(true);
                }

                else if (questActionIndex == 1)
                {
                    questObject[2].SetActive(false);
                    questObject[1].SetActive(true);
                }
                    
                break;
            case 60:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[2].SetActive(false);
                }

                else if (questActionIndex == 1)
                {
                    questObject[1].SetActive(true);
                    questObject[2].SetActive(false);
                }

                break;



        }
        
    }

}
