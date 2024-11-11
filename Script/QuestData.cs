using System.Collections;
using System.Collections.Generic;

public class QuestData
{
    public string questName;
    public int[] npcId;

    //구조체 생성을 위해 매개변수 생성자를 작성
    public QuestData(string name, int[] npc)//()안에 questName, npcId를 채워줄 매개변수를 넣으면 된다.
    {
        questName = name;
        npcId = npc;
    }
}
