using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;//����Ʈ�� ���õ� �ٸ� npc�� �ִ� ���
    public GameObject[] questObject;

    Dictionary<int, QuestData> questiList;

    void Awake()
    {
        questiList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    void GenerateData()
    {
        //��ǻ�� ����
        //���� ������ ���� �̾߱� ���
        //ȭ��� �� ����
        //���ߵ��� ���� ���� �� ����


        
        questiList.Add(10, new QuestData("��ǻ�� ���� �ѱ�", new int[] { 200, 35000, 7900, 73000, 37000, 1600}));

        questiList.Add(20, new QuestData("ȭ�߽� ���� �� ���� �����ϱ�", new int[] { 73000, 34000, 39000, 2700, 7900, 44000}));

        questiList.Add(30, new QuestData("������ϰ� �� Ȯ��", new int[] { 400, 1000, 900, 1200, 1300,1100, 44000 }));//1�� �߰�

        //questiList.Add(90, new QuestData("�� ����ü", new int[] { 3100 }));//������ �ǳ� ������
        //������ �� ��! ��ȣ!

        //questiList.Add(100, new QuestData("����Ʈ �� Ŭ����", new int[] { 0 }));

        questiList.Add(40, new QuestData("Ÿ��ĸ�� �񼮿� �� �ױ�", new int[] { 2900, 3100, 4600, 7500, 6000, 55000, 2900, 3100 }));

        questiList.Add(50, new QuestData("�߱���� ������ �������� ��Ʈ�� �� �ű�� ���� Ȯ��", new int[] { 57000, 58000, 59000, 4100, 6100, 4100, 61000 }));

        questiList.Add(60, new QuestData("����� ���� ���� �� ģ������ ���� �̾߱� ���", new int[] { 62000, 63000, 64000, 65000, 7500, 66000, 7500 }));

        questiList.Add(70, new QuestData("����ġ �Ѽ� �� ���� ��� �� ����", new int[] { 5900, 4500, 5900, 6300, 4600 }));

        //questiList.Add(80, new QuestData("����Ʈ �� Ŭ����", new int[] { 0 }));

        questiList.Add(80, new QuestData("����س���", new int[] { 9500, 4200, 46000, 6600, 49000, 4300, 51000, 52000 }));

        questiList.Add(90, new QuestData("��￡ ���� �ܼ��� ���� ��, ���� ���", new int[] { 7000, 56000, 4200, 7200, 4200, 5300, 9900, 9500 }));

        questiList.Add(100, new QuestData("���� Ȯ���ϸ� ���ã�� ��Ʈ�� Ȯ��", new int[] { 10000, 11000, 12000, 13000, 14000, 15000, 16000, 17000, 48000 }));//���� 18000 �־��µ� ��� 110��� �ű�

        questiList.Add(110, new QuestData("����Ʈ���ϰ� NPC1�ϰ� ����ϰ� ��ǰ���", new int[] { 19000, 20000, 11000, 11000, 11000, 22000, 73000}));//���� 23000, 24000 �־��µ� 120����� �ű�

        questiList.Add(120, new QuestData("��ǰ��� ���� ���� �� ��� �� ����", new int[] { 23000, 24000 , 25000, 25000, 26000, 27000}));

        questiList.Add(130, new QuestData("���ܿ� �� �ø���", new int[] { 47000, 47000, 47000, 47000, 47000, 47000, 42000, 42000, 43000 }));

        questiList.Add(140, new QuestData("���ܿ� �� �ø���", new int[] { 43000, 43000, 43000, 43000, 53000 }));

        questiList.Add(150, new QuestData("����Ʈ �� Ŭ����", new int[] { 0 }));

    }
    public int GetQuestTalkIndex(int id)//NPC ID�� �ް� ����Ʈ��ȣ�� ��ȯ�ϴ� �Լ�
    {
        return questId + questActionIndex;//����Ʈ ��ȣ+����Ʈ ��ȭ����=����Ʈ ��ȭId
    }
    public string CheckQuest(int id)//�� ��° npc�� ����Ʈ ��ȭ
    {
        //Next Talk Target
        if (id == questiList[questId].npcId[questActionIndex])
            questActionIndex++;//������ ���� ����Ʈ ��ȭ������ �ø��� �Լ�

        //Control Quest Object
        ControlObject();

        //Talk Complete & Next Quest
        //������ �°� ��ȭ���� ���� ����Ʈ ��ȭ���� �ö�
        if (questActionIndex == questiList[questId].npcId.Length)
            NextQuest();
        //����Ʈ ��ȭ ������ ���� �������� �� ����Ʈ ��ȣ ����

        //Quest Name
        return questiList[questId].questName;
        //����Ʈ �̸��� �ܼ�(console)���� ��ȯ�ϵ���
    }

    public string CheckQuest()//�� ��° npc�� ����Ʈ ��ȭ
    {
        //Quest Name
        return questiList[questId].questName;
        //����Ʈ �̸��� �ܼ�(console)���� ��ȯ�ϵ���
    }

    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
    }

    //����Ʈ ������Ʈ�� ������ �Լ� ����
    public void ControlObject()
    {
        switch (questId)
        {

            case 10:
                if (questActionIndex == 0)
                {
                    questObject[2].SetActive(false);
                    //questObject[3].SetActive(false);


                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }

                else if (questActionIndex == 1)
                {
                    questObject[2].SetActive(false);
                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }
                
                //break;

            //case 20:
                /*if (questActionIndex == 0)
                {

                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }*/

                else if (questActionIndex == 2)
                {

                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                else if (questActionIndex == 3)
                {
                    questObject[0].SetActive(false);
                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }
                    
                //break;

            //case 30:
                /*if (questActionIndex == 0)
                {

                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }*/

                else if (questActionIndex == 4)
                {
                    questObject[0].SetActive(false);
                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }
                    
                
                else if (questActionIndex == 5)
                {
                    questObject[0].SetActive(true);
                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                //�ƴϸ� �����?
                else if (questActionIndex == 6) //40-0:�����. ����. //���� �����
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    //questObject[2].SetActive(false);
                    //questObject[2].SetActive(true);//�ƴϸ� �����
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                


                /*else if (questActionIndex == 7)//41-���̴� ���ȴ�.
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(true);
                    //questObject[4].SetActive(true);//�밡?

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }*/

                break;
            case 20://41:���� ����

                //�̰� �ƴϸ� �����
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(false);
                    //questObject[4].SetActive(true);//�밡?

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                else if (questActionIndex == 1)//41-���̴� ���ȴ�.
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(true);
                    //questObject[4].SetActive(true);//�밡?

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }
                /*if (questActionIndex == 0)
                {
                    questObject[0].SetActive(true);
                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                else if (questActionIndex == 1) //40-0:�����. ����. //���� �����
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(false);
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                    


                else if (questActionIndex == 2)//41-���̴� ���ȴ�.
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(true);
                    //questObject[4].SetActive(true);//�밡?

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }*/

                //break;


                /*case 50://�����ϱ�
                    if (questActionIndex == 0)
                    {
                        //questObject[4].SetActive(true);//�밡?
                        questObject[1].SetActive(true);
                        questObject[2].SetActive(false);

                        questObject[6].SetActive(true);
                        questObject[8].SetActive(true);
                        questObject[10].SetActive(true);
                        questObject[12].SetActive(true);
                        questObject[14].SetActive(true);
                        questObject[16].SetActive(true);
                        questObject[18].SetActive(true);


                    }*/

                else if (questActionIndex ==2)
                {
                    //questObject[4].SetActive(true);//�밡?
                    questObject[0].SetActive(false);
                    questObject[1].SetActive(true);
                    questObject[2].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }


                else if (questActionIndex == 3)
                {
                    //questObject[4].SetActive(true);//�밡?
                    //questObject[0].SetActive(true);
                    questObject[1].SetActive(true);
                    questObject[2].SetActive(false);
                    questObject[3].SetActive(true);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }

                //break;

            /*case 60://61:���� ���� ����
                if (questActionIndex == 0)
                {
                    //questObject[4].SetActive(true);//�밡?
                    questObject[3].SetActive(true);
                    questObject[1].SetActive(true);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }*/

                else if (questActionIndex == 4) //���� ���� �ݱ�//���� ���� �����
                {
                    //questObject[4].SetActive(true);//�밡?
                    questObject[1].SetActive(true);
                    questObject[3].SetActive(false);
                    questObject[2].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }




                else if (questActionIndex == 5)//41-���̴� ���ȴ�.
                {
                    //questObject[4].SetActive(true);//�밡?
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    //questObject[2].SetActive(true);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);


                }

                //break;





            /*case 30://2���������� ���� �� Ȯ��
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[2].SetActive(false);
                    //questObject[3].SetActive(true);//�밡?
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }*/

                else if (questActionIndex == 6)
                {
                    questObject[1].SetActive(true);
                    //questObject[3].SetActive(false);
                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }


                break;

            case 30://���� ���� ���� ��µ�
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);

                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                else if (questActionIndex == 1)//å��
                {
                    questObject[1].SetActive(true);

                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);

                    questObject[15].SetActive(true);
                    questObject[14].SetActive(false);

                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }
                    
                

                else if (questActionIndex == 2)//����������
                {
                    questObject[1].SetActive(true);

                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[13].SetActive(true);

                    questObject[15].SetActive(true);
                    questObject[14].SetActive(false);

                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                else if (questActionIndex == 3)//������
                {
                    questObject[1].SetActive(true);

                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    
                    questObject[13].SetActive(true);
                    questObject[12].SetActive(false);

                    questObject[15].SetActive(true);
                    questObject[14].SetActive(false);

                    questObject[16].SetActive(false);
                    questObject[17].SetActive(true);

                    questObject[18].SetActive(true);
                }

                else if (questActionIndex == 4)//�����
                {
                    questObject[1].SetActive(true);

                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[9].SetActive(true);
                    questObject[8].SetActive(false);

                    questObject[10].SetActive(true);

                    questObject[13].SetActive(true);
                    questObject[12].SetActive(false);
                    
                    questObject[15].SetActive(true);
                    questObject[14].SetActive(false);

                    questObject[16].SetActive(false);
                    questObject[17].SetActive(true);


                    questObject[18].SetActive(true);
                }



                else if (questActionIndex == 5)//���� ��
                {
                    questObject[1].SetActive(true);

                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[9].SetActive(true);
                    questObject[8].SetActive(false);

                    questObject[10].SetActive(false);
                    questObject[11].SetActive(true);

                    questObject[13].SetActive(true);
                    questObject[12].SetActive(false);

                    questObject[15].SetActive(true);
                    questObject[14].SetActive(false);

                    questObject[16].SetActive(false);
                    questObject[17].SetActive(true);

                    questObject[18].SetActive(true);


                }

                else if (questActionIndex == 6)//���� �Ʒ�
                {

                    questObject[1].SetActive(true);

                    questObject[7].SetActive(true);
                    questObject[6].SetActive(false);

                    questObject[9].SetActive(true);
                    questObject[8].SetActive(false);

                    questObject[10].SetActive(false);
                    questObject[11].SetActive(true);

                    questObject[13].SetActive(true);
                    questObject[12].SetActive(false);

                    questObject[15].SetActive(true);
                    questObject[14].SetActive(false);

                    questObject[16].SetActive(false);
                    questObject[17].SetActive(true);

                    questObject[18].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(false);//NPC2���� �������� ��!


                }

                else if (questActionIndex == 7)//���� �Ʒ�
                {
                    questObject[1].SetActive(true);//��ǻ�� �ѱ�

                    questObject[7].SetActive(true);//å�� ����Ʈ��
                    questObject[6].SetActive(false);//å�� ����

                    questObject[9].SetActive(true);//���� ���� ����Ʈ��
                    questObject[8].SetActive(false);//���� ����

                    questObject[10].SetActive(false);//���� ����
                    questObject[11].SetActive(true);//���� ����� ����Ʈ��

                    questObject[13].SetActive(true);//�����
                    questObject[12].SetActive(false);//����� ����

                    questObject[15].SetActive(true);//����������
                    questObject[14].SetActive(false);//���������� ����

                    questObject[16].SetActive(false);//����� ����
                    questObject[17].SetActive(true);//�����

                    questObject[18].SetActive(true);//â�� �տ� �ִ� NPC1

                    questObject[4].SetActive(true);//�ڵ� �ǳ�(��ȣŰ)

                    //2023.02.25.�� ����
                    questObject[44].SetActive(false);//NPC2���� �������� ��!

                    questObject[29].SetActive(false);//�絿�� OFF
                }

                break;
                

            case 40:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);//��ǻ�� �ѱ�
                    questObject[7].SetActive(false);//å�� ����Ʈ��
                    questObject[9].SetActive(false);//���� ���� ����Ʈ��
                    questObject[11].SetActive(false);//���� ����� ����Ʈ��
                    questObject[13].SetActive(false);//�����
                    questObject[15].SetActive(false);//����������
                    questObject[17].SetActive(false);//�����


                    questObject[19].SetActive(true);//�м��� ON


                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(false);//NPC2���� �������� ��!
                    questObject[29].SetActive(false);//�絿�� OFF

                }

                else if (questActionIndex == 1)
                {
                    //ù ��° ��ȭ�� ������?


                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(false);//NPC2���� �������� ��!
                    questObject[29].SetActive(false);//�絿�� OFF

                }

                else if (questActionIndex == 2)
                {
                    //�� ��° ��ȭ�� ������?

                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(false);//NPC2���� �������� ��!
                    questObject[29].SetActive(false);//�絿�� OFF

                }

                else if (questActionIndex == 3)
                {
                    //�� ��° ��ȭ�� ������?
                    //NPC2��Ÿ���� [44]�� true��

                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                    questObject[29].SetActive(false);//�絿�� OFF
                }

                else if (questActionIndex == 4)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                    questObject[29].SetActive(true);//�絿�� ��������



                }

                else if (questActionIndex == 5)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 6)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������


                }

                else if (questActionIndex == 7)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������

                }

                else if (questActionIndex == 8)//8��° ��ȭ�� ������?
                {//���� ����Ʈ�� �߱��� ��Ÿ����[108]false�ϰ�
                    //����Ʈ �߱��� [110]true �ϱ�
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);


                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���


                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }
                break;

            case 50:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);


                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 1)//ù ��° ��ȭ�� ������?
                    //�� ��° ���� �����ֱ�-����(����Ʈ)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������


                }

                else if (questActionIndex == 2)//�� ��° ��ȭ�� ������?
                    //�� ��° ����Ʈ ���� �����ֱ� //������
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 3)//�� ��° ��ȭ�� ������?
                {//�� ���� ���� �����ֱ� - ��Ʈ�� ���� �־���
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 4)
                {//�� ��° ��ȭ�� ������?
                    //����� �� �����ֱ�[22] - ���� �־���
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������


                }

                else if (questActionIndex == 5)
                {//�ټ� ��° ��ȭ�� ������?
                    //�� ���ֱ�[22]
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 6)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������


                }

                else if (questActionIndex == 7)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                break;

            case 60:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������

                }

                else if (questActionIndex == 1)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������


                }

                else if (questActionIndex == 2)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������

                }

                else if (questActionIndex == 3)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 4)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������

                }

                else if (questActionIndex == 5)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 6)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 7)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[42].SetActive(false);//������ ���� �ݶ��̴� �����
                    questObject[26].SetActive(true);//������ ���� �ݶ��̴� �����ֱ�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                break;

            case 70:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������

                }

                else if (questActionIndex == 1)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//�м��� ON
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[30].SetActive(true);//�����尩 ON

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������

                }

                else if (questActionIndex == 2)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[30].SetActive(false);//�����尩 OFF

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 3)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF
                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF

                    questObject[20].SetActive(true);//���� ���� ON

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 4)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF
                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[20].SetActive(false);//���� ���� OFF

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                else if (questActionIndex == 5)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.

                    
                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    questObject[27].SetActive(true);//�����ġ ON

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������
                }

                break;

            case 80:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                    //2023.02.25.�� ����
                    questObject[44].SetActive(true);//NPC2��������

                }

                else if (questActionIndex == 1)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����

                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����



                }

                else if (questActionIndex == 2)
                {
                    //�� ��° ���(81)�� ������?
                    //�����ǥ ��Ÿ����

                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��

                    questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 3)
                {
                    //�� ��° ���(82)�� ������?
                    //���� �����ǥ ����

                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 4)
                {
                    //4��° ���(83)�� ������?
                    //�����ǥ ���ֱ�

                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    
                    questObject[58].SetActive(true);//���� �Ӱ� ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 5)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    questObject[58].SetActive(true);//���� �Ӱ� ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 6)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    
                    questObject[58].SetActive(true);//���� �Ӱ� ����

                    questObject[54].SetActive(true);//���� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 7)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����

                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 8)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����


                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    
                    
                    
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(true);//�������� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                break;

            case 90:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(true);//�������� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 1)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 2)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 3)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[52].SetActive(true);//���Ű��� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 4)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[52].SetActive(false);//���Ű��� ���ֱ�

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 5)
                {
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[53].SetActive(true);//���� ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 6)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);



                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[53].SetActive(false);//���� ���ֱ�
                    questObject[50].SetActive(true);//���� ����3 ��Ÿ����

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 7)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[50].SetActive(false);//���� ����3 ���ֱ�

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 8)
                {
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.


                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                break;


            case 100:
                if (questActionIndex == 0)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����



                }

                else if (questActionIndex == 1)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 2)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 3)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 4)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 5)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 6)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 7)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 8)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�
                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 9)//Ȯ���� ���� ��� �ƶ�
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                    questObject[57].SetActive(false);//�����ǥ ���ֱ�

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                break;

            case 110:
                if (questActionIndex == 0)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[5].SetActive(true);//��������2 ����
                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                                                    //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    
                    questObject[93].SetActive(false);//��������1 ������ �� ����
                    
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                /*else if (questActionIndex == 1)//Ȯ���� ���� ��� �ƶ� //���� 100���� ���µ� �ű�
                {
                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                    questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(true);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)
                }*/
                

                else if (questActionIndex == 1)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[5].SetActive(true);//��������2 ����

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                                                    //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�
                    questObject[93].SetActive(false);//��������1 ������ �� ����

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 2)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[5].SetActive(true);//��������2 ����

                    questObject[93].SetActive(false);//��������1 ������ �� ����
                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                                                    //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 3)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[5].SetActive(true);//��������2 ����

                    questObject[93].SetActive(false);//��������1 ������ �� ����
                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                                                    //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 4)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[5].SetActive(true);//��������2 ����

                    questObject[93].SetActive(false);//��������1 ������ �� ����
                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[48].SetActive(true);//���� �� ����
                                                    //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����


                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //������ ON
                    questObject[92].SetActive(true);//������ ON

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 5)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[5].SetActive(true);//��������2 ����

                    questObject[93].SetActive(false);//��������1 ������ �� ����
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF


                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����


                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                    //** ���߽ÿ�! **//

                    //***���⼭ ������ ����� ��.**

                }

                else if (questActionIndex == 6)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[5].SetActive(true);//��������2 ����

                    questObject[93].SetActive(false);//��������1 ������ �� ����
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����

                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�


                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//
                    /*questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true*/

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����



                }

                else if (questActionIndex == 7)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����


                    //**��������1�� �ݱ�**
                    questObject[93].SetActive(true);//��������1 ������ �� �ݱ�
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(true);//ȭ��Ƿ� ���� �� OPEN!

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//

                    questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����




                }

                //�����ִ� 2���� 120�����
                /*else if (questActionIndex == 8)
                {
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                    questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(true);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[2].SetActive(true);//ȭ��Ƿ� ���� �� OPEN!

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//
                    questObject[80].SetActive(true);//Ŀ��Į true

                    questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true


                }

                else if (questActionIndex == 9)
                {
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                    questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                    questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(true);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[2].SetActive(true);//ȭ��Ƿ� ���� �� OPEN!

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//
                    questObject[80].SetActive(false);//Ŀ��Į false

                    questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true


                }*/
                break;

            case 120:
                if (questActionIndex == 0)
                {

                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����

                    //questObject[93].SetActive(true);//��������1 ������ �� ����
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(true);//ȭ��Ƿ� ���� �� OPEN!

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)


                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//
                    questObject[80].SetActive(false);//Ŀ��Į true

                    questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 1)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����

                    questObject[93].SetActive(true);//��������1 ������ �� ����
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(false);//ȭ��Ƿ� ���� �� OPEN!

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//
                    questObject[80].SetActive(true);//Ŀ��Į true

                    questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 2)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����

                    questObject[93].SetActive(true);//��������1 ������ �� ����
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(false);//ȭ��Ƿ� ���� �� OPEN!

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //��������4 ȭ���//
                    questObject[80].SetActive(false);//Ŀ��Į false

                    questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 3)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����
                    questObject[93].SetActive(true);//��������1 ������ �� ����
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.
                                                     //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(false);//ȭ��Ƿ� ���� �� OPEN!
                    questObject[76].SetActive(false);//NPC1 ���ֱ�

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //��������4 ȭ���//
                    questObject[80].SetActive(false);//Ŀ��Į false

                    questObject[81].SetActive(true);//�� ���� ���� true

                    questObject[79].SetActive(true);//���� �� ���� true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 4)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //���� �ƴϱ� ������ �־
                    questObject[45].SetActive(true);//��������3 ����


                    questObject[93].SetActive(true);//��������1 ������ �� ����
                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(false);//ȭ��Ƿ� ���� �� �ݱ�
                    questObject[76].SetActive(false);//NPC1 ���ֱ�

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //��������4 ȭ���//

                    questObject[82].SetActive(true);//�� ���� ���� �ִ� true
                    questObject[81].SetActive(false);//�� ���� ���� false

                    questObject[79].SetActive(true);//���� �� ���� true

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 5)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[93].SetActive(false);//��������1 ������ �� ����
                    //��������2, 3�� ���� �� ����
                    questObject[5].SetActive(true);//��������2 ����
                    questObject[45].SetActive(true);//��������3 ����


                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF
                    questObject[85].SetActive(false);//��������2 ������ �� ����
                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����
                                                     //questObject[45].SetActive(false);//�̰� false�� ��� ǥ���ؾ� ��//�� ��° ������ �̵��ϴ� ����.

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(false);//ȭ��Ƿ� ���� �� CLOSE!

                    questObject[83].SetActive(true);//���� ���� 5 true
                    questObject[76].SetActive(false);//NPC1 ���ֱ�

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(true);//��������4 new�� �����, true

                    //��������4 ȭ���//

                    questObject[82].SetActive(false);//�� ���� ���� �ִ� false

                    questObject[79].SetActive(false);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 6)
                {
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[93].SetActive(false);//��������1 ������ �� ����

                    //��������2, 3�� ���� �� ����
                    questObject[5].SetActive(true);//��������2 ����
                    questObject[45].SetActive(true);//��������3 ����

                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    questObject[85].SetActive(false);//��������2 ������ �� ����


                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(false);//ȭ��Ƿ� ���� �� CLOSE!

                    questObject[83].SetActive(false);//���� ���� 5 false


                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(false);//��������4 new�� �����, false

                    questObject[76].SetActive(false);//NPC1 ���ֱ�

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//

                    questObject[82].SetActive(false);//�� ���� ���� �ִ� false

                    questObject[79].SetActive(false);//���� �� ���� false
                    questObject[95].SetActive(true);//NPC1

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                break;

            case 130:
                if (questActionIndex == 0)
                {
                    //questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    //questObject[95].SetActive(true);//NPC1

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    //questObject[1].SetActive(true);
                    //questObject[6].SetActive(true);
                    //questObject[8].SetActive(true);
                    //questObject[10].SetActive(true);
                    //questObject[12].SetActive(true);
                    //questObject[14].SetActive(true);
                    //questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    //questObject[108].SetActive(false);//����Ʈ ��
                    //questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    //questObject[107].SetActive(false);//����Ʈ ��
                    //questObject[109].SetActive(true);//����Ʈ ����


                    //***���~
                    //��������1 ������
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[93].SetActive(false);//��������1 ������ �� ����

                    //��������2, 3�� ���� �� ����
                    questObject[5].SetActive(true);//��������2 ����
                    questObject[45].SetActive(true);//��������3 ����

                    //��������2 ����
                    questObject[29].SetActive(false);//�絿�� OFF

                    questObject[24].SetActive(true);//���� ������ ����
                    questObject[23].SetActive(true);//Ǫ�� ������ ����
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//����Ʈ �� ���ֱ� //���� �ִ� �Ŷ� ��� false ����� ��.


                    questObject[43].SetActive(true);//���ο� ��Ʈ ����
                    questObject[21].SetActive(true);//���� ������ �� ����
                    questObject[31].SetActive(true);//�� ������ ���� ����

                    questObject[35].SetActive(false);//���� ķ��ī ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[41].SetActive(true);//���ο� ķ��ī ����

                    questObject[36].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[40].SetActive(true);//���ο� å�� ����(���� ����)

                    questObject[34].SetActive(false);//���� ĳ��� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[38].SetActive(true);//���ο� ĳ��� ����(���� ����)

                    questObject[37].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[39].SetActive(true);//���ο� å�� ����(�Ķ� ����)

                    questObject[33].SetActive(false);//���� å�� ���ְ� //���� �ִ� �Ŷ� ��� false ����� ��.
                    questObject[32].SetActive(true);//���ο� å�� ����(�¾� å)

                    questObject[28].SetActive(true);//������ ����ġ ON
                    questObject[59].SetActive(false);//����ġ OFF
                    questObject[19].SetActive(false);//�м� �ݶ��̴� OFF

                    questObject[85].SetActive(false);//��������2 ������ �� ����


                    //��������1, 3����//
                    questObject[18].SetActive(false);//NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[44].SetActive(false);//NPC2���ֱ�, ��� false���� ����

                    //questObject[57].SetActive(true);//�����ǥ ��Ÿ����

                    questObject[57].SetActive(false);//�����ǥ ���ֱ�
                    questObject[58].SetActive(true);//���� �Ӱ� ����
                    questObject[54].SetActive(true);//���� ��Ÿ����
                    questObject[55].SetActive(true);//����Ʈ�� ��Ÿ����
                    questObject[51].SetActive(false);//�������� ��Ÿ����
                    questObject[56].SetActive(true);//���� ��Ÿ����
                    questObject[48].SetActive(false);//���� �� ����
                    questObject[49].SetActive(false);//������ �� ���ֱ�

                    //**��������4���� ����Ǵ� �͵�**
                    questObject[46].SetActive(false);//��������3 NPC1�ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[47].SetActive(false);//��������3 NPC2���ֱ�, ��� false���� ����

                    //��������4 ���� true, false
                    questObject[69].SetActive(true);//�޷� true�� (��� true �������)
                    questObject[68].SetActive(false);//�ƹ��͵� ���� å��  false�� (��� false �������)

                    questObject[77].SetActive(true);//â�� �� ���� true�� (��� true �������)

                    questObject[67].SetActive(true);//���� �ִ� ���� true�� (��� true �������)
                    questObject[66].SetActive(false);//�ƹ��͵� ���� ����  false�� (��� false �������)

                    questObject[73].SetActive(true);//���� �ִ� ���������� true�� (��� true �������)
                    questObject[72].SetActive(false);//�ƹ��͵� ���� ����������  false�� (��� false �������)

                    questObject[63].SetActive(true);//�� �ִ� ��Ź�� true�� (��� true �������)
                    questObject[62].SetActive(false);//��Ź��  false�� (��� false �������)

                    questObject[71].SetActive(true);//���� ��Ʈ�� true�� (��� true �������)
                    questObject[70].SetActive(false);//���� ��Ʈ��  false�� (��� false �������)

                    questObject[78].SetActive(true);//����Ʈ�� true�� (��� true �������)

                    questObject[65].SetActive(true);//Ŀ��Į �ִ� å�� true�� (��� true �������)
                    questObject[64].SetActive(false);//å��  false�� (��� false �������)

                    questObject[88].SetActive(true);//�� ���� �� true�� (��� true �������)
                    questObject[87].SetActive(false);//�� ���� ���� ��  false�� (��� false �������)

                    //questObject[84].SetActive(true);//��������1 ȭ��ǹ� �� true�� (��� true �������)
                    questObject[94].SetActive(false);//ȭ��Ƿ� ���� �� CLOSE!

                    questObject[83].SetActive(false);//���� ���� 5 false


                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[86].SetActive(false);//��������4 new�� �����, false

                    questObject[76].SetActive(false);//NPC1 ���ֱ�

                    //����Ʈ�� ���þ��� ���� ����, �����

                    questObject[89].SetActive(true);//����Ʈ �� ���� true�� (��� true �������)
                    questObject[90].SetActive(false);//����  false�� (��� false �������)

                    questObject[61].SetActive(true);//����Ʈ �� ħ�� true�� (��� true �������)
                    questObject[60].SetActive(false);//ħ��  false�� (��� false �������)

                    questObject[75].SetActive(true);// ����Ʈ �� ����� true�� (��� true �������)
                    questObject[74].SetActive(false);//�����  false�� (��� false �������)

                    //��������4 ȭ���//

                    questObject[82].SetActive(false);//�� ���� ���� �ִ� false

                    questObject[79].SetActive(false);//���� �� ���� false
                    questObject[95].SetActive(true);//NPC1

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 1)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(true);//��1

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 2)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//��1
                    questObject[98].SetActive(true);//��1, 2

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 3)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//��1
                    questObject[98].SetActive(true);//��1, 2

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 4)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//��1
                    questObject[99].SetActive(true);//��1, 2, 3
                    questObject[98].SetActive(false);//��1, 2

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 5)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//��1
                    questObject[100].SetActive(true);//��1, 2, 3, 4
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 6)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 7)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[103].SetActive(true);//������
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 8)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 9)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                break;

            case 140:
                if (questActionIndex == 0)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����



                }

                else if (questActionIndex == 1)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4

                    questObject[102].SetActive(true);//��

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����


                }

                else if (questActionIndex == 2)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4
                    questObject[102].SetActive(true);//��

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 3)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4
                    questObject[102].SetActive(true);//��

                    questObject[104].SetActive(true);//���� �б��� ������

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                else if (questActionIndex == 4)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4
                    questObject[102].SetActive(true);//��

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����

                }

                else if (questActionIndex == 5)
                {
                    questObject[91].SetActive(false);//��������4 ���ε� ���� true���¿��� ��� false���¸� �Է��� ��� ��.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//������
                    questObject[97].SetActive(false);//��1
                    questObject[101].SetActive(true);//��1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//��1, 2
                    questObject[99].SetActive(false);//��1, 2, 3
                    questObject[100].SetActive(false);//��1, 2, 3, 4
                    questObject[102].SetActive(true);//��

                    questObject[105].SetActive(true);//Ʈ�翣������ ���� �ݶ��̴�

                    //��������1 ������ (������ ���� �߰��� - 2023.02.25.��)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.�� //�߱��� ����
                    questObject[108].SetActive(false);//����Ʈ ��
                    questObject[110].SetActive(true);//����Ʈ �߱���

                    //2023.02.25.�� //���� ����
                    questObject[107].SetActive(false);//����Ʈ ��
                    questObject[109].SetActive(true);//����Ʈ ����
                }

                break;
        }


    }
}
