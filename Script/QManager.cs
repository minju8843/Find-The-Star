using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;//퀘스트에 관련된 다른 npc가 있는 경우
    public GameObject[] questObject;

    Dictionary<int, QuestData> questiList;

    void Awake()
    {
        questiList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    void GenerateData()
    {
        //컴퓨터 열기
        //별의 조각에 대한 이야기 듣기
        //화장실 문 열기
        //개발되지 않은 구역 문 열기


        
        questiList.Add(10, new QuestData("컴퓨터 전원 켜기", new int[] { 200, 35000, 7900, 73000, 37000, 1600}));

        questiList.Add(20, new QuestData("화잘실 가서 별 조각 전달하기", new int[] { 73000, 34000, 39000, 2700, 7900, 44000}));

        questiList.Add(30, new QuestData("냉장고하고 문 확인", new int[] { 400, 1000, 900, 1200, 1300,1100, 44000 }));//1개 추가

        //questiList.Add(90, new QuestData("별 완전체", new int[] { 3100 }));//선택지 되나 시험중
        //선택지 잘 됨! 야호!

        //questiList.Add(100, new QuestData("퀘스트 올 클리어", new int[] { 0 }));

        questiList.Add(40, new QuestData("타임캡슐 비석에 물 붓기", new int[] { 2900, 3100, 4600, 7500, 6000, 55000, 2900, 3100 }));

        questiList.Add(50, new QuestData("야구장과 버스와 관람차와 텐트로 돌 옮기고 쪽지 확인", new int[] { 57000, 58000, 59000, 4100, 6100, 4100, 61000 }));

        questiList.Add(60, new QuestData("보라색 쪽지 조사 후 친구한테 과거 이야기 듣기", new int[] { 62000, 63000, 64000, 65000, 7500, 66000, 7500 }));

        questiList.Add(70, new QuestData("스위치 켜서 별 조각 얻고 문 열기", new int[] { 5900, 4500, 5900, 6300, 4600 }));

        //questiList.Add(80, new QuestData("퀘스트 올 클리어", new int[] { 0 }));

        questiList.Add(80, new QuestData("기억해내기", new int[] { 9500, 4200, 46000, 6600, 49000, 4300, 51000, 52000 }));

        questiList.Add(90, new QuestData("기억에 대한 단서를 얻은 후, 열쇠 얻기", new int[] { 7000, 56000, 4200, 7200, 4200, 5300, 9900, 9500 }));

        questiList.Add(100, new QuestData("액자 확인하며 기억찾고 노트북 확인", new int[] { 10000, 11000, 12000, 13000, 14000, 15000, 16000, 17000, 48000 }));//원래 18000 있었는데 잠시 110대로 옮김

        questiList.Add(110, new QuestData("스마트폰하고 NPC1하고 얘기하고 욕실가기", new int[] { 19000, 20000, 11000, 11000, 11000, 22000, 73000}));//원래 23000, 24000 있었는데 120번대로 옮김

        questiList.Add(120, new QuestData("욕실가고 별의 조각 다 얻고 문 열기", new int[] { 23000, 24000 , 25000, 25000, 26000, 27000}));

        questiList.Add(130, new QuestData("제단에 별 올리기", new int[] { 47000, 47000, 47000, 47000, 47000, 47000, 42000, 42000, 43000 }));

        questiList.Add(140, new QuestData("제단에 별 올리기", new int[] { 43000, 43000, 43000, 43000, 53000 }));

        questiList.Add(150, new QuestData("퀘스트 올 클리어", new int[] { 0 }));

    }
    public int GetQuestTalkIndex(int id)//NPC ID를 받고 퀘스트번호를 반환하는 함수
    {
        return questId + questActionIndex;//퀘스트 번호+퀘스트 대화순서=퀘스트 대화Id
    }
    public string CheckQuest(int id)//두 번째 npc의 퀘스트 대화
    {
        //Next Talk Target
        if (id == questiList[questId].npcId[questActionIndex])
            questActionIndex++;//진행을 위해 퀘스트 대화순서를 올리는 함수

        //Control Quest Object
        ControlObject();

        //Talk Complete & Next Quest
        //순서에 맞게 대화했을 때만 퀘스트 대화순서 올라감
        if (questActionIndex == questiList[questId].npcId.Length)
            NextQuest();
        //퀘스트 대화 순서가 끝에 도달했을 때 퀘스트 번호 증가

        //Quest Name
        return questiList[questId].questName;
        //퀘스트 이름을 콘솔(console)에서 반환하도록
    }

    public string CheckQuest()//두 번째 npc의 퀘스트 대화
    {
        //Quest Name
        return questiList[questId].questName;
        //퀘스트 이름을 콘솔(console)에서 반환하도록
    }

    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;
    }

    //퀘스트 오브젝트를 관리할 함수 생성
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

                //아니면 지우기?
                else if (questActionIndex == 6) //40-0:열쇠다. 줍자. //열쇠 사라짐
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    //questObject[2].SetActive(false);
                    //questObject[2].SetActive(true);//아니면 지우기
                    //questObject[3].SetActive(false);

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                


                /*else if (questActionIndex == 7)//41-문이다 열렸다.
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(true);
                    //questObject[4].SetActive(true);//얜가?

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }*/

                break;
            case 20://41:열쇠 생성

                //이건 아니면 지우기
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(false);
                    //questObject[4].SetActive(true);//얜가?

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);
                }

                else if (questActionIndex == 1)//41-문이다 열렸다.
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(true);
                    //questObject[4].SetActive(true);//얜가?

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

                else if (questActionIndex == 1) //40-0:열쇠다. 줍자. //열쇠 사라짐
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

                    


                else if (questActionIndex == 2)//41-문이다 열렸다.
                {
                    questObject[1].SetActive(true);
                    questObject[0].SetActive(false);
                    questObject[2].SetActive(true);
                    //questObject[4].SetActive(true);//얜가?

                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);
                    questObject[18].SetActive(true);

                }*/

                //break;


                /*case 50://세수하기
                    if (questActionIndex == 0)
                    {
                        //questObject[4].SetActive(true);//얜가?
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
                    //questObject[4].SetActive(true);//얜가?
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
                    //questObject[4].SetActive(true);//얜가?
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

            /*case 60://61:별의 조각 생성
                if (questActionIndex == 0)
                {
                    //questObject[4].SetActive(true);//얜가?
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

                else if (questActionIndex == 4) //별의 조각 줍기//별의 조각 사라짐
                {
                    //questObject[4].SetActive(true);//얜가?
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




                else if (questActionIndex == 5)//41-문이다 열렸다.
                {
                    //questObject[4].SetActive(true);//얜가?
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





            /*case 30://2스테이지로 가는 문 확인
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);
                    questObject[2].SetActive(false);
                    //questObject[3].SetActive(true);//얜가?
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

            case 30://문을 열기 위한 노력들
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

                else if (questActionIndex == 1)//책장
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
                    
                

                else if (questActionIndex == 2)//가스레인지
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

                else if (questActionIndex == 3)//개수대
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

                else if (questActionIndex == 4)//냉장고
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



                else if (questActionIndex == 5)//의자 위
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

                else if (questActionIndex == 6)//의자 아래
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

                    //2023.02.25.토 수정
                    questObject[44].SetActive(false);//NPC2아직 보여주지 마!


                }

                else if (questActionIndex == 7)//의자 아래
                {
                    questObject[1].SetActive(true);//컴퓨터 켜기

                    questObject[7].SetActive(true);//책장 포스트잇
                    questObject[6].SetActive(false);//책장 낫띵

                    questObject[9].SetActive(true);//의자 앞통 포스트잇
                    questObject[8].SetActive(false);//의자 앞통

                    questObject[10].SetActive(false);//의자 뒷통
                    questObject[11].SetActive(true);//의자 뒷통수 포스트잇

                    questObject[13].SetActive(true);//세면대
                    questObject[12].SetActive(false);//세면대 낫띵

                    questObject[15].SetActive(true);//가스레인지
                    questObject[14].SetActive(false);//가스레인지 낫띵

                    questObject[16].SetActive(false);//냉장고 낫띵
                    questObject[17].SetActive(true);//냉장고

                    questObject[18].SetActive(true);//창문 앞에 있는 NPC1

                    questObject[4].SetActive(true);//코드 판넬(번호키)

                    //2023.02.25.토 수정
                    questObject[44].SetActive(false);//NPC2아직 보여주지 마!

                    questObject[29].SetActive(false);//양동이 OFF
                }

                break;
                

            case 40:
                if (questActionIndex == 0)
                {
                    questObject[1].SetActive(true);//컴퓨터 켜기
                    questObject[7].SetActive(false);//책장 포스트잇
                    questObject[9].SetActive(false);//의자 앞통 포스트잇
                    questObject[11].SetActive(false);//의자 뒷통수 포스트잇
                    questObject[13].SetActive(false);//세면대
                    questObject[15].SetActive(false);//가스레인지
                    questObject[17].SetActive(false);//냉장고


                    questObject[19].SetActive(true);//분수대 ON


                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(false);//NPC2아직 보여주지 마!
                    questObject[29].SetActive(false);//양동이 OFF

                }

                else if (questActionIndex == 1)
                {
                    //첫 번째 대화가 끝나면?


                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(false);//NPC2아직 보여주지 마!
                    questObject[29].SetActive(false);//양동이 OFF

                }

                else if (questActionIndex == 2)
                {
                    //두 번째 대화가 끝나면?

                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(false);//NPC2아직 보여주지 마!
                    questObject[29].SetActive(false);//양동이 OFF

                }

                else if (questActionIndex == 3)
                {
                    //세 번째 대화가 끝나면?
                    //NPC2나타내기 [44]를 true로

                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
                    questObject[29].SetActive(false);//양동이 OFF
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
                    questObject[29].SetActive(true);//양동이 보여주장



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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장


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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장

                }

                else if (questActionIndex == 8)//8번째 대화가 끝나면?
                {//다음 퀘스트인 야구장 나타내기[108]false하고
                    //퀘스트 야구장 [110]true 하기
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);


                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장


                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);


                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
                }

                else if (questActionIndex == 1)//첫 번째 대화가 끝나면?
                    //두 번째 물건 보여주기-버스(퀘스트)
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장


                }

                else if (questActionIndex == 2)//두 번째 대화가 끝나면?
                    //세 번째 퀘스트 물건 보여주기 //관람차
                {
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
                }

                else if (questActionIndex == 3)//세 번째 대화가 끝나면?
                {//네 번재 물건 보여주기 - 텐트는 원래 있었음
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
                }

                else if (questActionIndex == 4)
                {//네 번째 대화가 끝나면?
                    //사라질 돌 보여주기[22] - 원래 있었음
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장


                }

                else if (questActionIndex == 5)
                {//다섯 번째 대화가 끝나면?
                    //돌 없애기[22]
                    questObject[1].SetActive(true);
                    questObject[7].SetActive(false);
                    questObject[9].SetActive(false);
                    questObject[11].SetActive(false);
                    questObject[13].SetActive(false);
                    questObject[15].SetActive(false);
                    questObject[17].SetActive(false);

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장


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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장

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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장


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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장

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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장

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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[42].SetActive(false);//관람차 이전 콜라이더 지우기
                    questObject[26].SetActive(true);//관람차 이후 콜라이더 보여주기

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장

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

                    questObject[19].SetActive(true);//분수대 ON
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[30].SetActive(true);//절연장갑 ON

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장

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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[30].SetActive(false);//절연장갑 OFF

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[19].SetActive(false);//분수 콜라이더 OFF
                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF

                    questObject[20].SetActive(true);//별의 조각 ON

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[19].SetActive(false);//분수 콜라이더 OFF
                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[20].SetActive(false);//별의 조각 OFF

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.

                    
                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    questObject[27].SetActive(true);//잠금장치 ON

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                    //2023.02.25.토 수정
                    questObject[44].SetActive(true);//NPC2보여주장

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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘

                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스



                }

                else if (questActionIndex == 2)
                {
                    //두 번째 대사(81)가 끝나면?
                    //비행기표 나타내기

                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함

                    questObject[57].SetActive(true);//비행기표 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 3)
                {
                    //세 번째 대사(82)가 끝나면?
                    //아직 비행기표 유지

                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(true);//비행기표 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 4)
                {
                    //4번째 대사(83)가 끝나면?
                    //비행기표 없애기

                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    
                    questObject[57].SetActive(false);//비행기표 없애기
                    
                    questObject[58].SetActive(true);//의자 붉게 변함

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[57].SetActive(false);//비행기표 없애기

                    questObject[58].SetActive(true);//의자 붉게 변함

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    
                    questObject[57].SetActive(false);//비행기표 없애기
                    
                    questObject[58].SetActive(true);//의자 붉게 변함

                    questObject[54].SetActive(true);//가방 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                                                     //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기

                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기

                    questObject[55].SetActive(true);//스마트폰 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                                                     //questObject[57].SetActive(true);//비행기표 나타내기


                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    
                    
                    
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(true);//구명조끼 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(true);//구명조끼 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[52].SetActive(true);//정신과약 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[52].SetActive(false);//정신과약 없애기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
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

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[53].SetActive(true);//열쇠 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 6)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);



                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[53].SetActive(false);//열쇠 없애기
                    questObject[50].SetActive(true);//별의 조각3 나타내기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 7)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[50].SetActive(false);//별의 조각3 없애기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 8)
                {
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.


                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                break;


            case 100:
                if (questActionIndex == 0)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스



                }

                else if (questActionIndex == 1)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 2)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 3)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 4)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 5)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 6)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 7)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 8)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기
                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 9)//확인을 위해 잠깐 컷뜨
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                    questObject[57].SetActive(false);//비행기표 없애기

                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                break;

            case 110:
                if (questActionIndex == 0)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ
                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                                                    //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                    //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 열림
                    
                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림
                    
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                /*else if (questActionIndex == 1)//확인을 위해 잠깐 컷뜨 //원래 100번대 였는데 옮김
                {
                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                    questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(true);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)
                }*/
                

                else if (questActionIndex == 1)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                                                    //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                    //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기
                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 2)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림
                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                                                    //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 3)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림
                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                                                    //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                    //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 4)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림
                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[48].SetActive(true);//왼쪽 문 닫힘
                                                    //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                    //questObject[57].SetActive(true);//비행기표 나타내기


                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //선택지 ON
                    questObject[92].SetActive(true);//선택지 ON

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 5)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF


                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                     //questObject[57].SetActive(true);//비행기표 나타내기


                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                    //** 멈추시오! **//

                    //***여기서 선택지 띄워야 함.**

                }

                else if (questActionIndex == 6)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                     //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기

                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기


                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//
                    /*questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true*/

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스



                }

                else if (questActionIndex == 7)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ


                    //**스테이지1문 닫기**
                    questObject[93].SetActive(true);//스테이지1 오른쪽 문 닫기
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                     //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(true);//화장실로 가는 문 OPEN!

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//

                    questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스




                }

                //여기있는 2개는 120번대로
                /*else if (questActionIndex == 8)
                {
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                    questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(true);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[2].SetActive(true);//화장실로 가는 문 OPEN!

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//
                    questObject[80].SetActive(true);//커터칼 true

                    questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true


                }

                else if (questActionIndex == 9)
                {
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                    questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                    questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(true);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[2].SetActive(true);//화장실로 가는 문 OPEN!

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//
                    questObject[80].SetActive(false);//커터칼 false

                    questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true


                }*/
                break;

            case 120:
                if (questActionIndex == 0)
                {

                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ

                    //questObject[93].SetActive(true);//스테이지1 오른쪽 문 열림
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                     //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(true);//화장실로 가는 문 OPEN!

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)


                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//
                    questObject[80].SetActive(false);//커터칼 true

                    questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 1)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ

                    questObject[93].SetActive(true);//스테이지1 오른쪽 문 닫힘
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                     //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(false);//화장실로 가는 문 OPEN!

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//
                    questObject[80].SetActive(true);//커터칼 true

                    questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 2)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ

                    questObject[93].SetActive(true);//스테이지1 오른쪽 문 닫힘
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                     //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(false);//화장실로 가는 문 OPEN!

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //스테이지4 화장실//
                    questObject[80].SetActive(false);//커터칼 false

                    questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 3)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ
                    questObject[93].SetActive(true);//스테이지1 오른쪽 문 닫힘
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.
                                                     //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(false);//화장실로 가는 문 OPEN!
                    questObject[76].SetActive(false);//NPC1 없애기

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //스테이지4 화장실//
                    questObject[80].SetActive(false);//커터칼 false

                    questObject[81].SetActive(true);//피 만땅 욕조 true

                    questObject[79].SetActive(true);//변기 위 사진 true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 4)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //여긴 아니긴 하지만 넣어봄
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ


                    questObject[93].SetActive(true);//스테이지1 오른쪽 문 닫힘
                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(false);//화장실로 가는 문 닫기
                    questObject[76].SetActive(false);//NPC1 없애기

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //스테이지4 화장실//

                    questObject[82].SetActive(true);//피 만땅 욕조 애니 true
                    questObject[81].SetActive(false);//피 만땅 욕조 false

                    questObject[79].SetActive(true);//변기 위 사진 true

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 5)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림
                    //스테이지2, 3로 가는 문 열기
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ


                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF
                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘
                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지
                                                     //questObject[45].SetActive(false);//이건 false면 계속 표시해야 함//두 번째 씬으로 이동하는 거임.

                    questObject[57].SetActive(false);//비행기표 없애기
                    //questObject[57].SetActive(true);//비행기표 나타내기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(false);//화장실로 가는 문 CLOSE!

                    questObject[83].SetActive(true);//별의 조각 5 true
                    questObject[76].SetActive(false);//NPC1 없애기

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(true);//스테이지4 new문 생기기, true

                    //스테이지4 화장실//

                    questObject[82].SetActive(false);//피 만땅 욕조 애니 false

                    questObject[79].SetActive(false);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 6)
                {
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림

                    //스테이지2, 3로 가는 문 열기
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ

                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘


                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지

                    //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(false);//화장실로 가는 문 CLOSE!

                    questObject[83].SetActive(false);//별의 조각 5 false


                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(false);//스테이지4 new문 생기기, false

                    questObject[76].SetActive(false);//NPC1 없애기

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//

                    questObject[82].SetActive(false);//피 만땅 욕조 애니 false

                    questObject[79].SetActive(false);//변기 위 사진 false
                    questObject[95].SetActive(true);//NPC1

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                break;

            case 130:
                if (questActionIndex == 0)
                {
                    //questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    //questObject[95].SetActive(true);//NPC1

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    //questObject[1].SetActive(true);
                    //questObject[6].SetActive(true);
                    //questObject[8].SetActive(true);
                    //questObject[10].SetActive(true);
                    //questObject[12].SetActive(true);
                    //questObject[14].SetActive(true);
                    //questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    //questObject[108].SetActive(false);//퀘스트 전
                    //questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    //questObject[107].SetActive(false);//퀘스트 전
                    //questObject[109].SetActive(true);//퀘스트 버스


                    //***잠깐만~
                    //스테이지1 가구들
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    questObject[93].SetActive(false);//스테이지1 오른쪽 문 열림

                    //스테이지2, 3로 가는 문 열기
                    questObject[5].SetActive(true);//스테이지2 ㄱㄱ
                    questObject[45].SetActive(true);//스테이지3 ㄱㄱ

                    //스테이지2 적용
                    questObject[29].SetActive(false);//양동이 OFF

                    questObject[24].SetActive(true);//붉은 비석으로 변신
                    questObject[23].SetActive(true);//푸른 비석으로 변신
                    questObject[25].SetActive(false);

                    questObject[22].SetActive(false);//퀘스트 돌 없애기 //원래 있던 거라 계속 false 해줘야 함.


                    questObject[43].SetActive(true);//새로운 텐트 생성
                    questObject[21].SetActive(true);//돌을 놨으니 돌 생성
                    questObject[31].SetActive(true);//돌 놨으니 쪽지 생성

                    questObject[35].SetActive(false);//기존 캠핑카 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[41].SetActive(true);//새로운 캠핑카 생성

                    questObject[36].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[40].SetActive(true);//새로운 책상 생성(보라 쪽지)

                    questObject[34].SetActive(false);//기존 캐라반 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[38].SetActive(true);//새로운 캐라반 생성(보라 쪽지)

                    questObject[37].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[39].SetActive(true);//새로운 책상 생성(파랑 쪽지)

                    questObject[33].SetActive(false);//기존 책상 없애고 //원래 있던 거라 계속 false 해줘야 함.
                    questObject[32].SetActive(true);//새로운 책상 생성(태양 책)

                    questObject[28].SetActive(true);//망가진 스위치 ON
                    questObject[59].SetActive(false);//스위치 OFF
                    questObject[19].SetActive(false);//분수 콜라이더 OFF

                    questObject[85].SetActive(false);//스테이지2 오른쪽 문 닫힘


                    //스테이지1, 3적용//
                    questObject[18].SetActive(false);//NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[44].SetActive(false);//NPC2없애기, 계속 false상태 유지

                    //questObject[57].SetActive(true);//비행기표 나타내기

                    questObject[57].SetActive(false);//비행기표 없애기
                    questObject[58].SetActive(true);//의자 붉게 변함
                    questObject[54].SetActive(true);//가방 나타내기
                    questObject[55].SetActive(true);//스마트폰 나타내기
                    questObject[51].SetActive(false);//구명조끼 나타내기
                    questObject[56].SetActive(true);//라디오 나타내기
                    questObject[48].SetActive(false);//왼쪽 문 닫힘
                    questObject[49].SetActive(false);//오른쪽 문 없애기

                    //**스테이지4부터 적용되는 것들**
                    questObject[46].SetActive(false);//스테이지3 NPC1인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[47].SetActive(false);//스테이지3 NPC2없애기, 계속 false상태 유지

                    //스테이지4 가구 true, false
                    questObject[69].SetActive(true);//달력 true로 (계속 true 해줘야함)
                    questObject[68].SetActive(false);//아무것도 없는 책상  false로 (계속 false 해줘야함)

                    questObject[77].SetActive(true);//창문 앞 액자 true로 (계속 true 해줘야함)

                    questObject[67].SetActive(true);//액자 있는 의자 true로 (계속 true 해줘야함)
                    questObject[66].SetActive(false);//아무것도 없는 의자  false로 (계속 false 해줘야함)

                    questObject[73].SetActive(true);//액자 있는 가스레인지 true로 (계속 true 해줘야함)
                    questObject[72].SetActive(false);//아무것도 없는 가스레인지  false로 (계속 false 해줘야함)

                    questObject[63].SetActive(true);//옷 있는 세탁기 true로 (계속 true 해줘야함)
                    questObject[62].SetActive(false);//세탁기  false로 (계속 false 해줘야함)

                    questObject[71].SetActive(true);//켜진 노트북 true로 (계속 true 해줘야함)
                    questObject[70].SetActive(false);//꺼진 노트북  false로 (계속 false 해줘야함)

                    questObject[78].SetActive(true);//스마트폰 true로 (계속 true 해줘야함)

                    questObject[65].SetActive(true);//커터칼 있는 책상 true로 (계속 true 해줘야함)
                    questObject[64].SetActive(false);//책상  false로 (계속 false 해줘야함)

                    questObject[88].SetActive(true);//피 묻은 문 true로 (계속 true 해줘야함)
                    questObject[87].SetActive(false);//피 묻지 않은 문  false로 (계속 false 해줘야함)

                    //questObject[84].SetActive(true);//스테이지1 화장실문 피 true로 (계속 true 해줘야함)
                    questObject[94].SetActive(false);//화장실로 가는 문 CLOSE!

                    questObject[83].SetActive(false);//별의 조각 5 false


                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[86].SetActive(false);//스테이지4 new문 생기기, false

                    questObject[76].SetActive(false);//NPC1 없애기

                    //퀘스트와 관련없는 가구 생성, 지우기

                    questObject[89].SetActive(true);//퀘스트 후 옷장 true로 (계속 true 해줘야함)
                    questObject[90].SetActive(false);//옷장  false로 (계속 false 해줘야함)

                    questObject[61].SetActive(true);//퀘스트 후 침대 true로 (계속 true 해줘야함)
                    questObject[60].SetActive(false);//침대  false로 (계속 false 해줘야함)

                    questObject[75].SetActive(true);// 퀘스트 후 냉장고 true로 (계속 true 해줘야함)
                    questObject[74].SetActive(false);//냉장고  false로 (계속 false 해줘야함)

                    //스테이지4 화장실//

                    questObject[82].SetActive(false);//피 만땅 욕조 애니 false

                    questObject[79].SetActive(false);//변기 위 사진 false
                    questObject[95].SetActive(true);//NPC1

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 1)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(true);//별1

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 2)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//별1
                    questObject[98].SetActive(true);//별1, 2

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 3)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//별1
                    questObject[98].SetActive(true);//별1, 2

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 4)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//별1
                    questObject[99].SetActive(true);//별1, 2, 3
                    questObject[98].SetActive(false);//별1, 2

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 5)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//별1
                    questObject[100].SetActive(true);//별1, 2, 3, 4
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 6)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 7)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(true);//NPC1
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[103].SetActive(true);//선택지
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 8)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 9)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                break;

            case 140:
                if (questActionIndex == 0)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스



                }

                else if (questActionIndex == 1)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4

                    questObject[102].SetActive(true);//문

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스


                }

                else if (questActionIndex == 2)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4
                    questObject[102].SetActive(true);//문

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 3)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4
                    questObject[102].SetActive(true);//문

                    questObject[104].SetActive(true);//엔딩 분기점 선택지

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                else if (questActionIndex == 4)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4
                    questObject[102].SetActive(true);//문

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스

                }

                else if (questActionIndex == 5)
                {
                    questObject[91].SetActive(false);//스테이지4 문인데 원래 true상태여서 계속 false상태를 입력해 줘야 함.
                    questObject[95].SetActive(false);//NPC1
                    questObject[96].SetActive(true);//선진이
                    questObject[97].SetActive(false);//별1
                    questObject[101].SetActive(true);//별1, 2, 3, 4, 5
                    questObject[98].SetActive(false);//별1, 2
                    questObject[99].SetActive(false);//별1, 2, 3
                    questObject[100].SetActive(false);//별1, 2, 3, 4
                    questObject[102].SetActive(true);//문

                    questObject[105].SetActive(true);//트루엔딩으로 가는 콜라이더

                    //스테이지1 가구들 (오류로 인해 추가함 - 2023.02.25.토)
                    questObject[1].SetActive(true);
                    questObject[6].SetActive(true);
                    questObject[8].SetActive(true);
                    questObject[10].SetActive(true);
                    questObject[12].SetActive(true);
                    questObject[14].SetActive(true);
                    questObject[16].SetActive(true);

                    //2023.02.25.토 //야구장 수정
                    questObject[108].SetActive(false);//퀘스트 전
                    questObject[110].SetActive(true);//퀘스트 야구장

                    //2023.02.25.토 //버스 수정
                    questObject[107].SetActive(false);//퀘스트 전
                    questObject[109].SetActive(true);//퀘스트 버스
                }

                break;
        }


    }
}
