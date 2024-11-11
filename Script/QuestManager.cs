using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestManager : MonoBehaviour
{


    public int questId; //현재 진행중인 퀘스트 id
    public int questActionIndex;//퀘스트 대화순서 변수 생성

    //public GameObject[] questoOject=;

    public GameObject[] questObject;//퀘스트 오브젝트를 저장할 변수 생성(내 게임에선 열쇠같은거)

    Dictionary<int, QuestData> questList;//퀘스트 데이터를 저장할 딕셔너리 변수 생성

    //static public QuestManager instance;

   

    void Awake()
    {
        //questObject = GameObject.FindGameObjectsWithTag("Item");
        //DontDestroyOnLoad(this.gameObject);


        //DontDestroyOnLoad(this.gameObject);//얜 원래 있었음
        //questObject = GameObject.FindGameObjectsWithTag("Item");
        questList = new Dictionary<int, QuestData>();//맵 안되면 다시 살리기
        GenerateData();//맵 안되면 다시 살리기
        



        //DontDestroyOnLoad(this.gameObject);

        //questList = new Dictionary<int, QuestData>();//맵 안되면 다시 살리기
        //GenerateData();//맵 안되면 다시 살리기

        //questList = new Dictionary<int, QuestData>();//맵 안되면 다시 살리기
        //GenerateData();//맵 안되면 다시 살리기

        /*if(instance==null)
        {

            DontDestroyOnLoad(this.gameObject);
            questList = new Dictionary<int, QuestData>();//맵 안되면 다시 살리기
            GenerateData();//맵 안되면 다시 살리기
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
            DontDestroyOnLoad(this.gameObject); // 게임 오브젝트 파괴금지
            questList = new Dictionary<int, QuestData>();//맵 안되면 다시 살리기
            GenerateData();//맵 안되면 다시 살리기

            instance = this;
        }
        else
        {
            Destroy(this.gameObject);

        }*/








    }





    void GenerateData()
    {

        questList.Add(10, new QuestData("별의 조각에 대한 정보 듣기", new int[] {500, 10000 }));//Add함수로 QuestId, QuestData데이터를 저장
        //questList.Add(10, new QuestData("퀘스트 이름", new int[해당 퀘스트와 연관된 Id 압력] { })

        questList.Add(20, new QuestData("열쇠 찾기", new int[] {100, 700}));

        questList.Add(30, new QuestData("열쇠로 문 열기", new int[] { 1600, 100 }));

        questList.Add(40, new QuestData("노트북 관찰하기", new int[] { 200}));

       // questList.Add(50, new QuestData("노트북 켜기", new int[] { 200 }));

        questList.Add(50, new QuestData("문하고 책장 조사", new int[] { 1500, 400}));


        questList.Add(60, new QuestData("냉장고 조사후 문 다시 확인하기", new int[] { 1200, 400 }));

        questList.Add(70, new QuestData("올 클리어", new int[] { 0 }));

    }

    public int GetQuestTalkIndex(int id)//NPC Id를 받고 퀘스트번호를 반환하는 함수 생성
    {
        return questId + questActionIndex;//대화 끝내면 다음 대화를 나누기 위해 퀘스트 대화순서를 올림
    }

    public string CheckQuest(int id)//대사가 끝나면 questActionIndex++가 올라가면서 다음 퀘스트를 불러온다.
    {
        if (id==questList[questId].npcId[questActionIndex])//우리가 정해진 NPC와 대화를 했을 때만 questActionIndex++가 올라간다.
            questActionIndex++;
        //이야기를 끝내면(대화를 끝내면)//하나가 올라가면서


       
        //대화가 끝난 후에 보여주거나 숨겨줄 퀘스트 오브젝트가 있으면 이 함수(ControlObject()) 실행
        ControlObject();

        

        if (questActionIndex == questList[questId].npcId.Length)
            NextQuest();//다음 퀘스트 확인
        //questActionIndex가 npcId의 크기와 같으면 퀘스트 번호를 증가시킨다.
        //==Npc와 대화를 다 나누면 다음 퀘스트를 실행시켜준다.

        return questList[questId].questName;//현재 퀘스트 이름 반환

    }

    //매개변수를 받지 않는 CheckQuest
    public string CheckQuest()
    {
        //퀘스트의 이름
        return questList[questId].questName;

    }

    void NextQuest()//다음 퀘스트를 위한 함수 생성
    {
        questId += 10;

        //새로운 퀘스트가 실행되기 때문에 0으로 초기화시킨다
        questActionIndex=0;
    }

    public void ControlObject()//퀘스트 오브젝트를 관리할 함수 생성 //원래 void였는데 저장때문에 public씀
    {

        switch (questId)
        {
            case 10:
                if (questActionIndex == 2)//2번 대화 나눴을 때(즉, 퀘스트 대화가 끝났을 때)
                  
                    questObject[0].SetActive(false);
                break;
            case 20:
                if (questActionIndex == 2)
                    questObject[0].SetActive(true);
                //전등을 조사하면 퀘스트 오브젝트(열쇠를 보여준다.)
                break;
            case 30:
                //if (questActionIndex == 0)
                    //questObject[0].SetActive(true);

                if (questActionIndex == 1)
                    questObject[0].SetActive(false);
                //questObject[0].SetActive(false);
                //열쇠를 먹었을 때 열쇠 없애기
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
