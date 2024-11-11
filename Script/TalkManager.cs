using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;//string[]문자열은 배열. 글자를 많이 넣을거라
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;
    //초상화 스프라이트를 저장할 배열 생성

    void Awake()
    {//여기 부분을 초기화



        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();//데이터를 집어넣어주는 데이터

        
    }


    void GenerateData()
    {
        


        //스테이지1
        talkData.Add(7900, new string[] { "이건 뭐지...:0", "(조심스럽게 건드려봤다.):0", "뭐긴 뭐야, 사람이지!:5", "으악! 깜짝이야!: 1", "뭘 그렇게 놀라는 거야? 내 얼굴 안 보여?:4", "응. 안 보이는데...:0", "...그래?:4"});
        portraitData.Add(7900 + 0, portraitArr[0]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(7900 + 1, portraitArr[1]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(7900 + 2, portraitArr[2]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(7900 + 3, portraitArr[3]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(7900 + 4, portraitArr[4]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(7900 + 5, portraitArr[5]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(7900 + 6, portraitArr[6]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]


        talkData.Add(73000, new string[] { "화장실로 향하는 문이다.:0"});
        portraitData.Add(73000 + 0, portraitArr[0]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(73000 + 1, portraitArr[1]);//보통
        portraitData.Add(73000 + 2, portraitArr[2]);//보통
        portraitData.Add(73000 + 3, portraitArr[3]);
        portraitData.Add(73000 + 4, portraitArr[4]);
        portraitData.Add(73000 + 5, portraitArr[5]);
        portraitData.Add(73000 + 6, portraitArr[6]);
        portraitData.Add(73000 + 7, portraitArr[7]);
        portraitData.Add(73000 + 8, portraitArr[8]);
        portraitData.Add(73000 + 9, portraitArr[9]);
        portraitData.Add(73000 + 10, portraitArr[10]);
        portraitData.Add(73000 + 11, portraitArr[11]);
        portraitData.Add(73000 + 12, portraitArr[12]);
        portraitData.Add(73000 + 13, portraitArr[13]);
        portraitData.Add(73000 + 14, portraitArr[14]);
        portraitData.Add(73000 + 15, portraitArr[15]);
        portraitData.Add(73000 + 16, portraitArr[16]);
        portraitData.Add(73000 + 17, portraitArr[17]);
        portraitData.Add(73000 + 18, portraitArr[18]);
        portraitData.Add(73000 + 19, portraitArr[19]);
        portraitData.Add(73000 + 20, portraitArr[20]);
        portraitData.Add(73000 + 21, portraitArr[21]);
        portraitData.Add(73000 + 22, portraitArr[22]);
        portraitData.Add(73000 + 23, portraitArr[23]);
        portraitData.Add(73000 + 24, portraitArr[24]);

        talkData.Add(200, new string[] { "(노트북이다.):0", "(전원 버튼을 누르면 켤 수 있을 것 같다.):0" });
        portraitData.Add(200 + 0, portraitArr[0]);

        talkData.Add(68000, new string[] { "(옷장이다.):0", "(옷장 안엔 옷들과 이불이 있다.):0" });
        portraitData.Add(68000 + 0, portraitArr[0]);

        //쪽지 있는 책장
        talkData.Add(400, new string[] { "(책장이다.):0", "(책장에 붙어있는 종이가 보인다.):0", "[도서관 분류번호]:24", "[총류 - 000], [철학 - 100], [종교 - 200], [사회과학 - 300], [순수과학 - 400] :24", "[기술과학 - 500], [예술 - 600], [언어 - 700], [문학 - 800], [역사 - 900]:24" });
        portraitData.Add(400 + 0, portraitArr[0]);
        portraitData.Add(400 + 1, portraitArr[1]);
        portraitData.Add(400 + 2, portraitArr[2]);
        portraitData.Add(400 + 3, portraitArr[3]);
        portraitData.Add(400 + 4, portraitArr[4]);
        portraitData.Add(400 + 5, portraitArr[5]);
        portraitData.Add(400 + 6, portraitArr[6]);
        portraitData.Add(400 + 7, portraitArr[7]);
        portraitData.Add(400 + 8, portraitArr[8]);
        portraitData.Add(400 + 9, portraitArr[9]);
        portraitData.Add(400 + 10, portraitArr[10]);
        portraitData.Add(400 + 11, portraitArr[11]);
        portraitData.Add(400 + 12, portraitArr[12]);
        portraitData.Add(400 + 13, portraitArr[13]);
        portraitData.Add(400 + 14, portraitArr[14]);
        portraitData.Add(400 + 15, portraitArr[15]);
        portraitData.Add(400 + 16, portraitArr[16]);
        portraitData.Add(400 + 17, portraitArr[17]);
        portraitData.Add(400 + 18, portraitArr[18]);
        portraitData.Add(400 + 19, portraitArr[19]);
        portraitData.Add(400 + 20, portraitArr[20]);
        portraitData.Add(400 + 21, portraitArr[21]);
        portraitData.Add(400 + 22, portraitArr[22]);
        portraitData.Add(400 + 23, portraitArr[23]);
        portraitData.Add(400 + 24, portraitArr[24]);
  
     

        //멀쩡한 책장
        talkData.Add(76000, new string[] { "(책장이다.):0", "(어딘지도 모르는 곳에서 책을 읽고 싶진 않다.):2" });
        portraitData.Add(76000 + 0, portraitArr[0]);
        portraitData.Add(76000 + 1, portraitArr[1]);
        portraitData.Add(76000 + 2, portraitArr[2]);

        //멀쩡한 의자1
        //talkData.Add(8900, new string[] { "(식탁 의자다.):0" });
        //portraitData.Add(8900 + 0, portraitArr[0]);

        //쪽지 있는 의자1
        talkData.Add(1100, new string[] { "(의자다.):0", "(의자에 쪽지가 붙어있다.):0", "[(문학]:24" });
        portraitData.Add(1100 + 0, portraitArr[0]);
        portraitData.Add(1100 + 1, portraitArr[1]);
        portraitData.Add(1100 + 2, portraitArr[2]);
        portraitData.Add(1100 + 3, portraitArr[3]);
        portraitData.Add(1100 + 4, portraitArr[4]);
        portraitData.Add(1100 + 5, portraitArr[5]);
        portraitData.Add(1100 + 6, portraitArr[6]);
        portraitData.Add(1100 + 7, portraitArr[7]);
        portraitData.Add(1100 + 8, portraitArr[8]);
        portraitData.Add(1100 + 9, portraitArr[9]);
        portraitData.Add(1100 + 10, portraitArr[10]);
        portraitData.Add(1100 + 11, portraitArr[11]);
        portraitData.Add(1100 + 12, portraitArr[12]);
        portraitData.Add(1100 + 13, portraitArr[13]);
        portraitData.Add(1100 + 14, portraitArr[14]);
        portraitData.Add(1100 + 15, portraitArr[15]);
        portraitData.Add(1100 + 16, portraitArr[16]);
        portraitData.Add(1100 + 17, portraitArr[17]);
        portraitData.Add(1100 + 18, portraitArr[18]);
        portraitData.Add(1100 + 19, portraitArr[19]);
        portraitData.Add(1100 + 20, portraitArr[20]);
        portraitData.Add(1100 + 21, portraitArr[21]);
        portraitData.Add(1100 + 22, portraitArr[22]);
        portraitData.Add(1100 + 23, portraitArr[23]);
        portraitData.Add(1100 + 24, portraitArr[24]);

        //멀쩡한 의자2
        //talkData.Add(8800, new string[] { "(식탁 의자다.):0" });
        //portraitData.Add(8800 + 0, portraitArr[0]);

        //쪽지 있는 의자2
        talkData.Add(1300, new string[] { "(의자다.):0", "(의자에 쪽지가 붙어있다.):0", "[+언어]:24" });
        portraitData.Add(1300 + 0, portraitArr[0]);
        portraitData.Add(1300 + 1, portraitArr[1]);
        portraitData.Add(1300 + 2, portraitArr[2]);
        portraitData.Add(1300 + 3, portraitArr[3]);
        portraitData.Add(1300 + 4, portraitArr[4]);
        portraitData.Add(1300 + 5, portraitArr[5]);
        portraitData.Add(1300 + 6, portraitArr[6]);
        portraitData.Add(1300 + 7, portraitArr[7]);
        portraitData.Add(1300 + 8, portraitArr[8]);
        portraitData.Add(1300 + 9, portraitArr[9]);
        portraitData.Add(1300 + 10, portraitArr[10]);
        portraitData.Add(1300 + 11, portraitArr[11]);
        portraitData.Add(1300 + 12, portraitArr[12]);
        portraitData.Add(1300 + 13, portraitArr[13]);
        portraitData.Add(1300 + 14, portraitArr[14]);
        portraitData.Add(1300 + 15, portraitArr[15]);
        portraitData.Add(1300 + 16, portraitArr[16]);
        portraitData.Add(1300 + 17, portraitArr[17]);
        portraitData.Add(1300 + 18, portraitArr[18]);
        portraitData.Add(1300 + 19, portraitArr[19]);
        portraitData.Add(1300 + 20, portraitArr[20]);
        portraitData.Add(1300 + 21, portraitArr[21]);
        portraitData.Add(1300 + 22, portraitArr[22]);
        portraitData.Add(1300 + 23, portraitArr[23]);
        portraitData.Add(1300 + 24, portraitArr[24]);

        //그냥 냉장고
        talkData.Add(79000, new string[] { "(냉장고다.):0", "(냉장고 안엔 아무것도 없다.):0" });
        portraitData.Add(79000 + 0, portraitArr[0]);


        //쪽지 있는 냉장고
        talkData.Add(1200, new string[] { "(냉장고다.):0", "(냉장고 문에 쪽지가 붙어있다.):0", "[( )안에는 숫자 2개와 부호가 1개 있다.]:24" });
        portraitData.Add(1200 + 0, portraitArr[0]);
        portraitData.Add(1200 + 1, portraitArr[1]);
        portraitData.Add(1200 + 2, portraitArr[2]);
        portraitData.Add(1200 + 3, portraitArr[3]);
        portraitData.Add(1200 + 4, portraitArr[4]);
        portraitData.Add(1200 + 5, portraitArr[5]);
        portraitData.Add(1200 + 6, portraitArr[6]);
        portraitData.Add(1200 + 7, portraitArr[7]);
        portraitData.Add(1200 + 8, portraitArr[8]);
        portraitData.Add(1200 + 9, portraitArr[9]);
        portraitData.Add(1200 + 10, portraitArr[10]);
        portraitData.Add(1200 + 11, portraitArr[11]);
        portraitData.Add(1200 + 12, portraitArr[12]);
        portraitData.Add(1200 + 13, portraitArr[13]);
        portraitData.Add(1200 + 14, portraitArr[14]);
        portraitData.Add(1200 + 15, portraitArr[15]);
        portraitData.Add(1200 + 16, portraitArr[16]);
        portraitData.Add(1200 + 17, portraitArr[17]);
        portraitData.Add(1200 + 18, portraitArr[18]);
        portraitData.Add(1200 + 19, portraitArr[19]);
        portraitData.Add(1200 + 20, portraitArr[20]);
        portraitData.Add(1200 + 21, portraitArr[21]);
        portraitData.Add(1200 + 22, portraitArr[22]);
        portraitData.Add(1200 + 23, portraitArr[23]);
        portraitData.Add(1200 + 24, portraitArr[24]);

        //그냥 가스레인지
        talkData.Add(78000, new string[] { "(가스레인지다.):0", "(한 번 켜볼까?):0", "치지지직...:24", "(켜지지 않는다.):0" });
        portraitData.Add(78000 + 0, portraitArr[0]);
        portraitData.Add(78000 + 1, portraitArr[1]);
        portraitData.Add(78000 + 2, portraitArr[2]);
        portraitData.Add(78000 + 3, portraitArr[3]);
        portraitData.Add(78000 + 4, portraitArr[4]);
        portraitData.Add(78000 + 5, portraitArr[5]);
        portraitData.Add(78000 + 6, portraitArr[6]);
        portraitData.Add(78000 + 7, portraitArr[7]);
        portraitData.Add(78000 + 8, portraitArr[8]);
        portraitData.Add(78000 + 9, portraitArr[9]);
        portraitData.Add(78000 + 10, portraitArr[10]);
        portraitData.Add(78000 + 11, portraitArr[11]);
        portraitData.Add(78000 + 12, portraitArr[12]);
        portraitData.Add(78000 + 13, portraitArr[13]);
        portraitData.Add(78000 + 14, portraitArr[14]);
        portraitData.Add(78000 + 15, portraitArr[15]);
        portraitData.Add(78000 + 16, portraitArr[16]);
        portraitData.Add(78000 + 17, portraitArr[17]);
        portraitData.Add(78000 + 18, portraitArr[18]);
        portraitData.Add(78000 + 19, portraitArr[19]);
        portraitData.Add(78000 + 20, portraitArr[20]);
        portraitData.Add(78000 + 21, portraitArr[21]);
        portraitData.Add(78000 + 22, portraitArr[22]);
        portraitData.Add(78000 + 23, portraitArr[23]);
        portraitData.Add(78000 + 24, portraitArr[24]);

        //쪽지 있는 가스레인지
        talkData.Add(1000, new string[] { "(가스레인지다.):0", "(가스레인지에 쪽지가 붙어있다.):0", "[/순수과학)]:24" });
        portraitData.Add(1000 + 0, portraitArr[0]);
        portraitData.Add(1000 + 1, portraitArr[1]);
        portraitData.Add(1000 + 2, portraitArr[2]);
        portraitData.Add(1000 + 3, portraitArr[3]);
        portraitData.Add(1000 + 4, portraitArr[4]);
        portraitData.Add(1000 + 5, portraitArr[5]);
        portraitData.Add(1000 + 6, portraitArr[6]);
        portraitData.Add(1000 + 7, portraitArr[7]);
        portraitData.Add(1000 + 8, portraitArr[8]);
        portraitData.Add(1000 + 9, portraitArr[9]);
        portraitData.Add(1000 + 10, portraitArr[10]);
        portraitData.Add(1000 + 11, portraitArr[11]);
        portraitData.Add(1000 + 12, portraitArr[12]);
        portraitData.Add(1000 + 13, portraitArr[13]);
        portraitData.Add(1000 + 14, portraitArr[14]);
        portraitData.Add(1000 + 15, portraitArr[15]);
        portraitData.Add(1000 + 16, portraitArr[16]);
        portraitData.Add(1000 + 17, portraitArr[17]);
        portraitData.Add(1000 + 18, portraitArr[18]);
        portraitData.Add(1000 + 19, portraitArr[19]);
        portraitData.Add(1000 + 20, portraitArr[20]);
        portraitData.Add(1000 + 21, portraitArr[21]);
        portraitData.Add(1000 + 22, portraitArr[22]);
        portraitData.Add(1000 + 23, portraitArr[23]);
        portraitData.Add(1000 + 24, portraitArr[24]);

        //그냥 개수대
        talkData.Add(77000, new string[] { "(개수대.):0", "(수도꼭지를 틀어볼까?):0", "졸졸졸...:24", "(물은 잘 나온다.):0" });
        portraitData.Add(77000 + 0, portraitArr[0]);
        portraitData.Add(77000 + 1, portraitArr[1]);
        portraitData.Add(77000 + 2, portraitArr[2]);
        portraitData.Add(77000 + 3, portraitArr[3]);
        portraitData.Add(77000 + 4, portraitArr[4]);
        portraitData.Add(77000 + 5, portraitArr[5]);
        portraitData.Add(77000 + 6, portraitArr[6]);
        portraitData.Add(77000 + 7, portraitArr[7]);
        portraitData.Add(77000 + 8, portraitArr[8]);
        portraitData.Add(77000 + 9, portraitArr[9]);
        portraitData.Add(77000 + 10, portraitArr[10]);
        portraitData.Add(77000 + 11, portraitArr[11]);
        portraitData.Add(77000 + 12, portraitArr[12]);
        portraitData.Add(77000 + 13, portraitArr[13]);
        portraitData.Add(77000 + 14, portraitArr[14]);
        portraitData.Add(77000 + 15, portraitArr[15]);
        portraitData.Add(77000 + 16, portraitArr[16]);
        portraitData.Add(77000 + 17, portraitArr[17]);
        portraitData.Add(77000 + 18, portraitArr[18]);
        portraitData.Add(77000 + 19, portraitArr[19]);
        portraitData.Add(77000 + 20, portraitArr[20]);
        portraitData.Add(77000 + 21, portraitArr[21]);
        portraitData.Add(77000 + 22, portraitArr[22]);
        portraitData.Add(77000 + 23, portraitArr[23]);
        portraitData.Add(77000 + 24, portraitArr[24]);


        //쪽지 있는 개수대
        talkData.Add(900, new string[] { "(개수대다.):0", "(개수대에 쪽지가 붙어있다.):0", "[+사회과학]:24" });
        portraitData.Add(900 + 0, portraitArr[0]);
        portraitData.Add(900 + 1, portraitArr[1]);
        portraitData.Add(900 + 2, portraitArr[2]);
        portraitData.Add(900 + 3, portraitArr[3]);
        portraitData.Add(900 + 4, portraitArr[4]);
        portraitData.Add(900 + 5, portraitArr[5]);
        portraitData.Add(900 + 6, portraitArr[6]);
        portraitData.Add(900 + 7, portraitArr[7]);
        portraitData.Add(900 + 8, portraitArr[8]);
        portraitData.Add(900 + 9, portraitArr[9]);
        portraitData.Add(900 + 10, portraitArr[10]);
        portraitData.Add(900 + 11, portraitArr[11]);
        portraitData.Add(900 + 12, portraitArr[12]);
        portraitData.Add(900 + 13, portraitArr[13]);
        portraitData.Add(900 + 14, portraitArr[14]);
        portraitData.Add(900 + 15, portraitArr[15]);
        portraitData.Add(900 + 16, portraitArr[16]);
        portraitData.Add(900 + 17, portraitArr[17]);
        portraitData.Add(900 + 18, portraitArr[18]);
        portraitData.Add(900 + 19, portraitArr[19]);
        portraitData.Add(900 + 20, portraitArr[20]);
        portraitData.Add(900 + 21, portraitArr[21]);
        portraitData.Add(900 + 22, portraitArr[22]);
        portraitData.Add(900 + 23, portraitArr[23]);
        portraitData.Add(900 + 24, portraitArr[24]);

        talkData.Add(35000, new string[] { "(창문이다.):0", "(창밖으로 검은 하늘이 보인다.):0", "(구름도, 달도, 별도 없는 것이 하늘에 검은 물감을 뿌린 것 같다.):0"});
        portraitData.Add(35000 + 0, portraitArr[0]);
        
        talkData.Add(69000, new string[] { "(침대다.):0", "(왠지 피곤하지만 지금은 여길 조사해 보는 게 우선이다.):0" });
        portraitData.Add(69000 + 0, portraitArr[0]);

        talkData.Add(37000, new string[] { "(전등이다.):0"});
        portraitData.Add(37000 + 0, portraitArr[0]);
        portraitData.Add(37000 + 1, portraitArr[1]);
        portraitData.Add(37000 + 2, portraitArr[2]);
        portraitData.Add(37000 + 3, portraitArr[3]);
        portraitData.Add(37000 + 4, portraitArr[4]);
        portraitData.Add(37000 + 5, portraitArr[5]);
        portraitData.Add(37000 + 6, portraitArr[6]);
        portraitData.Add(37000 + 7, portraitArr[7]);
        portraitData.Add(37000 + 8, portraitArr[8]);
        portraitData.Add(37000 + 9, portraitArr[9]);
        portraitData.Add(37000 + 10, portraitArr[10]);
        portraitData.Add(37000 + 11, portraitArr[11]);
        portraitData.Add(37000 + 12, portraitArr[12]);
        portraitData.Add(37000 + 13, portraitArr[13]);
        portraitData.Add(37000 + 14, portraitArr[14]);
        portraitData.Add(37000 + 15, portraitArr[15]);
        portraitData.Add(37000 + 16, portraitArr[16]);
        portraitData.Add(37000 + 17, portraitArr[17]);
        portraitData.Add(37000 + 18, portraitArr[18]);
        portraitData.Add(37000 + 19, portraitArr[19]);
        portraitData.Add(37000 + 20, portraitArr[20]);
        portraitData.Add(37000 + 21, portraitArr[21]);
        portraitData.Add(37000 + 22, portraitArr[22]);
        portraitData.Add(37000 + 23, portraitArr[23]);
        portraitData.Add(37000 + 24, portraitArr[24]);

        talkData.Add(70000, new string[] { "(세탁기다.):0", "(세탁기 안에 무언가가 있다.):0", "(교복이다.):0", "어디선가 본 적이 있는 것 같은데...:0" });
        portraitData.Add(70000 + 0, portraitArr[0]);      

        talkData.Add(71000, new string[] { "(식탁이다.):0", "(펜하고 종이가 있다.):0", "(종이에 어떤 글씨가 쓰여 있다.):0", "[절망으로부터의 유일한 피난처는 세상에 자아를 포기하는 것이다.]:24" });
        portraitData.Add(71000 + 0, portraitArr[0]);
        portraitData.Add(71000 + 1, portraitArr[1]);
        portraitData.Add(71000 + 2, portraitArr[2]);
        portraitData.Add(71000 + 3, portraitArr[3]);
        portraitData.Add(71000 + 4, portraitArr[4]);
        portraitData.Add(71000 + 5, portraitArr[5]);
        portraitData.Add(71000 + 6, portraitArr[6]);
        portraitData.Add(71000 + 7, portraitArr[7]);
        portraitData.Add(71000 + 8, portraitArr[8]);
        portraitData.Add(71000 + 9, portraitArr[9]);
        portraitData.Add(71000 + 10, portraitArr[10]);
        portraitData.Add(71000 + 11, portraitArr[11]);
        portraitData.Add(71000 + 12, portraitArr[12]);
        portraitData.Add(71000 + 13, portraitArr[13]);
        portraitData.Add(71000 + 14, portraitArr[14]);
        portraitData.Add(71000 + 15, portraitArr[15]);
        portraitData.Add(71000 + 16, portraitArr[16]);
        portraitData.Add(71000 + 17, portraitArr[17]);
        portraitData.Add(71000 + 18, portraitArr[18]);
        portraitData.Add(71000 + 19, portraitArr[19]);
        portraitData.Add(71000 + 20, portraitArr[20]);
        portraitData.Add(71000 + 21, portraitArr[21]);
        portraitData.Add(71000 + 22, portraitArr[22]);
        portraitData.Add(71000 + 23, portraitArr[23]);
        portraitData.Add(71000 + 24, portraitArr[24]);

        talkData.Add(44000, new string[] { "(다음 스테이지로 가는 곳이다.):0", "(번호 키가 있다.):0" });
        portraitData.Add(44000 + 0, portraitArr[0]);
        portraitData.Add(44000 + 1, portraitArr[1]);


        talkData.Add(80000, new string[] { "화면에 어떤 글씨가 적혀있다.:0", "[ 우리들은 소망해선 안될 것을 가장 소망한다. 2021.09.15 오전 11시 ] :24" });
        portraitData.Add(80000 + 0, portraitArr[0]);
        portraitData.Add(80000 + 1, portraitArr[1]);
        portraitData.Add(80000 + 2, portraitArr[2]);
        portraitData.Add(80000 + 3, portraitArr[3]);
        portraitData.Add(80000 + 4, portraitArr[4]);
        portraitData.Add(80000 + 5, portraitArr[5]);
        portraitData.Add(80000 + 6, portraitArr[6]);
        portraitData.Add(80000 + 7, portraitArr[7]);
        portraitData.Add(80000 + 8, portraitArr[8]);
        portraitData.Add(80000 + 9, portraitArr[9]);
        portraitData.Add(80000 + 10, portraitArr[10]);
        portraitData.Add(80000 + 11, portraitArr[11]);
        portraitData.Add(80000 + 12, portraitArr[12]);
        portraitData.Add(80000 + 13, portraitArr[13]);
        portraitData.Add(80000 + 14, portraitArr[14]);
        portraitData.Add(80000 + 15, portraitArr[15]);
        portraitData.Add(80000 + 16, portraitArr[16]);
        portraitData.Add(80000 + 17, portraitArr[17]);
        portraitData.Add(80000 + 18, portraitArr[18]);
        portraitData.Add(80000 + 19, portraitArr[19]);
        portraitData.Add(80000 + 20, portraitArr[20]);
        portraitData.Add(80000 + 21, portraitArr[21]);
        portraitData.Add(80000 + 22, portraitArr[22]);
        portraitData.Add(80000 + 23, portraitArr[23]);
        portraitData.Add(80000 + 24, portraitArr[24]);

        talkData.Add(75000, new string[] { "(욕조다.):0" });
        portraitData.Add(75000 + 0, portraitArr[0]);

        talkData.Add(74000, new string[] { "(변기다.):0" });
        portraitData.Add(74000 + 0, portraitArr[0]);

        talkData.Add(34000, new string[] { "(세면대다.):0" });
        portraitData.Add(34000 + 0, portraitArr[0]);
        portraitData.Add(34000 + 1, portraitArr[1]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(34000 + 2, portraitArr[2]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(34000 + 3, portraitArr[3]);//id+몇 번째 문장에 사용할 건지, [초상화 번호]
        portraitData.Add(34000 + 4, portraitArr[4]);
        portraitData.Add(34000 + 5, portraitArr[5]);
        portraitData.Add(34000 + 6, portraitArr[6]);
        portraitData.Add(34000 + 7, portraitArr[7]);
        portraitData.Add(34000 + 8, portraitArr[8]);
        portraitData.Add(34000 + 9, portraitArr[9]);
        portraitData.Add(34000 + 10, portraitArr[10]);
        portraitData.Add(34000 + 11, portraitArr[11]);
        portraitData.Add(34000 + 12, portraitArr[12]);
        portraitData.Add(34000 + 13, portraitArr[13]);
        portraitData.Add(34000 + 14, portraitArr[14]);
        portraitData.Add(34000 + 15, portraitArr[15]);
        portraitData.Add(34000 + 16, portraitArr[16]);
        portraitData.Add(34000 + 17, portraitArr[17]);
        portraitData.Add(34000 + 18, portraitArr[18]);
        portraitData.Add(34000 + 19, portraitArr[19]);
        portraitData.Add(34000 + 20, portraitArr[20]);
        portraitData.Add(34000 + 21, portraitArr[21]);
        portraitData.Add(34000 + 22, portraitArr[22]);
        portraitData.Add(34000 + 23, portraitArr[23]);
        portraitData.Add(34000 + 24, portraitArr[24]);


        talkData.Add(39000, new string[] { "(수건걸이다.):0" });
        portraitData.Add(39000 + 0, portraitArr[0]);
        portraitData.Add(39000 + 1, portraitArr[1]);//보통
        portraitData.Add(39000 + 2, portraitArr[2]);//보통
        portraitData.Add(39000 + 3, portraitArr[3]);
        portraitData.Add(39000 + 4, portraitArr[4]);
        portraitData.Add(39000 + 5, portraitArr[5]);
        portraitData.Add(39000 + 6, portraitArr[6]);
        portraitData.Add(39000 + 7, portraitArr[7]);
        portraitData.Add(39000 + 8, portraitArr[8]);
        portraitData.Add(39000 + 9, portraitArr[9]);
        portraitData.Add(39000 + 10, portraitArr[10]);
        portraitData.Add(39000 + 11, portraitArr[11]);
        portraitData.Add(39000 + 12, portraitArr[12]);
        portraitData.Add(39000 + 13, portraitArr[13]);
        portraitData.Add(39000 + 14, portraitArr[14]);
        portraitData.Add(39000 + 15, portraitArr[15]);
        portraitData.Add(39000 + 16, portraitArr[16]);
        portraitData.Add(39000 + 17, portraitArr[17]);
        portraitData.Add(39000 + 18, portraitArr[18]);
        portraitData.Add(39000 + 19, portraitArr[19]);
        portraitData.Add(39000 + 20, portraitArr[20]);
        portraitData.Add(39000 + 21, portraitArr[21]);
        portraitData.Add(39000 + 22, portraitArr[22]);
        portraitData.Add(39000 + 23, portraitArr[23]);
        portraitData.Add(39000 + 24, portraitArr[24]);

        /*talkData.Add(2200, new string[] { "(휴지걸이다.):0" });
        portraitData.Add(2200 + 0, portraitArr[0]);*/

        talkData.Add(4600, new string[] { "(잠금장치가 있는 문이다.):0", "(아직 6자리 문자를 알아내지 못했다.) :2", "(주변을 더 찾아보자.):0" });
        portraitData.Add(4600 + 0, portraitArr[0]);//보통
        portraitData.Add(4600 + 1, portraitArr[1]);//많이 놀람
        portraitData.Add(4600 + 2, portraitArr[2]);//졸림
        portraitData.Add(4600 + 3, portraitArr[3]);//웃음

        //스테이지2
        talkData.Add(7500, new string[] { "너... 안색이 안 좋아 보이는데, 괜찮아?:8", "나?:0", "응. 괜찮아. 조금... 머리가 띵할 뿐이야.:3", "그래...:11" });
        portraitData.Add(7500 + 0, portraitArr[0]);//보통
        portraitData.Add(7500 + 1, portraitArr[1]);//많이 놀람
        portraitData.Add(7500 + 2, portraitArr[2]);//졸림
        portraitData.Add(7500 + 3, portraitArr[3]);//웃음

        portraitData.Add(7500 + 4, portraitArr[4]);//NPC1-보통
        portraitData.Add(7500 + 5, portraitArr[5]);//NPC1-빠직 없음
        portraitData.Add(7500 + 6, portraitArr[6]);//NPC1-화남

        portraitData.Add(7500 + 7, portraitArr[7]);//NPC2-놀람
        portraitData.Add(7500 + 8, portraitArr[8]);//NPC2-당황 땀 삐질
        portraitData.Add(7500 + 9, portraitArr[9]);//NPC2-미소
        portraitData.Add(7500 + 10, portraitArr[10]);//NPC2-눈 감고 있음. 미안함
        portraitData.Add(7500 + 11, portraitArr[11]);//NPC2-기본 표정

        portraitData.Add(7500 + 12, portraitArr[12]);
        portraitData.Add(7500 + 13, portraitArr[13]);
        portraitData.Add(7500 + 14, portraitArr[14]);
        portraitData.Add(7500 + 15, portraitArr[15]);
        portraitData.Add(7500 + 16, portraitArr[16]);
        portraitData.Add(7500 + 17, portraitArr[17]);
        portraitData.Add(7500 + 18, portraitArr[18]);
        portraitData.Add(7500 + 19, portraitArr[19]);
        portraitData.Add(7500 + 20, portraitArr[20]);
        portraitData.Add(7500 + 21, portraitArr[21]);
        portraitData.Add(7500 + 22, portraitArr[22]);
        portraitData.Add(7500 + 23, portraitArr[23]);
        portraitData.Add(7500 + 24, portraitArr[24]);

        //일반 얘기(야구장은 퀘스트까지 그냥 적혀 있음.)

        //(2023.02.25)-퀘스트까지 그냥 있으면 어랏 다 봤는데 뭘 또 보라는 거야? 의 경우가 발생할 수 있기에 추가한다
        //물건 데이터 번호는 97000
        talkData.Add(97000, new string[] { "(야구장이다.):0", "(이전에 누군가와 함께 온 듯한 느낌이 든다.):0" });
        portraitData.Add(97000 + 0, portraitArr[0]);//보통
        portraitData.Add(97000 + 1, portraitArr[1]);//보통
        portraitData.Add(97000 + 2, portraitArr[2]);//보통
        portraitData.Add(97000 + 3, portraitArr[3]);
        portraitData.Add(97000 + 4, portraitArr[4]);
        portraitData.Add(97000 + 5, portraitArr[5]);
        portraitData.Add(97000 + 6, portraitArr[6]);
        portraitData.Add(97000 + 7, portraitArr[7]);
        portraitData.Add(97000 + 8, portraitArr[8]);
        portraitData.Add(97000 + 9, portraitArr[9]);
        portraitData.Add(97000 + 10, portraitArr[10]);
        portraitData.Add(97000 + 11, portraitArr[11]);
        portraitData.Add(97000 + 12, portraitArr[12]);
        portraitData.Add(97000 + 13, portraitArr[13]);
        portraitData.Add(97000 + 14, portraitArr[14]);
        portraitData.Add(97000 + 15, portraitArr[15]);
        portraitData.Add(97000 + 16, portraitArr[16]);
        portraitData.Add(97000 + 17, portraitArr[17]);
        portraitData.Add(97000 + 18, portraitArr[18]);
        portraitData.Add(97000 + 19, portraitArr[19]);
        portraitData.Add(97000 + 20, portraitArr[20]);
        portraitData.Add(97000 + 21, portraitArr[21]);
        portraitData.Add(97000 + 22, portraitArr[22]);
        portraitData.Add(97000 + 23, portraitArr[23]);
        portraitData.Add(97000 + 24, portraitArr[24]);



        talkData.Add(57000, new string[] { "(야구장이다.):0", "(이전에 누군가와 함께 온 듯한 느낌이 든다.):0", "(자세히 보니 입구 앞 초록색 표지판에 무언가가 쓰여 있다.):0", "[지금은 정규 시즌이 아닙니다. 다음에 또 방문해 주세요.]:24", "[ThOs Os not the regular season. Please vOsOt agaOn next tOme.]:24" });
        portraitData.Add(57000 + 0, portraitArr[0]);//보통
        portraitData.Add(57000 + 1, portraitArr[1]);//보통
        portraitData.Add(57000 + 2, portraitArr[2]);//보통
        portraitData.Add(57000 + 3, portraitArr[3]);
        portraitData.Add(57000 + 4, portraitArr[4]);
        portraitData.Add(57000 + 5, portraitArr[5]);
        portraitData.Add(57000 + 6, portraitArr[6]);
        portraitData.Add(57000 + 7, portraitArr[7]);
        portraitData.Add(57000 + 8, portraitArr[8]);
        portraitData.Add(57000 + 9, portraitArr[9]);
        portraitData.Add(57000 + 10, portraitArr[10]);
        portraitData.Add(57000 + 11, portraitArr[11]);
        portraitData.Add(57000 + 12, portraitArr[12]);
        portraitData.Add(57000 + 13, portraitArr[13]);
        portraitData.Add(57000 + 14, portraitArr[14]);
        portraitData.Add(57000 + 15, portraitArr[15]);
        portraitData.Add(57000 + 16, portraitArr[16]);
        portraitData.Add(57000 + 17, portraitArr[17]);
        portraitData.Add(57000 + 18, portraitArr[18]);
        portraitData.Add(57000 + 19, portraitArr[19]);
        portraitData.Add(57000 + 20, portraitArr[20]);
        portraitData.Add(57000 + 21, portraitArr[21]);
        portraitData.Add(57000 + 22, portraitArr[22]);
        portraitData.Add(57000 + 23, portraitArr[23]);
        portraitData.Add(57000 + 24, portraitArr[24]);

        //**여기부터 분수**(16개)
        talkData.Add(55000, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
        portraitData.Add(55000 + 0, portraitArr[0]);//보통
        portraitData.Add(55000 + 1, portraitArr[1]);//많이 놀람
        portraitData.Add(55000 + 2, portraitArr[2]);//졸림
        portraitData.Add(55000 + 3, portraitArr[3]);
        portraitData.Add(55000 + 4, portraitArr[4]);
        portraitData.Add(55000 + 5, portraitArr[5]);
        portraitData.Add(55000 + 6, portraitArr[6]);
        portraitData.Add(55000 + 7, portraitArr[7]);
        portraitData.Add(55000 + 8, portraitArr[8]);
        portraitData.Add(55000 + 9, portraitArr[9]);
        portraitData.Add(55000 + 10, portraitArr[10]);
        portraitData.Add(55000 + 11, portraitArr[11]);
        portraitData.Add(55000 + 12, portraitArr[12]);
        portraitData.Add(55000 + 13, portraitArr[13]);
        portraitData.Add(55000 + 14, portraitArr[14]);
        portraitData.Add(55000 + 15, portraitArr[15]);
        portraitData.Add(55000 + 16, portraitArr[16]);
        portraitData.Add(55000 + 17, portraitArr[17]);
        portraitData.Add(55000 + 18, portraitArr[18]);
        portraitData.Add(55000 + 19, portraitArr[19]);
        portraitData.Add(55000 + 20, portraitArr[20]);
        portraitData.Add(55000 + 21, portraitArr[21]);
        portraitData.Add(55000 + 22, portraitArr[22]);
        portraitData.Add(55000 + 23, portraitArr[23]);
        portraitData.Add(55000 + 24, portraitArr[24]);


        /* talkData.Add(6500, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(6500 + 0, portraitArr[0]);//보통
         portraitData.Add(6500 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(6500 + 2, portraitArr[2]);//졸림

         talkData.Add(6600, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(6600 + 0, portraitArr[0]);//보통
         portraitData.Add(6600 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(6600 + 2, portraitArr[2]);//졸림

         talkData.Add(6700, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(6700 + 0, portraitArr[0]);//보통
         portraitData.Add(6700 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(6700 + 2, portraitArr[2]);//졸림

         talkData.Add(6800, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(6800 + 0, portraitArr[0]);//보통
         portraitData.Add(6800 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(6800 + 2, portraitArr[2]);//졸림

         talkData.Add(6900, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(6900 + 0, portraitArr[0]);//보통
         portraitData.Add(6900 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(6900 + 2, portraitArr[2]);//졸림

         talkData.Add(7000, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7000 + 0, portraitArr[0]);//보통
         portraitData.Add(7000 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7000 + 2, portraitArr[2]);//졸림

         talkData.Add(7100, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7100 + 0, portraitArr[0]);//보통
         portraitData.Add(7100 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7100 + 2, portraitArr[2]);//졸림

         talkData.Add(7200, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7200 + 0, portraitArr[0]);//보통
         portraitData.Add(7200 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7200 + 2, portraitArr[2]);//졸림

         talkData.Add(7300, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7300 + 0, portraitArr[0]);//보통
         portraitData.Add(7300 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7300 + 2, portraitArr[2]);//졸림

         talkData.Add(7400, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7400 + 0, portraitArr[0]);//보통
         portraitData.Add(7400 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7400 + 2, portraitArr[2]);//졸림

         talkData.Add(7500, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7500 + 0, portraitArr[0]);//보통
         portraitData.Add(7500 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7500 + 2, portraitArr[2]);//졸림

         talkData.Add(7600, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7600 + 0, portraitArr[0]);//보통
         portraitData.Add(7600 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7600 + 2, portraitArr[2]);//졸림

         talkData.Add(7700, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7700 + 0, portraitArr[0]);//보통
         portraitData.Add(7700 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7700 + 2, portraitArr[2]);//졸림

         talkData.Add(7800, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7800 + 0, portraitArr[0]);//보통
         portraitData.Add(7800 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7800 + 2, portraitArr[2]);//졸림

         talkData.Add(7900, new string[] { "(분수다.):0", "(안으로 들어가고 싶지만, 물줄기가 강해 섣불리 들어갈 용기가 나질 않는다.):2" });
         portraitData.Add(7900 + 0, portraitArr[0]);//보통
         portraitData.Add(7900 + 1, portraitArr[1]);//많이 놀람
         portraitData.Add(7900 + 2, portraitArr[2]);//졸림*/

        //일반 얘기(버스는 퀘스트까지 그냥 적혀 있음.)

        // *** (2023.02.25)-퀘스트까지 그냥 있으면 어랏 다 봤는데 뭘 또 보라는 거야? 의 경우가 발생할 수 있기에 추가한다 ***
        //물건 데이터 번호는 98000

        talkData.Add(98000, new string[] { "(버스다.):0" });
        portraitData.Add(98000 + 0, portraitArr[0]);//보통
        portraitData.Add(98000 + 1, portraitArr[1]);//보통
        portraitData.Add(98000 + 2, portraitArr[2]);//보통
        portraitData.Add(98000 + 3, portraitArr[3]);
        portraitData.Add(98000 + 4, portraitArr[4]);
        portraitData.Add(98000 + 5, portraitArr[5]);
        portraitData.Add(98000 + 6, portraitArr[6]);
        portraitData.Add(98000 + 7, portraitArr[7]);
        portraitData.Add(98000 + 8, portraitArr[8]);
        portraitData.Add(98000 + 9, portraitArr[9]);
        portraitData.Add(98000 + 10, portraitArr[10]);
        portraitData.Add(98000 + 11, portraitArr[11]);
        portraitData.Add(98000 + 12, portraitArr[12]);
        portraitData.Add(98000 + 13, portraitArr[13]);
        portraitData.Add(98000 + 14, portraitArr[14]);
        portraitData.Add(98000 + 15, portraitArr[15]);
        portraitData.Add(98000 + 16, portraitArr[16]);
        portraitData.Add(98000 + 17, portraitArr[17]);
        portraitData.Add(98000 + 18, portraitArr[18]);
        portraitData.Add(98000 + 19, portraitArr[19]);
        portraitData.Add(98000 + 20, portraitArr[20]);
        portraitData.Add(98000 + 21, portraitArr[21]);
        portraitData.Add(98000 + 22, portraitArr[22]);
        portraitData.Add(98000 + 23, portraitArr[23]);
        portraitData.Add(98000 + 24, portraitArr[24]);


        talkData.Add(58000, new string[] { "(버스다.):0", "(버스 창에 무언가가 붙어 있다.):0", "[첫 글자는 파란색, 세 번째 글자는 빨간색이다.]:24" });
        portraitData.Add(58000 + 0, portraitArr[0]);//보통
        portraitData.Add(58000 + 1, portraitArr[1]);//보통
        portraitData.Add(58000 + 2, portraitArr[2]);//보통
        portraitData.Add(58000 + 3, portraitArr[3]);
        portraitData.Add(58000 + 4, portraitArr[4]);
        portraitData.Add(58000 + 5, portraitArr[5]);
        portraitData.Add(58000 + 6, portraitArr[6]);
        portraitData.Add(58000 + 7, portraitArr[7]);
        portraitData.Add(58000 + 8, portraitArr[8]);
        portraitData.Add(58000 + 9, portraitArr[9]);
        portraitData.Add(58000 + 10, portraitArr[10]);
        portraitData.Add(58000 + 11, portraitArr[11]);
        portraitData.Add(58000 + 12, portraitArr[12]);
        portraitData.Add(58000 + 13, portraitArr[13]);
        portraitData.Add(58000 + 14, portraitArr[14]);
        portraitData.Add(58000 + 15, portraitArr[15]);
        portraitData.Add(58000 + 16, portraitArr[16]);
        portraitData.Add(58000 + 17, portraitArr[17]);
        portraitData.Add(58000 + 18, portraitArr[18]);
        portraitData.Add(58000 + 19, portraitArr[19]);
        portraitData.Add(58000 + 20, portraitArr[20]);
        portraitData.Add(58000 + 21, portraitArr[21]);
        portraitData.Add(58000 + 22, portraitArr[22]);
        portraitData.Add(58000 + 23, portraitArr[23]);
        portraitData.Add(58000 + 24, portraitArr[24]);

        //일반 얘기
        //2400에서 81000
        talkData.Add(81000, new string[] { "(관람차다.):0", "(왼쪽 칸 안에는 아무것도 없다.):2" });
        portraitData.Add(81000 + 0, portraitArr[0]);//보통
        portraitData.Add(81000 + 1, portraitArr[1]);//보통
        portraitData.Add(81000 + 2, portraitArr[2]);//보통

        //일반 얘기
        talkData.Add(36000, new string[] { "(관람차다.):0", "(가운데 칸 안에는 아무것도 없다.):2" });
        portraitData.Add(36000 + 0, portraitArr[0]);//보통
        portraitData.Add(36000 + 1, portraitArr[1]);//보통
        portraitData.Add(36000 + 2, portraitArr[2]);//보통

        //***실험중임***
        //일반 얘기
        talkData.Add(59000, new string[] { "(관람차다.):0", "(안에 무언가가 있다.):0", "(노란색 쪽지다.):0", "(쪽지엔 이렇게 적혀 있다.):0", "[형, 사랑해.(I love O.)]:24", "(왠지 조금 슬픈 느낌이 든다.):2" });
        portraitData.Add(59000 + 0, portraitArr[0]);//보통
        portraitData.Add(59000 + 1, portraitArr[1]);//보통
        portraitData.Add(59000 + 2, portraitArr[2]);//보통
        portraitData.Add(59000 + 3, portraitArr[3]);
        portraitData.Add(59000 + 4, portraitArr[4]);
        portraitData.Add(59000 + 5, portraitArr[5]);
        portraitData.Add(59000 + 6, portraitArr[6]);
        portraitData.Add(59000 + 7, portraitArr[7]);
        portraitData.Add(59000 + 8, portraitArr[8]);
        portraitData.Add(59000 + 9, portraitArr[9]);
        portraitData.Add(59000 + 10, portraitArr[10]);
        portraitData.Add(59000 + 11, portraitArr[11]);
        portraitData.Add(59000 + 12, portraitArr[12]);
        portraitData.Add(59000 + 13, portraitArr[13]);
        portraitData.Add(59000 + 14, portraitArr[14]);
        portraitData.Add(59000 + 15, portraitArr[15]);
        portraitData.Add(59000 + 16, portraitArr[16]);
        portraitData.Add(59000 + 17, portraitArr[17]);
        portraitData.Add(59000 + 18, portraitArr[18]);
        portraitData.Add(59000 + 19, portraitArr[19]);
        portraitData.Add(59000 + 20, portraitArr[20]);
        portraitData.Add(59000 + 21, portraitArr[21]);
        portraitData.Add(59000 + 22, portraitArr[22]);
        portraitData.Add(59000 + 23, portraitArr[23]);
        portraitData.Add(59000 + 24, portraitArr[24]);

        //일반 얘기
        //2600을 82000
        talkData.Add(82000, new string[] { "(관람차다.):0", "(오른쪽 칸 안에는 아무것도 없다.):2" });
        portraitData.Add(82000 + 0, portraitArr[0]);//보통
        portraitData.Add(82000 + 1, portraitArr[1]);//보통
        portraitData.Add(82000 + 2, portraitArr[2]);//보통

        //**타입캡슐 8개 시작***
        //2800->83000
        talkData.Add(83000, new string[] { "(타임캡슐의 비석이다.):0", "(비석에 어떤 글자가 적혀있다.):0", "[ NE ]:24" });
        portraitData.Add(83000 + 0, portraitArr[0]);//보통
        portraitData.Add(83000 + 1, portraitArr[1]);//보통
        portraitData.Add(83000 + 2, portraitArr[2]);//보통
        portraitData.Add(83000 + 3, portraitArr[3]);
        portraitData.Add(83000 + 4, portraitArr[4]);
        portraitData.Add(83000 + 5, portraitArr[5]);
        portraitData.Add(83000 + 6, portraitArr[6]);
        portraitData.Add(83000 + 7, portraitArr[7]);
        portraitData.Add(83000 + 8, portraitArr[8]);
        portraitData.Add(83000 + 9, portraitArr[9]);
        portraitData.Add(83000 + 10, portraitArr[10]);
        portraitData.Add(83000 + 11, portraitArr[11]);
        portraitData.Add(83000 + 12, portraitArr[12]);
        portraitData.Add(83000 + 13, portraitArr[13]);
        portraitData.Add(83000 + 14, portraitArr[14]);
        portraitData.Add(83000 + 15, portraitArr[15]);
        portraitData.Add(83000 + 16, portraitArr[16]);
        portraitData.Add(83000 + 17, portraitArr[17]);
        portraitData.Add(83000 + 18, portraitArr[18]);
        portraitData.Add(83000 + 19, portraitArr[19]);
        portraitData.Add(83000 + 20, portraitArr[20]);
        portraitData.Add(83000 + 21, portraitArr[21]);
        portraitData.Add(83000 + 22, portraitArr[22]);
        portraitData.Add(83000 + 23, portraitArr[23]);
        portraitData.Add(83000 + 24, portraitArr[24]);

        //3600->84000
        talkData.Add(84000, new string[] { "(타임캡슐의 비석이다.):0", "(비석에 어떤 글자가 적혀있다.):0", "[ E ]:24" });
        portraitData.Add(84000 + 0, portraitArr[0]);//보통
        portraitData.Add(84000 + 1, portraitArr[1]);//보통
        portraitData.Add(84000 + 2, portraitArr[2]);//보통
        portraitData.Add(84000 + 3, portraitArr[3]);
        portraitData.Add(84000 + 4, portraitArr[4]);
        portraitData.Add(84000 + 5, portraitArr[5]);
        portraitData.Add(84000 + 6, portraitArr[6]);
        portraitData.Add(84000 + 7, portraitArr[7]);
        portraitData.Add(84000 + 8, portraitArr[8]);
        portraitData.Add(84000 + 9, portraitArr[9]);
        portraitData.Add(84000 + 10, portraitArr[10]);
        portraitData.Add(84000 + 11, portraitArr[11]);
        portraitData.Add(84000 + 12, portraitArr[12]);
        portraitData.Add(84000 + 13, portraitArr[13]);
        portraitData.Add(84000 + 14, portraitArr[14]);
        portraitData.Add(84000 + 15, portraitArr[15]);
        portraitData.Add(84000 + 16, portraitArr[16]);
        portraitData.Add(84000 + 17, portraitArr[17]);
        portraitData.Add(84000 + 18, portraitArr[18]);
        portraitData.Add(84000 + 19, portraitArr[19]);
        portraitData.Add(84000 + 20, portraitArr[20]);
        portraitData.Add(84000 + 21, portraitArr[21]);
        portraitData.Add(84000 + 22, portraitArr[22]);
        portraitData.Add(84000 + 23, portraitArr[23]);
        portraitData.Add(84000 + 24, portraitArr[24]);

        //3500->85000
        talkData.Add(85000, new string[] { "(타임캡슐의 비석이다.):0", "(비석에 어떤 글자가 적혀있다.):0", "[ SE ]:24" });
        portraitData.Add(85000 + 0, portraitArr[0]);//보통
        portraitData.Add(85000 + 1, portraitArr[1]);//보통
        portraitData.Add(85000 + 2, portraitArr[2]);//보통
        portraitData.Add(85000 + 3, portraitArr[3]);
        portraitData.Add(85000 + 4, portraitArr[4]);
        portraitData.Add(85000 + 5, portraitArr[5]);
        portraitData.Add(85000 + 6, portraitArr[6]);
        portraitData.Add(85000 + 7, portraitArr[7]);
        portraitData.Add(85000 + 8, portraitArr[8]);
        portraitData.Add(85000 + 9, portraitArr[9]);
        portraitData.Add(85000 + 10, portraitArr[10]);
        portraitData.Add(85000 + 11, portraitArr[11]);
        portraitData.Add(85000 + 12, portraitArr[12]);
        portraitData.Add(85000 + 13, portraitArr[13]);
        portraitData.Add(85000 + 14, portraitArr[14]);
        portraitData.Add(85000 + 15, portraitArr[15]);
        portraitData.Add(85000 + 16, portraitArr[16]);
        portraitData.Add(85000 + 17, portraitArr[17]);
        portraitData.Add(85000 + 18, portraitArr[18]);
        portraitData.Add(85000 + 19, portraitArr[19]);
        portraitData.Add(85000 + 20, portraitArr[20]);
        portraitData.Add(85000 + 21, portraitArr[21]);
        portraitData.Add(85000 + 22, portraitArr[22]);
        portraitData.Add(85000 + 23, portraitArr[23]);
        portraitData.Add(85000 + 24, portraitArr[24]);
        
        //3400->86000
        talkData.Add(86000, new string[] { "(타임캡슐의 비석이다.):0", "(비석에 어떤 글자가 적혀있다.):0", "[ SW ]:24" });
        portraitData.Add(86000 + 0, portraitArr[0]);//보통
        portraitData.Add(86000 + 1, portraitArr[1]);//보통
        portraitData.Add(86000 + 2, portraitArr[2]);//보통
        portraitData.Add(86000 + 3, portraitArr[3]);
        portraitData.Add(86000 + 4, portraitArr[4]);
        portraitData.Add(86000 + 5, portraitArr[5]);
        portraitData.Add(86000 + 6, portraitArr[6]);
        portraitData.Add(86000 + 7, portraitArr[7]);
        portraitData.Add(86000 + 8, portraitArr[8]);
        portraitData.Add(86000 + 9, portraitArr[9]);
        portraitData.Add(86000 + 10, portraitArr[10]);
        portraitData.Add(86000 + 11, portraitArr[11]);
        portraitData.Add(86000 + 12, portraitArr[12]);
        portraitData.Add(86000 + 13, portraitArr[13]);
        portraitData.Add(86000 + 14, portraitArr[14]);
        portraitData.Add(86000 + 15, portraitArr[15]);
        portraitData.Add(86000 + 16, portraitArr[16]);
        portraitData.Add(86000 + 17, portraitArr[17]);
        portraitData.Add(86000 + 18, portraitArr[18]);
        portraitData.Add(86000 + 19, portraitArr[19]);
        portraitData.Add(86000 + 20, portraitArr[20]);
        portraitData.Add(86000 + 21, portraitArr[21]);
        portraitData.Add(86000 + 22, portraitArr[22]);
        portraitData.Add(86000 + 23, portraitArr[23]);
        portraitData.Add(86000 + 24, portraitArr[24]);

        //3300->87000
        talkData.Add(87000, new string[] { "(타임캡슐의 비석이다.):0", "(비석에 어떤 글자가 적혀있다.):0", "[ W ]:24" });
        portraitData.Add(87000 + 0, portraitArr[0]);//보통
        portraitData.Add(87000 + 1, portraitArr[1]);//보통
        portraitData.Add(87000 + 2, portraitArr[2]);//보통
        portraitData.Add(87000 + 3, portraitArr[3]);
        portraitData.Add(87000 + 4, portraitArr[4]);
        portraitData.Add(87000 + 5, portraitArr[5]);
        portraitData.Add(87000 + 6, portraitArr[6]);
        portraitData.Add(87000 + 7, portraitArr[7]);
        portraitData.Add(87000 + 8, portraitArr[8]);
        portraitData.Add(87000 + 9, portraitArr[9]);
        portraitData.Add(87000 + 10, portraitArr[10]);
        portraitData.Add(87000 + 11, portraitArr[11]);
        portraitData.Add(87000 + 12, portraitArr[12]);
        portraitData.Add(87000 + 13, portraitArr[13]);
        portraitData.Add(87000 + 14, portraitArr[14]);
        portraitData.Add(87000 + 15, portraitArr[15]);
        portraitData.Add(87000 + 16, portraitArr[16]);
        portraitData.Add(87000 + 17, portraitArr[17]);
        portraitData.Add(87000 + 18, portraitArr[18]);
        portraitData.Add(87000 + 19, portraitArr[19]);
        portraitData.Add(87000 + 20, portraitArr[20]);
        portraitData.Add(87000 + 21, portraitArr[21]);
        portraitData.Add(87000 + 22, portraitArr[22]);
        portraitData.Add(87000 + 23, portraitArr[23]);
        portraitData.Add(87000 + 24, portraitArr[24]);

        //3200->88000
        talkData.Add(88000, new string[] { "(타임캡슐의 비석이다.):0", "(비석에 어떤 글자가 적혀있다.):0", "[ NW ]:24" });
        portraitData.Add(88000 + 0, portraitArr[0]);//보통
        portraitData.Add(88000 + 1, portraitArr[1]);//보통
        portraitData.Add(88000 + 2, portraitArr[2]);//보통
        portraitData.Add(88000 + 3, portraitArr[3]);
        portraitData.Add(88000 + 4, portraitArr[4]);
        portraitData.Add(88000 + 5, portraitArr[5]);
        portraitData.Add(88000 + 6, portraitArr[6]);
        portraitData.Add(88000 + 7, portraitArr[7]);
        portraitData.Add(88000 + 8, portraitArr[8]);
        portraitData.Add(88000 + 9, portraitArr[9]);
        portraitData.Add(88000 + 10, portraitArr[10]);
        portraitData.Add(88000 + 11, portraitArr[11]);
        portraitData.Add(88000 + 12, portraitArr[12]);
        portraitData.Add(88000 + 13, portraitArr[13]);
        portraitData.Add(88000 + 14, portraitArr[14]);
        portraitData.Add(88000 + 15, portraitArr[15]);
        portraitData.Add(88000 + 16, portraitArr[16]);
        portraitData.Add(88000 + 17, portraitArr[17]);
        portraitData.Add(88000 + 18, portraitArr[18]);
        portraitData.Add(88000 + 19, portraitArr[19]);
        portraitData.Add(88000 + 20, portraitArr[20]);
        portraitData.Add(88000 + 21, portraitArr[21]);
        portraitData.Add(88000 + 22, portraitArr[22]);
        portraitData.Add(88000 + 23, portraitArr[23]);
        portraitData.Add(88000 + 24, portraitArr[24]);

        //타임캡슐의 달걀(왼)
       // talkData.Add(3900, new string[] { "(타임캡슐 모양을 한 분홍색 모형이다.):0" });
        //portraitData.Add(3900 + 0, portraitArr[0]);//보통

        //타임캡슐의 달걀(오)
        //talkData.Add(4000, new string[] { "(타임캡슐 모양을 한 푸른색 모형이다.):0" });
        //portraitData.Add(4000 + 0, portraitArr[0]);//보통

        //돌(사라질 거)
        talkData.Add(6100, new string[] { "(돌이다.):0" });
        portraitData.Add(6100 + 0, portraitArr[0]);//보통

        //돌(나타날 거)
        //**퀘스트 아이템 아님. 그냥 둘 거임.**
        //8200->89000
        talkData.Add(89000, new string[] { "(돌이다.):0" });
        portraitData.Add(89000 + 0, portraitArr[0]);//보통

        //돌 밑에 쪽지
        talkData.Add(61000, new string[] { "(붉은색 쪽지다.):0", "(쪽지에 어떤 글씨가 적혀 있다.):0", "[세 번째와 여섯 번째 글자는 같다.]:24" });
        portraitData.Add(61000 + 0, portraitArr[0]);//보통
        portraitData.Add(61000 + 1, portraitArr[1]);//보통
        portraitData.Add(61000 + 2, portraitArr[2]);//보통
        portraitData.Add(61000 + 3, portraitArr[3]);
        portraitData.Add(61000 + 4, portraitArr[4]);
        portraitData.Add(61000 + 5, portraitArr[5]);
        portraitData.Add(61000 + 6, portraitArr[6]);
        portraitData.Add(61000 + 7, portraitArr[7]);
        portraitData.Add(61000 + 8, portraitArr[8]);
        portraitData.Add(61000 + 9, portraitArr[9]);
        portraitData.Add(61000 + 10, portraitArr[10]);
        portraitData.Add(61000 + 11, portraitArr[11]);
        portraitData.Add(61000 + 12, portraitArr[12]);
        portraitData.Add(61000 + 13, portraitArr[13]);
        portraitData.Add(61000 + 14, portraitArr[14]);
        portraitData.Add(61000 + 15, portraitArr[15]);
        portraitData.Add(61000 + 16, portraitArr[16]);
        portraitData.Add(61000 + 17, portraitArr[17]);
        portraitData.Add(61000 + 18, portraitArr[18]);
        portraitData.Add(61000 + 19, portraitArr[19]);
        portraitData.Add(61000 + 20, portraitArr[20]);
        portraitData.Add(61000 + 21, portraitArr[21]);
        portraitData.Add(61000 + 22, portraitArr[22]);
        portraitData.Add(61000 + 23, portraitArr[23]);
        portraitData.Add(61000 + 24, portraitArr[24]);

        //고정될 텐트
        //8100->90000
        talkData.Add(90000, new string[] { "(돌로 고정된 텐트다.):0" });
        portraitData.Add(90000 + 0, portraitArr[0]);//보통
        /*portraitData.Add(4200 + 1, portraitArr[1]);//많이 놀람
        portraitData.Add(4200 + 2, portraitArr[2]);//졸림
        portraitData.Add(4200 + 3, portraitArr[3]);//웃음*/

        //텐트2
       /* talkData.Add(4200, new string[] { "(텐트다.):0" });
        portraitData.Add(4200 + 0, portraitArr[0]);//보통

        //텐트3
        talkData.Add(4300, new string[] { "(텐트다.):0" });
        portraitData.Add(4300 + 0, portraitArr[0]);//보통*/

        //텐트4
       /* talkData.Add(4400, new string[] { "(텐트다.):0" });
        portraitData.Add(4400 + 0, portraitArr[0]);//보통    */    

        //캠핑카1(사라질 예정)
        talkData.Add(4700, new string[] { "(캠핑카다.):0" });
        portraitData.Add(4700 + 0, portraitArr[0]);//보통

        //캠핑카1(남아있을 거)
        talkData.Add(62000, new string[] { "(캠핑카다.):0", "(문에 보라색 쪽지가 붙어있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[?? = 캠핑은 여러 번 해봤지만 캠핑카는 처음인걸? 뭘 가져갈까?]:24", "[?? = 갈아입을 옷, 수건, 간식거리도 챙겨야지. 얘들아, 너희 뭐 먹고 싶은 거 있니?]:24", "[??? = 난 과자!]:24", "[???? = 난 *주스*! 오렌지 *주스*! 아, *젤리*도!]:24" });
        portraitData.Add(62000 + 0, portraitArr[0]);//보통
        portraitData.Add(62000 + 1, portraitArr[1]);//보통
        portraitData.Add(62000 + 2, portraitArr[2]);//보통
        portraitData.Add(62000 + 3, portraitArr[3]);
        portraitData.Add(62000 + 4, portraitArr[4]);
        portraitData.Add(62000 + 5, portraitArr[5]);
        portraitData.Add(62000 + 6, portraitArr[6]);
        portraitData.Add(62000 + 7, portraitArr[7]);
        portraitData.Add(62000 + 8, portraitArr[8]);
        portraitData.Add(62000 + 9, portraitArr[9]);
        portraitData.Add(62000 + 10, portraitArr[10]);
        portraitData.Add(62000 + 11, portraitArr[11]);
        portraitData.Add(62000 + 12, portraitArr[12]);
        portraitData.Add(62000 + 13, portraitArr[13]);
        portraitData.Add(62000 + 14, portraitArr[14]);
        portraitData.Add(62000 + 15, portraitArr[15]);
        portraitData.Add(62000 + 16, portraitArr[16]);
        portraitData.Add(62000 + 17, portraitArr[17]);
        portraitData.Add(62000 + 18, portraitArr[18]);
        portraitData.Add(62000 + 19, portraitArr[19]);
        portraitData.Add(62000 + 20, portraitArr[20]);
        portraitData.Add(62000 + 21, portraitArr[21]);
        portraitData.Add(62000 + 22, portraitArr[22]);
        portraitData.Add(62000 + 23, portraitArr[23]);
        portraitData.Add(62000 + 24, portraitArr[24]);

        //캠핑카2
        /*talkData.Add(4800, new string[] { "(캠핑카다.):0" });
        portraitData.Add(4800 + 0, portraitArr[0]);//보통*/

        //캠핑카3
        /*talkData.Add(4900, new string[] { "(캠핑카다.):0" });
        portraitData.Add(4900 + 0, portraitArr[0]);//보통*/

        //캐라반1(사라질 예정)
        talkData.Add(5000, new string[] { "(카라반이다.):0" });
        portraitData.Add(5000 + 0, portraitArr[0]);//보통

        //캐라반1(남아있을 거)
        talkData.Add(64000, new string[] { "(카라반이다.):0", "(문에 보라색 쪽지가 붙어있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[4번째 글자는 모음이 아니다.]:24" });
        portraitData.Add(64000 + 0, portraitArr[0]);//보통
        portraitData.Add(64000 + 1, portraitArr[1]);//보통
        portraitData.Add(64000 + 2, portraitArr[2]);//보통
        portraitData.Add(64000 + 3, portraitArr[3]);
        portraitData.Add(64000 + 4, portraitArr[4]);
        portraitData.Add(64000 + 5, portraitArr[5]);
        portraitData.Add(64000 + 6, portraitArr[6]);
        portraitData.Add(64000 + 7, portraitArr[7]);
        portraitData.Add(64000 + 8, portraitArr[8]);
        portraitData.Add(64000 + 9, portraitArr[9]);
        portraitData.Add(64000 + 10, portraitArr[10]);
        portraitData.Add(64000 + 11, portraitArr[11]);
        portraitData.Add(64000 + 12, portraitArr[12]);
        portraitData.Add(64000 + 13, portraitArr[13]);
        portraitData.Add(64000 + 14, portraitArr[14]);
        portraitData.Add(64000 + 15, portraitArr[15]);
        portraitData.Add(64000 + 16, portraitArr[16]);
        portraitData.Add(64000 + 17, portraitArr[17]);
        portraitData.Add(64000 + 18, portraitArr[18]);
        portraitData.Add(64000 + 19, portraitArr[19]);
        portraitData.Add(64000 + 20, portraitArr[20]);
        portraitData.Add(64000 + 21, portraitArr[21]);
        portraitData.Add(64000 + 22, portraitArr[22]);
        portraitData.Add(64000 + 23, portraitArr[23]);
        portraitData.Add(64000 + 24, portraitArr[24]);

        //캐라반2
        /*talkData.Add(5100, new string[] { "(캐라반이다.):0" });
        portraitData.Add(5100 + 0, portraitArr[0]);//보통

        //캐라반3
        talkData.Add(5200, new string[] { "(캐라반이다.):0" });
        portraitData.Add(5200 + 0, portraitArr[0]);//보통*/

        //책상 왼(1)
        /*talkData.Add(5300, new string[] { "(책상이다.):0" });
        portraitData.Add(5300 + 0, portraitArr[0]);//보통*/

        //책상 왼(2)(사라질 예정)
        talkData.Add(5400, new string[] { "(책상이다.):0" });
        portraitData.Add(5400 + 0, portraitArr[0]);//보통

        //책상 왼(2)(태양 책이 놓인 책상)
        //사라지지 않음
        talkData.Add(66000, new string[] { "(책상이다.):0", "(책상 위에 태양 그림이 그려진 노트가 있다.):0", "(노트를 펼치자 어떤 글씨가 쓰여 있는 것이 보인다.):0", "[우리가 어렸을 적에 자주 놀던 그곳에 별이 있다.]:24" });
        portraitData.Add(66000 + 0, portraitArr[0]);//보통
        portraitData.Add(66000 + 1, portraitArr[1]);//보통
        portraitData.Add(66000 + 2, portraitArr[2]);//보통
        portraitData.Add(66000 + 3, portraitArr[3]);
        portraitData.Add(66000 + 4, portraitArr[4]);
        portraitData.Add(66000 + 5, portraitArr[5]);
        portraitData.Add(66000 + 6, portraitArr[6]);
        portraitData.Add(66000 + 7, portraitArr[7]);
        portraitData.Add(66000 + 8, portraitArr[8]);
        portraitData.Add(66000 + 9, portraitArr[9]);
        portraitData.Add(66000 + 10, portraitArr[10]);
        portraitData.Add(66000 + 11, portraitArr[11]);
        portraitData.Add(66000 + 12, portraitArr[12]);
        portraitData.Add(66000 + 13, portraitArr[13]);
        portraitData.Add(66000 + 14, portraitArr[14]);
        portraitData.Add(66000 + 15, portraitArr[15]);
        portraitData.Add(66000 + 16, portraitArr[16]);
        portraitData.Add(66000 + 17, portraitArr[17]);
        portraitData.Add(66000 + 18, portraitArr[18]);
        portraitData.Add(66000 + 19, portraitArr[19]);
        portraitData.Add(66000 + 20, portraitArr[20]);
        portraitData.Add(66000 + 21, portraitArr[21]);
        portraitData.Add(66000 + 22, portraitArr[22]);
        portraitData.Add(66000 + 23, portraitArr[23]);
        portraitData.Add(66000 + 24, portraitArr[24]);

        //책상 왼(3)(사라질 예정)
        talkData.Add(5500, new string[] { "(책상이다.):0" });
        portraitData.Add(5500 + 0, portraitArr[0]);//보통

        //책상 왼(3)(나타날 거)-파랑 쪽지
        talkData.Add(65000, new string[] { "(책상이다.):0", "(책상 위에 파란색 쪽지가 있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[여섯 글자 중 첫 번째 글자만 대문자다.]:24" });
        portraitData.Add(65000 + 0, portraitArr[0]);//보통
        portraitData.Add(65000 + 1, portraitArr[1]);//보통
        portraitData.Add(65000 + 2, portraitArr[2]);//보통
        portraitData.Add(65000 + 3, portraitArr[3]);
        portraitData.Add(65000 + 4, portraitArr[4]);
        portraitData.Add(65000 + 5, portraitArr[5]);
        portraitData.Add(65000 + 6, portraitArr[6]);
        portraitData.Add(65000 + 7, portraitArr[7]);
        portraitData.Add(65000 + 8, portraitArr[8]);
        portraitData.Add(65000 + 9, portraitArr[9]);
        portraitData.Add(65000 + 10, portraitArr[10]);
        portraitData.Add(65000 + 11, portraitArr[11]);
        portraitData.Add(65000 + 12, portraitArr[12]);
        portraitData.Add(65000 + 13, portraitArr[13]);
        portraitData.Add(65000 + 14, portraitArr[14]);
        portraitData.Add(65000 + 15, portraitArr[15]);
        portraitData.Add(65000 + 16, portraitArr[16]);
        portraitData.Add(65000 + 17, portraitArr[17]);
        portraitData.Add(65000 + 18, portraitArr[18]);
        portraitData.Add(65000 + 19, portraitArr[19]);
        portraitData.Add(65000 + 20, portraitArr[20]);
        portraitData.Add(65000 + 21, portraitArr[21]);
        portraitData.Add(65000 + 22, portraitArr[22]);
        portraitData.Add(65000 + 23, portraitArr[23]);
        portraitData.Add(65000 + 24, portraitArr[24]);

        //책상 오(1)
        /*talkData.Add(5600, new string[] { "(책상이다.):0" });
        portraitData.Add(5600 + 0, portraitArr[0]);//보통*/

        //책상 오(2)(사라질 예정)
        talkData.Add(5700, new string[] { "(책상이다.):0" });
        portraitData.Add(5700 + 0, portraitArr[0]);//보통

        //책상 오(2)-보라 쪽지
        talkData.Add(63000, new string[] { "(책상이다.):0", "(책상 위에 보라색 쪽지가 있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[네 번째 글자는 *사이에 있는 두 먹을 거리에 공통으로 들어간 글자 중 하나다.]:24" });
        portraitData.Add(63000 + 0, portraitArr[0]);//보통
        portraitData.Add(63000 + 1, portraitArr[1]);//보통
        portraitData.Add(63000 + 2, portraitArr[2]);//보통
        portraitData.Add(63000 + 3, portraitArr[3]);
        portraitData.Add(63000 + 4, portraitArr[4]);
        portraitData.Add(63000 + 5, portraitArr[5]);
        portraitData.Add(63000 + 6, portraitArr[6]);
        portraitData.Add(63000 + 7, portraitArr[7]);
        portraitData.Add(63000 + 8, portraitArr[8]);
        portraitData.Add(63000 + 9, portraitArr[9]);
        portraitData.Add(63000 + 10, portraitArr[10]);
        portraitData.Add(63000 + 11, portraitArr[11]);
        portraitData.Add(63000 + 12, portraitArr[12]);
        portraitData.Add(63000 + 13, portraitArr[13]);
        portraitData.Add(63000 + 14, portraitArr[14]);
        portraitData.Add(63000 + 15, portraitArr[15]);
        portraitData.Add(63000 + 16, portraitArr[16]);
        portraitData.Add(63000 + 17, portraitArr[17]);
        portraitData.Add(63000 + 18, portraitArr[18]);
        portraitData.Add(63000 + 19, portraitArr[19]);
        portraitData.Add(63000 + 20, portraitArr[20]);
        portraitData.Add(63000 + 21, portraitArr[21]);
        portraitData.Add(63000 + 22, portraitArr[22]);
        portraitData.Add(63000 + 23, portraitArr[23]);
        portraitData.Add(63000 + 24, portraitArr[24]);

        //책상 오(3)
        /*talkData.Add(5800, new string[] { "(책상이다.):0" });
        portraitData.Add(5800 + 0, portraitArr[0]);//보통*/

        //스위치(사라질 예정)
        talkData.Add(5900, new string[] { "(분수대 스위치가 들어있는 통이다.):0", "(스파크가 튀어서 함부로 만질 수 없다.):0" });
        portraitData.Add(5900 + 0, portraitArr[0]);//보통
        portraitData.Add(5900 + 1, portraitArr[1]);//보통
        portraitData.Add(5900 + 2, portraitArr[2]);//보통
        portraitData.Add(5900 + 3, portraitArr[3]);
        portraitData.Add(5900 + 4, portraitArr[4]);
        portraitData.Add(5900 + 5, portraitArr[5]);
        portraitData.Add(5900 + 6, portraitArr[6]);
        portraitData.Add(5900 + 7, portraitArr[7]);
        portraitData.Add(5900 + 8, portraitArr[8]);
        portraitData.Add(5900 + 9, portraitArr[9]);
        portraitData.Add(5900 + 10, portraitArr[10]);
        portraitData.Add(5900 + 11, portraitArr[11]);
        portraitData.Add(5900 + 12, portraitArr[12]);
        portraitData.Add(5900 + 13, portraitArr[13]);
        portraitData.Add(5900 + 14, portraitArr[14]);
        portraitData.Add(5900 + 15, portraitArr[15]);
        portraitData.Add(5900 + 16, portraitArr[16]);
        portraitData.Add(5900 + 17, portraitArr[17]);
        portraitData.Add(5900 + 18, portraitArr[18]);
        portraitData.Add(5900 + 19, portraitArr[19]);
        portraitData.Add(5900 + 20, portraitArr[20]);
        portraitData.Add(5900 + 21, portraitArr[21]);
        portraitData.Add(5900 + 22, portraitArr[22]);
        portraitData.Add(5900 + 23, portraitArr[23]);
        portraitData.Add(5900 + 24, portraitArr[24]);

        //망가진 스위치
        //8000->91000
        talkData.Add(91000, new string[] { "(분수대 스위치다.):0", "(다시 분수를 켜 볼까?):0", "철컥철컥...:24", "...:0", "(고장 난 것 같다...):2" });
        portraitData.Add(91000 + 0, portraitArr[0]);//보통
        portraitData.Add(91000 + 1, portraitArr[1]);//많이 놀람
        portraitData.Add(91000 + 2, portraitArr[2]);//졸림
        portraitData.Add(91000 + 3, portraitArr[3]);//웃음
        portraitData.Add(91000 + 4, portraitArr[4]);
        portraitData.Add(91000 + 5, portraitArr[5]);
        portraitData.Add(91000 + 6, portraitArr[6]);
        portraitData.Add(91000 + 7, portraitArr[7]);
        portraitData.Add(91000 + 8, portraitArr[8]);
        portraitData.Add(91000 + 9, portraitArr[9]);
        portraitData.Add(91000 + 10, portraitArr[10]);
        portraitData.Add(91000 + 11, portraitArr[11]);
        portraitData.Add(91000 + 12, portraitArr[12]);
        portraitData.Add(91000 + 13, portraitArr[13]);
        portraitData.Add(91000 + 14, portraitArr[14]);
        portraitData.Add(91000 + 15, portraitArr[15]);
        portraitData.Add(91000 + 16, portraitArr[16]);
        portraitData.Add(91000 + 17, portraitArr[17]);
        portraitData.Add(91000 + 18, portraitArr[18]);
        portraitData.Add(91000 + 19, portraitArr[19]);
        portraitData.Add(91000 + 20, portraitArr[20]);
        portraitData.Add(91000 + 21, portraitArr[21]);
        portraitData.Add(91000 + 22, portraitArr[22]);
        portraitData.Add(91000 + 23, portraitArr[23]);
        portraitData.Add(91000 + 24, portraitArr[24]);

        //양동이(일반)
        talkData.Add(6000, new string[] { "(양동이다.):0" });
        portraitData.Add(6000 + 0, portraitArr[0]);//보통

        //퀘스트 텐트
        talkData.Add(4100, new string[] { "(텐트다.):0", "(다른 텐트에 비해 연약해 보인다.):0" });
        portraitData.Add(4100 + 0, portraitArr[0]);//보통
        portraitData.Add(4100 + 1, portraitArr[1]);//보통
        portraitData.Add(4100 + 2, portraitArr[2]);//보통
        portraitData.Add(4100 + 3, portraitArr[3]);//보통
        portraitData.Add(4100 + 4, portraitArr[4]);//보통
        portraitData.Add(4100 + 5, portraitArr[5]);//보통
        portraitData.Add(4100 + 6, portraitArr[6]);//보통
        portraitData.Add(4100 + 7, portraitArr[7]);//보통
        portraitData.Add(4100 + 8, portraitArr[8]);//보통
        portraitData.Add(4100 + 9, portraitArr[9]);//보통
        portraitData.Add(4100 + 10, portraitArr[10]);//보통
        portraitData.Add(4100 + 11, portraitArr[11]);//보통
        portraitData.Add(4100 + 12, portraitArr[12]);//보통
        portraitData.Add(4100 + 13, portraitArr[13]);//보통
        portraitData.Add(4100 + 14, portraitArr[14]);//보통
        portraitData.Add(4100 + 15, portraitArr[15]);//보통
        portraitData.Add(4100 + 16, portraitArr[16]);//보통
        portraitData.Add(4100 + 17, portraitArr[17]);//보통
        portraitData.Add(4100 + 18, portraitArr[18]);//보통

        talkData.Add(2900, new string[] { "(타임캡슐의 비석이다.):0", "(물에 젖은 일부분이 붉게 보인다.):0", "물을 부으면 뭔가가 달라질 것 같은데...:0", "(비석에 어떤 글자가 적혀있다.):0", "[ N ]:24" });
        portraitData.Add(2900 + 0, portraitArr[0]);//보통
        portraitData.Add(2900 + 1, portraitArr[1]);//보통
        portraitData.Add(2900 + 2, portraitArr[2]);//보통
        portraitData.Add(2900 + 3, portraitArr[3]);
        portraitData.Add(2900 + 4, portraitArr[4]);
        portraitData.Add(2900 + 5, portraitArr[5]);
        portraitData.Add(2900 + 6, portraitArr[6]);
        portraitData.Add(2900 + 7, portraitArr[7]);
        portraitData.Add(2900 + 8, portraitArr[8]);
        portraitData.Add(2900 + 9, portraitArr[9]);
        portraitData.Add(2900 + 10, portraitArr[10]);
        portraitData.Add(2900 + 11, portraitArr[11]);
        portraitData.Add(2900 + 12, portraitArr[12]);
        portraitData.Add(2900 + 13, portraitArr[13]);
        portraitData.Add(2900 + 14, portraitArr[14]);
        portraitData.Add(2900 + 15, portraitArr[15]);
        portraitData.Add(2900 + 16, portraitArr[16]);
        portraitData.Add(2900 + 17, portraitArr[17]);
        portraitData.Add(2900 + 18, portraitArr[18]);
        portraitData.Add(2900 + 19, portraitArr[19]);
        portraitData.Add(2900 + 20, portraitArr[20]);
        portraitData.Add(2900 + 21, portraitArr[21]);
        portraitData.Add(2900 + 22, portraitArr[22]);
        portraitData.Add(2900 + 23, portraitArr[23]);
        portraitData.Add(2900 + 24, portraitArr[24]);

        talkData.Add(3100, new string[] { "(타임캡슐의 비석이다.):0", "(물에 젖은 일부분이 푸르게 보인다.):0", "물을 부으면 뭔가가 달라질 것 같은데...:0", "(비석에 어떤 글자가 적혀있다.):0", "[ S ]:24" });
        portraitData.Add(3100 + 0, portraitArr[0]);//보통
        portraitData.Add(3100 + 1, portraitArr[1]);//보통
        portraitData.Add(3100 + 2, portraitArr[2]);//보통
        portraitData.Add(3100 + 3, portraitArr[3]);
        portraitData.Add(3100 + 4, portraitArr[4]);
        portraitData.Add(3100 + 5, portraitArr[5]);
        portraitData.Add(3100 + 6, portraitArr[6]);
        portraitData.Add(3100 + 7, portraitArr[7]);
        portraitData.Add(3100 + 8, portraitArr[8]);
        portraitData.Add(3100 + 9, portraitArr[9]);
        portraitData.Add(3100 + 10, portraitArr[10]);
        portraitData.Add(3100 + 11, portraitArr[11]);
        portraitData.Add(3100 + 12, portraitArr[12]);
        portraitData.Add(3100 + 13, portraitArr[13]);
        portraitData.Add(3100 + 14, portraitArr[14]);
        portraitData.Add(3100 + 15, portraitArr[15]);
        portraitData.Add(3100 + 16, portraitArr[16]);
        portraitData.Add(3100 + 17, portraitArr[17]);
        portraitData.Add(3100 + 18, portraitArr[18]);
        portraitData.Add(3100 + 19, portraitArr[19]);
        portraitData.Add(3100 + 20, portraitArr[20]);
        portraitData.Add(3100 + 21, portraitArr[21]);
        portraitData.Add(3100 + 22, portraitArr[22]);
        portraitData.Add(3100 + 23, portraitArr[23]);
        portraitData.Add(3100 + 24, portraitArr[24]);

        //빨간색 타임캡슐
        //3700->92000
        talkData.Add(92000, new string[] { "(빨갛게 물든 비석이다.):0", "비석에 [ N ]이라고 적힌 글씨가 선명하게 보인다.:0" });
        portraitData.Add(92000 + 0, portraitArr[0]);//보통


        //파랑색 타임캡슐
        //3800->93000
        talkData.Add(93000, new string[] { "(파랗게 물든 비석이다.):0", "비석에 [ S ]이라고 적힌 글씨가 선명하게 보인다.:0" });
        portraitData.Add(93000 + 0, portraitArr[0]);//보통

        //스테이지3
        talkData.Add(54000, new string[] { "(이전 장소로 가는 문이다.):17", "방금까지 분명 열려있었는데...?:17", "(비밀번호도, 열쇠구멍도 없다...):17", "(손잡이를 돌려봐도 열리지 않는다...):17" });
        portraitData.Add(54000 + 0, portraitArr[0]);
        portraitData.Add(54000 + 1, portraitArr[1]);
        portraitData.Add(54000 + 2, portraitArr[2]);
        portraitData.Add(54000 + 3, portraitArr[3]);
        portraitData.Add(54000 + 4, portraitArr[4]);
        portraitData.Add(54000 + 5, portraitArr[5]);
        portraitData.Add(54000 + 6, portraitArr[6]);
        portraitData.Add(54000 + 7, portraitArr[7]);
        portraitData.Add(54000 + 8, portraitArr[8]);
        portraitData.Add(54000 + 9, portraitArr[9]);
        portraitData.Add(54000 + 10, portraitArr[10]);
        portraitData.Add(54000 + 11, portraitArr[11]);
        portraitData.Add(54000 + 12, portraitArr[12]);
        portraitData.Add(54000 + 13, portraitArr[13]);
        portraitData.Add(54000 + 14, portraitArr[14]);
        portraitData.Add(54000 + 15, portraitArr[15]);
        portraitData.Add(54000 + 16, portraitArr[16]);
        portraitData.Add(54000 + 17, portraitArr[17]);
        portraitData.Add(54000 + 18, portraitArr[18]);
        portraitData.Add(54000 + 19, portraitArr[19]);
        portraitData.Add(54000 + 20, portraitArr[20]);
        portraitData.Add(54000 + 21, portraitArr[21]);
        portraitData.Add(54000 + 22, portraitArr[22]);
        portraitData.Add(54000 + 23, portraitArr[23]);
        portraitData.Add(54000 + 24, portraitArr[24]);


        talkData.Add(9500, new string[] { "(다음 장소로 가는 문이다.):17", "(...하루빨리 이곳을 벗어나고 싶다):17" });
        portraitData.Add(9500 + 0, portraitArr[0]);
        portraitData.Add(9500 + 1, portraitArr[1]);
        portraitData.Add(9500 + 2, portraitArr[2]);
        portraitData.Add(9500 + 3, portraitArr[3]);
        portraitData.Add(9500 + 4, portraitArr[4]);
        portraitData.Add(9500 + 5, portraitArr[5]);
        portraitData.Add(9500 + 6, portraitArr[6]);
        portraitData.Add(9500 + 7, portraitArr[7]);
        portraitData.Add(9500 + 8, portraitArr[8]);
        portraitData.Add(9500 + 9, portraitArr[9]);
        portraitData.Add(9500 + 10, portraitArr[10]);
        portraitData.Add(9500 + 11, portraitArr[11]);
        portraitData.Add(9500 + 12, portraitArr[12]);
        portraitData.Add(9500 + 13, portraitArr[13]);
        portraitData.Add(9500 + 14, portraitArr[14]);
        portraitData.Add(9500 + 15, portraitArr[15]);
        portraitData.Add(9500 + 16, portraitArr[16]);
        portraitData.Add(9500 + 17, portraitArr[17]);
        portraitData.Add(9500 + 18, portraitArr[18]);
        portraitData.Add(9500 + 19, portraitArr[19]);
        portraitData.Add(9500 + 20, portraitArr[20]);
        portraitData.Add(9500 + 21, portraitArr[21]);
        portraitData.Add(9500 + 22, portraitArr[22]);
        portraitData.Add(9500 + 23, portraitArr[23]);
        portraitData.Add(9500 + 24, portraitArr[24]);


        talkData.Add(4200, new string[] { "힘이 들면 크게 심호흡하고, 주위를 넓게 봐.:4", "그러면 서서히 보이기 시작할 거야.:4" });
        portraitData.Add(4200 + 0, portraitArr[0]);
        portraitData.Add(4200 + 1, portraitArr[1]);
        portraitData.Add(4200 + 2, portraitArr[2]);
        portraitData.Add(4200 + 3, portraitArr[3]);
        portraitData.Add(4200 + 4, portraitArr[4]);
        portraitData.Add(4200 + 5, portraitArr[5]);
        portraitData.Add(4200 + 6, portraitArr[6]);
        portraitData.Add(4200 + 7, portraitArr[7]);
        portraitData.Add(4200 + 8, portraitArr[8]);
        portraitData.Add(4200 + 9, portraitArr[9]);
        portraitData.Add(4200 + 10, portraitArr[10]);
        portraitData.Add(4200 + 11, portraitArr[11]);
        portraitData.Add(4200 + 12, portraitArr[12]);
        portraitData.Add(4200 + 13, portraitArr[13]);
        portraitData.Add(4200 + 14, portraitArr[14]);
        portraitData.Add(4200 + 15, portraitArr[15]);
        portraitData.Add(4200 + 16, portraitArr[16]);
        portraitData.Add(4200 + 17, portraitArr[17]);
        portraitData.Add(4200 + 18, portraitArr[18]);
        portraitData.Add(4200 + 19, portraitArr[19]);
        portraitData.Add(4200 + 20, portraitArr[20]);
        portraitData.Add(4200 + 21, portraitArr[21]);
        portraitData.Add(4200 + 22, portraitArr[22]);

        talkData.Add(46000, new string[] { "(비행기표다.):17", "[ 왼쪽에서 오른쪽으로 A ~ F, 앞에서 뒤로 1 ~ 10 ]이란 안내 문구와 함께 좌석번호가 적혀 있다.:17", "(표에 적힌 좌석번호는 F7이다.):17" });
        portraitData.Add(46000 + 0, portraitArr[0]);
        portraitData.Add(46000 + 1, portraitArr[1]);
        portraitData.Add(46000 + 2, portraitArr[2]);
        portraitData.Add(46000 + 3, portraitArr[3]);
        portraitData.Add(46000 + 4, portraitArr[4]);
        portraitData.Add(46000 + 5, portraitArr[5]);
        portraitData.Add(46000 + 6, portraitArr[6]);
        portraitData.Add(46000 + 7, portraitArr[7]);
        portraitData.Add(46000 + 8, portraitArr[8]);
        portraitData.Add(46000 + 9, portraitArr[9]);
        portraitData.Add(46000 + 10, portraitArr[10]);
        portraitData.Add(46000 + 11, portraitArr[11]);
        portraitData.Add(46000 + 12, portraitArr[12]);
        portraitData.Add(46000 + 13, portraitArr[13]);
        portraitData.Add(46000 + 14, portraitArr[14]);
        portraitData.Add(46000 + 15, portraitArr[15]);
        portraitData.Add(46000 + 16, portraitArr[16]);
        portraitData.Add(46000 + 17, portraitArr[17]);

        talkData.Add(6600, new string[] { "(F7 좌석이다.):17" });
        portraitData.Add(6600 + 0, portraitArr[0]);
        portraitData.Add(6600 + 1, portraitArr[1]);
        portraitData.Add(6600 + 2, portraitArr[2]);
        portraitData.Add(6600 + 3, portraitArr[3]);
        portraitData.Add(6600 + 4, portraitArr[4]);
        portraitData.Add(6600 + 5, portraitArr[5]);
        portraitData.Add(6600 + 6, portraitArr[6]);
        portraitData.Add(6600 + 7, portraitArr[7]);
        portraitData.Add(6600 + 8, portraitArr[8]);
        portraitData.Add(6600 + 9, portraitArr[9]);
        portraitData.Add(6600 + 10, portraitArr[10]);
        portraitData.Add(6600 + 11, portraitArr[11]);
        portraitData.Add(6600 + 12, portraitArr[12]);
        portraitData.Add(6600 + 13, portraitArr[13]);
        portraitData.Add(6600 + 14, portraitArr[14]);
        portraitData.Add(6600 + 15, portraitArr[15]);
        portraitData.Add(6600 + 16, portraitArr[16]);
        portraitData.Add(6600 + 17, portraitArr[17]);

        talkData.Add(49000, new string[] { "(...붉게 물든 의자다.):16" });
        portraitData.Add(49000 + 0, portraitArr[0]);
        portraitData.Add(49000 + 1, portraitArr[1]);
        portraitData.Add(49000 + 2, portraitArr[2]);
        portraitData.Add(49000 + 3, portraitArr[3]);
        portraitData.Add(49000 + 4, portraitArr[4]);
        portraitData.Add(49000 + 5, portraitArr[5]);
        portraitData.Add(49000 + 6, portraitArr[6]);
        portraitData.Add(49000 + 7, portraitArr[7]);
        portraitData.Add(49000 + 8, portraitArr[8]);
        portraitData.Add(49000 + 9, portraitArr[9]);
        portraitData.Add(49000 + 10, portraitArr[10]);
        portraitData.Add(49000 + 11, portraitArr[11]);
        portraitData.Add(49000 + 12, portraitArr[12]);
        portraitData.Add(49000 + 13, portraitArr[13]);
        portraitData.Add(49000 + 14, portraitArr[14]);
        portraitData.Add(49000 + 15, portraitArr[15]);
        portraitData.Add(49000 + 16, portraitArr[16]);
        portraitData.Add(49000 + 17, portraitArr[17]);
        portraitData.Add(49000 + 18, portraitArr[18]);
        portraitData.Add(49000 + 19, portraitArr[19]);
        portraitData.Add(49000 + 20, portraitArr[20]);
        portraitData.Add(49000 + 21, portraitArr[21]);
        portraitData.Add(49000 + 22, portraitArr[22]);
        portraitData.Add(49000 + 23, portraitArr[23]);
        portraitData.Add(49000 + 24, portraitArr[24]);
        portraitData.Add(49000 + 25, portraitArr[25]);

        talkData.Add(4300, new string[] { ".....:10" });
        portraitData.Add(4300 + 0, portraitArr[0]);
        portraitData.Add(4300 + 1, portraitArr[1]);
        portraitData.Add(4300 + 2, portraitArr[2]);
        portraitData.Add(4300 + 3, portraitArr[3]);
        portraitData.Add(4300 + 4, portraitArr[4]);
        portraitData.Add(4300 + 5, portraitArr[5]);
        portraitData.Add(4300 + 6, portraitArr[6]);
        portraitData.Add(4300 + 7, portraitArr[7]);
        portraitData.Add(4300 + 8, portraitArr[8]);
        portraitData.Add(4300 + 9, portraitArr[9]);
        portraitData.Add(4300 + 10, portraitArr[10]);
        portraitData.Add(4300 + 11, portraitArr[11]);
        portraitData.Add(4300 + 12, portraitArr[12]);
        portraitData.Add(4300 + 13, portraitArr[13]);
        portraitData.Add(4300 + 14, portraitArr[14]);
        portraitData.Add(4300 + 15, portraitArr[15]);
        portraitData.Add(4300 + 16, portraitArr[16]);
        portraitData.Add(4300 + 17, portraitArr[17]);

        //talkData.Add(7000, new string[] { "(구명조끼다.):17", "(곳곳에 그을린 흔적이 있다.):17", "(...무슨 사고라도 있었던 걸까?):17" });
        /*portraitData.Add(7000 + 0, portraitArr[0]);
        portraitData.Add(7000 + 1, portraitArr[1]);
        portraitData.Add(7000 + 2, portraitArr[2]);
        portraitData.Add(7000 + 3, portraitArr[3]);
        portraitData.Add(7000 + 4, portraitArr[4]);
        portraitData.Add(7000 + 5, portraitArr[5]);
        portraitData.Add(7000 + 6, portraitArr[6]);
        portraitData.Add(7000 + 7, portraitArr[7]);
        portraitData.Add(7000 + 8, portraitArr[8]);
        portraitData.Add(7000 + 9, portraitArr[9]);
        portraitData.Add(7000 + 10, portraitArr[10]);
        portraitData.Add(7000 + 11, portraitArr[11]);
        portraitData.Add(7000 + 12, portraitArr[12]);
        portraitData.Add(7000 + 13, portraitArr[13]);
        portraitData.Add(7000 + 14, portraitArr[14]);
        portraitData.Add(7000 + 15, portraitArr[15]);
        portraitData.Add(7000 + 16, portraitArr[16]);
        portraitData.Add(7000 + 17, portraitArr[17]);*/

        talkData.Add(51000, new string[] { "(그을린 자국이 있는 가방이다.):17", "(왠지 누구의 것인지 어렴풋이 짐작이 간다...):19" });
        portraitData.Add(51000 + 0, portraitArr[0]);
        portraitData.Add(51000 + 1, portraitArr[1]);
        portraitData.Add(51000 + 2, portraitArr[2]);
        portraitData.Add(51000 + 3, portraitArr[3]);
        portraitData.Add(51000 + 4, portraitArr[4]);
        portraitData.Add(51000 + 5, portraitArr[5]);
        portraitData.Add(51000 + 6, portraitArr[6]);
        portraitData.Add(51000 + 7, portraitArr[7]);
        portraitData.Add(51000 + 8, portraitArr[8]);
        portraitData.Add(51000 + 9, portraitArr[9]);
        portraitData.Add(51000 + 10, portraitArr[10]);
        portraitData.Add(51000 + 11, portraitArr[11]);
        portraitData.Add(51000 + 12, portraitArr[12]);
        portraitData.Add(51000 + 13, portraitArr[13]);
        portraitData.Add(51000 + 14, portraitArr[14]);
        portraitData.Add(51000 + 15, portraitArr[15]);
        portraitData.Add(51000 + 16, portraitArr[16]);
        portraitData.Add(51000 + 17, portraitArr[17]);
        portraitData.Add(51000 + 18, portraitArr[18]);
        portraitData.Add(51000 + 19, portraitArr[19]);
        portraitData.Add(51000 + 20, portraitArr[20]);
        portraitData.Add(51000 + 21, portraitArr[21]);
        portraitData.Add(51000 + 22, portraitArr[22]);
        portraitData.Add(51000 + 23, portraitArr[23]);
        portraitData.Add(51000 + 24, portraitArr[24]);

        talkData.Add(56000, new string[] { "(라디오다.):17", "(다이얼을 돌려서 주파수를 맞춰봤다.):17", "치지직...:0", "어떤 소리가 들리기 시작한다.:0", "[ 오늘 오전 11시경 제주도로 향하던 비행기가 폭발로 인해 추락하는 사고가 발생했습니다. ]:24", "[ 해당 비행기에는 수학여행을 가던 ‘서안 고등학교’학생들이 탑승하고 있었던 것으로 알려져... ]:24", "(뒷 내용은 들리지 않는다.):2" });
        portraitData.Add(56000 + 0, portraitArr[0]);
        portraitData.Add(56000 + 1, portraitArr[1]);
        portraitData.Add(56000 + 2, portraitArr[2]);
        portraitData.Add(56000 + 3, portraitArr[3]);
        portraitData.Add(56000 + 4, portraitArr[4]);
        portraitData.Add(56000 + 5, portraitArr[5]);
        portraitData.Add(56000 + 6, portraitArr[6]);
        portraitData.Add(56000 + 7, portraitArr[7]);
        portraitData.Add(56000 + 8, portraitArr[8]);
        portraitData.Add(56000 + 9, portraitArr[9]);
        portraitData.Add(56000 + 10, portraitArr[10]);
        portraitData.Add(56000 + 11, portraitArr[11]);
        portraitData.Add(56000 + 12, portraitArr[12]);
        portraitData.Add(56000 + 13, portraitArr[13]);
        portraitData.Add(56000 + 14, portraitArr[14]);
        portraitData.Add(56000 + 15, portraitArr[15]);
        portraitData.Add(56000 + 16, portraitArr[16]);
        portraitData.Add(56000 + 17, portraitArr[17]);
        portraitData.Add(56000 + 18, portraitArr[18]);
        portraitData.Add(56000 + 19, portraitArr[19]);
        portraitData.Add(56000 + 20, portraitArr[20]);
        portraitData.Add(56000 + 21, portraitArr[21]);
        portraitData.Add(56000 + 22, portraitArr[22]);
        portraitData.Add(56000 + 23, portraitArr[23]);
        portraitData.Add(56000 + 24, portraitArr[24]);

        talkData.Add(52000, new string[] { "(스마트폰이다.):17", "(화면을 켜보니 누군가에게 문자를 보낸 흔적이 있다.):0", "(수신자는 ‘김한별’이다.):0", "...나다.:17", "(문자 내용을 읽어보았다.):17", "[ 형. 비행기가 뭔가 이상해. 창밖을 보는데 검은 연기가 보여... ]:24", "(다른 내용은 보이지 않는다.):17", "(메인화면으로 돌아가 휴대폰 주인의 이름을 확인해봤다.):17", "(...'김선진'이다.):14", "(.....):19" });
        portraitData.Add(52000 + 0, portraitArr[0]);
        portraitData.Add(52000 + 1, portraitArr[1]);
        portraitData.Add(52000 + 2, portraitArr[2]);
        portraitData.Add(52000 + 3, portraitArr[3]);
        portraitData.Add(52000 + 4, portraitArr[4]);
        portraitData.Add(52000 + 5, portraitArr[5]);
        portraitData.Add(52000 + 6, portraitArr[6]);
        portraitData.Add(52000 + 7, portraitArr[7]);
        portraitData.Add(52000 + 8, portraitArr[8]);
        portraitData.Add(52000 + 9, portraitArr[9]);
        portraitData.Add(52000 + 10, portraitArr[10]);
        portraitData.Add(52000 + 11, portraitArr[11]);
        portraitData.Add(52000 + 12, portraitArr[12]);
        portraitData.Add(52000 + 13, portraitArr[13]);
        portraitData.Add(52000 + 14, portraitArr[14]);
        portraitData.Add(52000 + 15, portraitArr[15]);
        portraitData.Add(52000 + 16, portraitArr[16]);
        portraitData.Add(52000 + 17, portraitArr[17]);
        portraitData.Add(52000 + 18, portraitArr[18]);
        portraitData.Add(52000 + 19, portraitArr[19]);
        portraitData.Add(52000 + 20, portraitArr[20]);
        portraitData.Add(52000 + 21, portraitArr[21]);
        portraitData.Add(52000 + 22, portraitArr[22]);
        portraitData.Add(52000 + 23, portraitArr[23]);
        portraitData.Add(52000 + 24, portraitArr[24]);



        //** 스테이지4 **

        //오른쪽 문
        talkData.Add(18000, new string[] { "(제단으로 가는 문이다.):0","(별의 조각을 다 찾을 때까진 갈 수 없다.):0" });
        portraitData.Add(18000 + 0, portraitArr[0]);
        portraitData.Add(18000 + 1, portraitArr[1]);
        portraitData.Add(18000 + 2, portraitArr[2]);
        portraitData.Add(18000 + 3, portraitArr[3]);
        portraitData.Add(18000 + 4, portraitArr[4]);

        //NPC1
        talkData.Add(11000, new string[] { "이다음은 제단이야.:4", "제단으로 가기 전에 해야 할 게 있지 않아?:4" });
        portraitData.Add(11000 + 0, portraitArr[0]);
        portraitData.Add(11000 + 1, portraitArr[1]);
        portraitData.Add(11000 + 2, portraitArr[2]);
        portraitData.Add(11000 + 3, portraitArr[3]);
        portraitData.Add(11000 + 4, portraitArr[4]);
        portraitData.Add(11000 + 5, portraitArr[5]);
        portraitData.Add(11000 + 6, portraitArr[6]);
        portraitData.Add(11000 + 7, portraitArr[7]);
        portraitData.Add(11000 + 8, portraitArr[8]);
        portraitData.Add(11000 + 9, portraitArr[9]);
        portraitData.Add(11000 + 10, portraitArr[10]);
        portraitData.Add(11000 + 11, portraitArr[11]);
        portraitData.Add(11000 + 12, portraitArr[12]);
        portraitData.Add(11000 + 13, portraitArr[13]);
        portraitData.Add(11000 + 14, portraitArr[14]);
        portraitData.Add(11000 + 15, portraitArr[15]);
        portraitData.Add(11000 + 16, portraitArr[16]);
        portraitData.Add(11000 + 17, portraitArr[17]);
        portraitData.Add(11000 + 18, portraitArr[18]);
        portraitData.Add(11000 + 19, portraitArr[19]);
        portraitData.Add(11000 + 20, portraitArr[20]);
        portraitData.Add(11000 + 21, portraitArr[21]);
        portraitData.Add(11000 + 22, portraitArr[22]);
        portraitData.Add(11000 + 23, portraitArr[23]);
        portraitData.Add(11000 + 24, portraitArr[24]);
        portraitData.Add(11000 + 25, portraitArr[25]);
        portraitData.Add(11000 + 26, portraitArr[26]);
        portraitData.Add(11000 + 27, portraitArr[27]);
        portraitData.Add(11000 + 28, portraitArr[28]);
        portraitData.Add(11000 + 29, portraitArr[29]);
        portraitData.Add(11000 + 30, portraitArr[30]);
        portraitData.Add(11000 + 31, portraitArr[31]);
        portraitData.Add(11000 + 32, portraitArr[32]);
        portraitData.Add(11000 + 33, portraitArr[33]);
        portraitData.Add(11000 + 34, portraitArr[34]);
        portraitData.Add(11000 + 35, portraitArr[35]);

        //달력
        talkData.Add(12000, new string[] { "(달력이다.):0", "(달력의 10월 2일에 동그라미가 처져있다.):0", "('이사 온 날'이라 적혀 있다.):0" });
        portraitData.Add(12000 + 0, portraitArr[0]);
        portraitData.Add(12000 + 1, portraitArr[1]);
        portraitData.Add(12000 + 2, portraitArr[2]);
        portraitData.Add(12000 + 3, portraitArr[3]);
        portraitData.Add(12000 + 4, portraitArr[4]);
        portraitData.Add(12000 + 5, portraitArr[5]);
        portraitData.Add(12000 + 6, portraitArr[6]);
        portraitData.Add(12000 + 7, portraitArr[7]);
        portraitData.Add(12000 + 8, portraitArr[8]);
        portraitData.Add(12000 + 9, portraitArr[9]);
        portraitData.Add(12000 + 10, portraitArr[10]);
        portraitData.Add(12000 + 11, portraitArr[11]);
        portraitData.Add(12000 + 12, portraitArr[12]);
        portraitData.Add(12000 + 13, portraitArr[13]);
        portraitData.Add(12000 + 14, portraitArr[14]);
        portraitData.Add(12000 + 15, portraitArr[15]);
        portraitData.Add(12000 + 16, portraitArr[16]);
        portraitData.Add(12000 + 17, portraitArr[17]);
        portraitData.Add(12000 + 18, portraitArr[18]);

        //창문 옆 액자
        talkData.Add(13000, new string[] { "(액자다.):0", "(액자 속 사진을 확인해 봤다.):0", "(야구장 앞에서 찍은 사진이다.):0", "(2번째 공간에서 본 야구장과 똑같이 생겼다.):0", "(사진 속엔 두 사람이 있다.):0", "(한 사람은 나다.):26", "(그리고 그 옆에 있는 사람은...):27", ".....:32" });
        portraitData.Add(13000 + 0, portraitArr[0]);
        portraitData.Add(13000 + 1, portraitArr[1]);
        portraitData.Add(13000 + 2, portraitArr[2]);
        portraitData.Add(13000 + 3, portraitArr[3]);
        portraitData.Add(13000 + 4, portraitArr[4]);
        portraitData.Add(13000 + 5, portraitArr[5]);
        portraitData.Add(13000 + 6, portraitArr[6]);
        portraitData.Add(13000 + 7, portraitArr[7]);
        portraitData.Add(13000 + 8, portraitArr[8]);
        portraitData.Add(13000 + 9, portraitArr[9]);
        portraitData.Add(13000 + 10, portraitArr[10]);
        portraitData.Add(13000 + 11, portraitArr[11]);
        portraitData.Add(13000 + 12, portraitArr[12]);
        portraitData.Add(13000 + 13, portraitArr[13]);
        portraitData.Add(13000 + 14, portraitArr[14]);
        portraitData.Add(13000 + 15, portraitArr[15]);
        portraitData.Add(13000 + 16, portraitArr[16]);
        portraitData.Add(13000 + 17, portraitArr[17]);
        portraitData.Add(13000 + 18, portraitArr[18]);
        portraitData.Add(13000 + 19, portraitArr[19]);
        portraitData.Add(13000 + 20, portraitArr[20]);
        portraitData.Add(13000 + 21, portraitArr[21]);
        portraitData.Add(13000 + 22, portraitArr[22]);
        portraitData.Add(13000 + 23, portraitArr[23]);
        portraitData.Add(13000 + 24, portraitArr[24]);
        portraitData.Add(13000 + 25, portraitArr[25]);
        portraitData.Add(13000 + 26, portraitArr[26]);
        portraitData.Add(13000 + 27, portraitArr[27]);
        portraitData.Add(13000 + 28, portraitArr[28]);
        portraitData.Add(13000 + 29, portraitArr[29]);
        portraitData.Add(13000 + 30, portraitArr[30]);
        portraitData.Add(13000 + 31, portraitArr[31]);
        portraitData.Add(13000 + 32, portraitArr[32]);

        //의자 위 액자
        talkData.Add(14000, new string[] { "(액자가 있다.):0", "(액자 속 사진의 배경은 카라반이다.):0", "(역시나 2번째 공간에서 본 곳이다.):0", "(사진 속엔 나와...):28", "(한 남자가 찍혀 있다.):29", "(이 사람은...):32" });
        portraitData.Add(14000 + 0, portraitArr[0]);
        portraitData.Add(14000 + 1, portraitArr[1]);
        portraitData.Add(14000 + 2, portraitArr[2]);
        portraitData.Add(14000 + 3, portraitArr[3]);
        portraitData.Add(14000 + 4, portraitArr[4]);
        portraitData.Add(14000 + 5, portraitArr[5]);
        portraitData.Add(14000 + 6, portraitArr[6]);
        portraitData.Add(14000 + 7, portraitArr[7]);
        portraitData.Add(14000 + 8, portraitArr[8]);
        portraitData.Add(14000 + 9, portraitArr[9]);
        portraitData.Add(14000 + 10, portraitArr[10]);
        portraitData.Add(14000 + 11, portraitArr[11]);
        portraitData.Add(14000 + 12, portraitArr[12]);
        portraitData.Add(14000 + 13, portraitArr[13]);
        portraitData.Add(14000 + 14, portraitArr[14]);
        portraitData.Add(14000 + 15, portraitArr[15]);
        portraitData.Add(14000 + 16, portraitArr[16]);
        portraitData.Add(14000 + 17, portraitArr[17]);
        portraitData.Add(14000 + 18, portraitArr[18]);
        portraitData.Add(14000 + 19, portraitArr[19]);
        portraitData.Add(14000 + 20, portraitArr[20]);
        portraitData.Add(14000 + 21, portraitArr[21]);
        portraitData.Add(14000 + 22, portraitArr[22]);
        portraitData.Add(14000 + 23, portraitArr[23]);
        portraitData.Add(14000 + 24, portraitArr[24]);
        portraitData.Add(14000 + 25, portraitArr[25]);
        portraitData.Add(14000 + 26, portraitArr[26]);
        portraitData.Add(14000 + 27, portraitArr[27]);
        portraitData.Add(14000 + 28, portraitArr[28]);
        portraitData.Add(14000 + 29, portraitArr[29]);
        portraitData.Add(14000 + 30, portraitArr[30]);
        portraitData.Add(14000 + 31, portraitArr[31]);
        portraitData.Add(14000 + 32, portraitArr[32]);

        //가스레인지 액자
        talkData.Add(15000, new string[] {"(액자가 있다.):0", "(액자 속 사진을 확인해 봤다.):0", "(놀이공원에서 찍은 사진이다.):0", "(뒷배경엔 2번째 공간에서 본 관람차가 있다.):0", "(사진 속엔 세 사람이 있다.):0", "(임지은과):36", "(나,):30", "(그리고 앞에서 본 액자에 있던 남자다.):31", "(액자 테두리에 어떤 글씨가 쓰여 있다.):14", "[ 지은이와 내 동생 선진이와 함께 ]:32", "선진아...:33" });
        portraitData.Add(15000 + 0, portraitArr[0]);
        portraitData.Add(15000 + 1, portraitArr[1]);
        portraitData.Add(15000 + 2, portraitArr[2]);
        portraitData.Add(15000 + 3, portraitArr[3]);
        portraitData.Add(15000 + 4, portraitArr[4]);
        portraitData.Add(15000 + 5, portraitArr[5]);
        portraitData.Add(15000 + 6, portraitArr[6]);
        portraitData.Add(15000 + 7, portraitArr[7]);
        portraitData.Add(15000 + 8, portraitArr[8]);
        portraitData.Add(15000 + 9, portraitArr[9]);
        portraitData.Add(15000 + 10, portraitArr[10]);
        portraitData.Add(15000 + 11, portraitArr[11]);
        portraitData.Add(15000 + 12, portraitArr[12]);
        portraitData.Add(15000 + 13, portraitArr[13]);
        portraitData.Add(15000 + 14, portraitArr[14]);
        portraitData.Add(15000 + 15, portraitArr[15]);
        portraitData.Add(15000 + 16, portraitArr[16]);
        portraitData.Add(15000 + 17, portraitArr[17]);
        portraitData.Add(15000 + 18, portraitArr[18]);
        portraitData.Add(15000 + 19, portraitArr[19]);
        portraitData.Add(15000 + 20, portraitArr[20]);
        portraitData.Add(15000 + 21, portraitArr[21]);
        portraitData.Add(15000 + 22, portraitArr[22]);
        portraitData.Add(15000 + 23, portraitArr[23]);
        portraitData.Add(15000 + 24, portraitArr[24]);
        portraitData.Add(15000 + 25, portraitArr[25]);
        portraitData.Add(15000 + 26, portraitArr[26]);
        portraitData.Add(15000 + 27, portraitArr[27]);
        portraitData.Add(15000 + 28, portraitArr[28]);
        portraitData.Add(15000 + 29, portraitArr[29]);
        portraitData.Add(15000 + 30, portraitArr[30]);
        portraitData.Add(15000 + 31, portraitArr[31]);
        portraitData.Add(15000 + 32, portraitArr[32]);
        portraitData.Add(15000 + 33, portraitArr[33]);
        portraitData.Add(15000 + 34, portraitArr[34]);
        portraitData.Add(15000 + 35, portraitArr[35]);
        portraitData.Add(15000 + 36, portraitArr[36]);

        //세탁기 옷
        talkData.Add(16000, new string[] { "(세탁기 위에 '서안 고등학교'의 교복이 있다.):0",  "(교복 이름표에 적힌 이름은 '김선진'이다.):32", "(그래... 역시 네 교복이었구나...):32" });
        portraitData.Add(16000 + 0, portraitArr[0]);
        portraitData.Add(16000 + 1, portraitArr[1]);
        portraitData.Add(16000 + 2, portraitArr[2]);
        portraitData.Add(16000 + 3, portraitArr[3]);
        portraitData.Add(16000 + 4, portraitArr[4]);
        portraitData.Add(16000 + 5, portraitArr[5]);
        portraitData.Add(16000 + 6, portraitArr[6]);
        portraitData.Add(16000 + 7, portraitArr[7]);
        portraitData.Add(16000 + 8, portraitArr[8]);
        portraitData.Add(16000 + 9, portraitArr[9]);
        portraitData.Add(16000 + 10, portraitArr[10]);
        portraitData.Add(16000 + 11, portraitArr[11]);
        portraitData.Add(16000 + 12, portraitArr[12]);
        portraitData.Add(16000 + 13, portraitArr[13]);
        portraitData.Add(16000 + 14, portraitArr[14]);
        portraitData.Add(16000 + 15, portraitArr[15]);
        portraitData.Add(16000 + 16, portraitArr[16]);
        portraitData.Add(16000 + 17, portraitArr[17]);
        portraitData.Add(16000 + 18, portraitArr[18]);
        portraitData.Add(16000 + 19, portraitArr[19]);
        portraitData.Add(16000 + 20, portraitArr[20]);
        portraitData.Add(16000 + 21, portraitArr[21]);
        portraitData.Add(16000 + 22, portraitArr[22]);
        portraitData.Add(16000 + 23, portraitArr[23]);
        portraitData.Add(16000 + 24, portraitArr[24]);
        portraitData.Add(16000 + 25, portraitArr[25]);
        portraitData.Add(16000 + 26, portraitArr[26]);
        portraitData.Add(16000 + 27, portraitArr[27]);
        portraitData.Add(16000 + 28, portraitArr[28]);
        portraitData.Add(16000 + 29, portraitArr[29]);
        portraitData.Add(16000 + 30, portraitArr[30]);
        portraitData.Add(16000 + 31, portraitArr[31]);
        portraitData.Add(16000 + 32, portraitArr[32]);


        //전원꺼진 노트북
        talkData.Add(17000, new string[] { "(전원이 꺼진 노트북이다.):0" });
        portraitData.Add(17000 + 0, portraitArr[0]);

        //전원켜진 노트북
        talkData.Add(48000, new string[] { "(인터넷 뉴스 창이 보인다):0", "[9월 15일 오전 11시쯤 제주도로 향하던 비행기가 폭발로 인해 바다에 추락하는 사고가 발생했다.]:24", "[해당 여객기에 탑승했던 170명 전원이 사망하였으며,]:24", "[수학여행을 가던 '서안 고등학교' 학생들이 탑승하고 있었던 것으로 알려졌다.]:24", "[항공사 관계자는 현재 정확한 사고 원인을 조사하고 있다고 말했다.]:24", ".....:32" });
        portraitData.Add(48000 + 0, portraitArr[0]);
        portraitData.Add(48000 + 1, portraitArr[1]);
        portraitData.Add(48000 + 2, portraitArr[2]);
        portraitData.Add(48000 + 3, portraitArr[3]);
        portraitData.Add(48000 + 4, portraitArr[4]);
        portraitData.Add(48000 + 5, portraitArr[5]);
        portraitData.Add(48000 + 6, portraitArr[6]);
        portraitData.Add(48000 + 7, portraitArr[7]);
        portraitData.Add(48000 + 8, portraitArr[8]);
        portraitData.Add(48000 + 9, portraitArr[9]);
        portraitData.Add(48000 + 10, portraitArr[10]);
        portraitData.Add(48000 + 11, portraitArr[11]);
        portraitData.Add(48000 + 12, portraitArr[12]);
        portraitData.Add(48000 + 13, portraitArr[13]);
        portraitData.Add(48000 + 14, portraitArr[14]);
        portraitData.Add(48000 + 15, portraitArr[15]);
        portraitData.Add(48000 + 16, portraitArr[16]);
        portraitData.Add(48000 + 17, portraitArr[17]);
        portraitData.Add(48000 + 18, portraitArr[18]);
        portraitData.Add(48000 + 19, portraitArr[19]);
        portraitData.Add(48000 + 20, portraitArr[20]);
        portraitData.Add(48000 + 21, portraitArr[21]);
        portraitData.Add(48000 + 22, portraitArr[22]);
        portraitData.Add(48000 + 23, portraitArr[23]);
        portraitData.Add(48000 + 24, portraitArr[24]);
        portraitData.Add(48000 + 25, portraitArr[25]);
        portraitData.Add(48000 + 26, portraitArr[26]);
        portraitData.Add(48000 + 27, portraitArr[27]);
        portraitData.Add(48000 + 28, portraitArr[28]);
        portraitData.Add(48000 + 29, portraitArr[29]);
        portraitData.Add(48000 + 30, portraitArr[30]);
        portraitData.Add(48000 + 31, portraitArr[31]);
        portraitData.Add(48000 + 32, portraitArr[32]);


        //스마트폰
        talkData.Add(19000, new string[] { "(스마트폰이다.):0", "(잠금화면에 부재중 전화가 20통 이상 쌓인 것이 눈에 띈다.):0", "(발신자 이름은 '임지은'이다.):0", "(이외에도 그녀가 보낸 문자가 여러 개 보지 않은 채 쌓여있다.):0", "(잠금화면에서 본 마지막 문자의 내용은       [ 제발 아무것도 하지 말고 기다려줘. ]다.):17" });
        portraitData.Add(19000 + 0, portraitArr[0]);
        portraitData.Add(19000 + 1, portraitArr[1]);
        portraitData.Add(19000 + 2, portraitArr[2]);
        portraitData.Add(19000 + 3, portraitArr[3]);
        portraitData.Add(19000 + 4, portraitArr[4]);
        portraitData.Add(19000 + 5, portraitArr[5]);
        portraitData.Add(19000 + 6, portraitArr[6]);
        portraitData.Add(19000 + 7, portraitArr[7]);
        portraitData.Add(19000 + 8, portraitArr[8]);
        portraitData.Add(19000 + 9, portraitArr[9]);
        portraitData.Add(19000 + 10, portraitArr[10]);
        portraitData.Add(19000 + 11, portraitArr[11]);
        portraitData.Add(19000 + 12, portraitArr[12]);
        portraitData.Add(19000 + 13, portraitArr[13]);
        portraitData.Add(19000 + 14, portraitArr[14]);
        portraitData.Add(19000 + 15, portraitArr[15]);
        portraitData.Add(19000 + 16, portraitArr[16]);
        portraitData.Add(19000 + 17, portraitArr[17]);


        //책상 커터칼
        talkData.Add(20000, new string[] { "(책상 위에 커터칼이 있다.):14", "(이게 왜 여기에...):14", "(칼날에 붉은 피가 선명하게 묻어있다...):17" });
        portraitData.Add(20000 + 0, portraitArr[0]);
        portraitData.Add(20000 + 1, portraitArr[1]);
        portraitData.Add(20000 + 2, portraitArr[2]);
        portraitData.Add(20000 + 3, portraitArr[3]);
        portraitData.Add(20000 + 4, portraitArr[4]);
        portraitData.Add(20000 + 5, portraitArr[5]);
        portraitData.Add(20000 + 6, portraitArr[6]);
        portraitData.Add(20000 + 7, portraitArr[7]);
        portraitData.Add(20000 + 8, portraitArr[8]);
        portraitData.Add(20000 + 9, portraitArr[9]);
        portraitData.Add(20000 + 10, portraitArr[10]);
        portraitData.Add(20000 + 11, portraitArr[11]);
        portraitData.Add(20000 + 12, portraitArr[12]);
        portraitData.Add(20000 + 13, portraitArr[13]);
        portraitData.Add(20000 + 14, portraitArr[14]);
        portraitData.Add(20000 + 15, portraitArr[15]);
        portraitData.Add(20000 + 16, portraitArr[16]);
        portraitData.Add(20000 + 17, portraitArr[17]);


        //화장실문-퀘스트 전
        talkData.Add(21000, new string[] { "(화장실로 가는 문이다):0", "(열쇠 구멍도 없을뿐더러 열리지 않는다.):0" });
        portraitData.Add(21000 + 0, portraitArr[0]);

        //화장실문-퀘스트 후
        talkData.Add(22000, new string[] { "(이곳이 아니다.):0", "(첫 번째 별의 조각을 얻었던 그곳으로 가야 한다.):0"});
        portraitData.Add(22000 + 0, portraitArr[0]);
        portraitData.Add(22000 + 1, portraitArr[1]);
        portraitData.Add(22000 + 2, portraitArr[2]);
        portraitData.Add(22000 + 3, portraitArr[3]);
        portraitData.Add(22000 + 4, portraitArr[4]);
        portraitData.Add(22000 + 5, portraitArr[5]);
        portraitData.Add(22000 + 6, portraitArr[6]);
        portraitData.Add(22000 + 7, portraitArr[7]);
        portraitData.Add(22000 + 8, portraitArr[8]);
        portraitData.Add(22000 + 9, portraitArr[9]);
        portraitData.Add(22000 + 10, portraitArr[10]);
        portraitData.Add(22000 + 11, portraitArr[11]);
        portraitData.Add(22000 + 12, portraitArr[12]);
        portraitData.Add(22000 + 13, portraitArr[13]);
        portraitData.Add(22000 + 14, portraitArr[14]);
        portraitData.Add(22000 + 15, portraitArr[15]);
        portraitData.Add(22000 + 16, portraitArr[16]);
        portraitData.Add(22000 + 17, portraitArr[17]);

        //증명사진
        talkData.Add(23000, new string[] { "(변기 위에 물에 젖은 증명사진이 있다.):14", "(누군지는 알아볼 수 없다.):35", "('서안 고등학교'의 교복을 입고 있다는 것만 겨우 파악할 수 있다.):35", "(바닥에 물 한 방울도 없는 걸 보니, 이 젖은 자국의 정체는...):32" });
        portraitData.Add(23000 + 0, portraitArr[0]);
        portraitData.Add(23000 + 1, portraitArr[1]);
        portraitData.Add(23000 + 2, portraitArr[2]);
        portraitData.Add(23000 + 3, portraitArr[3]);
        portraitData.Add(23000 + 4, portraitArr[4]);
        portraitData.Add(23000 + 5, portraitArr[5]);
        portraitData.Add(23000 + 6, portraitArr[6]);
        portraitData.Add(23000 + 7, portraitArr[7]);
        portraitData.Add(23000 + 8, portraitArr[8]);
        portraitData.Add(23000 + 9, portraitArr[9]);
        portraitData.Add(23000 + 10, portraitArr[10]);
        portraitData.Add(23000 + 11, portraitArr[11]);
        portraitData.Add(23000 + 12, portraitArr[12]);
        portraitData.Add(23000 + 13, portraitArr[13]);
        portraitData.Add(23000 + 14, portraitArr[14]);
        portraitData.Add(23000 + 15, portraitArr[15]);
        portraitData.Add(23000 + 16, portraitArr[16]);
        portraitData.Add(23000 + 17, portraitArr[17]);
        portraitData.Add(23000 + 18, portraitArr[18]);
        portraitData.Add(23000 + 19, portraitArr[19]);
        portraitData.Add(23000 + 20, portraitArr[20]);
        portraitData.Add(23000 + 21, portraitArr[21]);
        portraitData.Add(23000 + 22, portraitArr[22]);
        portraitData.Add(23000 + 23, portraitArr[23]);
        portraitData.Add(23000 + 24, portraitArr[24]);
        portraitData.Add(23000 + 25, portraitArr[25]);
        portraitData.Add(23000 + 26, portraitArr[26]);
        portraitData.Add(23000 + 27, portraitArr[27]);
        portraitData.Add(23000 + 28, portraitArr[28]);
        portraitData.Add(23000 + 29, portraitArr[29]);
        portraitData.Add(23000 + 30, portraitArr[30]);
        portraitData.Add(23000 + 31, portraitArr[31]);
        portraitData.Add(23000 + 32, portraitArr[32]);
        portraitData.Add(23000 + 33, portraitArr[33]);
        portraitData.Add(23000 + 34, portraitArr[34]);
        portraitData.Add(23000 + 35, portraitArr[35]);

        //욕조 피 만땅
        talkData.Add(25000, new string[] { "(욕조에 물이 가득 차올랐다.):0", "(물인지, 피인지 알 수 없을 정도로 새빨갛다.):17", "(순간 번뜩하거 어떤 장면이 떠올랐다.):1", "(내가 커터날을 들고 욕조로 향하던 모습이...):1", "(...그렇구나. 나는 이곳에서...):32" });
        portraitData.Add(25000 + 0, portraitArr[0]);
        portraitData.Add(25000 + 1, portraitArr[1]);
        portraitData.Add(25000 + 2, portraitArr[2]);
        portraitData.Add(25000 + 3, portraitArr[3]);
        portraitData.Add(25000 + 4, portraitArr[4]);
        portraitData.Add(25000 + 5, portraitArr[5]);
        portraitData.Add(25000 + 6, portraitArr[6]);
        portraitData.Add(25000 + 7, portraitArr[7]);
        portraitData.Add(25000 + 8, portraitArr[8]);
        portraitData.Add(25000 + 9, portraitArr[9]);
        portraitData.Add(25000 + 10, portraitArr[10]);
        portraitData.Add(25000 + 11, portraitArr[11]);
        portraitData.Add(25000 + 12, portraitArr[12]);
        portraitData.Add(25000 + 13, portraitArr[13]);
        portraitData.Add(25000 + 14, portraitArr[14]);
        portraitData.Add(25000 + 15, portraitArr[15]);
        portraitData.Add(25000 + 16, portraitArr[16]);
        portraitData.Add(25000 + 17, portraitArr[17]);
        portraitData.Add(25000 + 18, portraitArr[18]);
        portraitData.Add(25000 + 19, portraitArr[19]);
        portraitData.Add(25000 + 20, portraitArr[20]);
        portraitData.Add(25000 + 21, portraitArr[21]);
        portraitData.Add(25000 + 22, portraitArr[22]);
        portraitData.Add(25000 + 23, portraitArr[23]);
        portraitData.Add(25000 + 24, portraitArr[24]);
        portraitData.Add(25000 + 25, portraitArr[25]);
        portraitData.Add(25000 + 26, portraitArr[26]);
        portraitData.Add(25000 + 27, portraitArr[27]);
        portraitData.Add(25000 + 28, portraitArr[28]);
        portraitData.Add(25000 + 29, portraitArr[29]);
        portraitData.Add(25000 + 30, portraitArr[30]);
        portraitData.Add(25000 + 31, portraitArr[31]);
        portraitData.Add(25000 + 32, portraitArr[32]);


        //욕조&별조각 애니메이션
        talkData.Add(26000, new string[] { "(물이 빠져나간 자리에 별의 조각이 있다):14", "혹시나 했지만 진짜로 여기에 있을 줄이야...:14", "(이걸로 네 번째 조각이다.):0", "(이제 이곳에서 볼일은 없다.):0", "(다시 원룸으로 돌아가자.):0" });
        portraitData.Add(26000 + 0, portraitArr[0]);
        portraitData.Add(26000 + 1, portraitArr[1]);
        portraitData.Add(26000 + 2, portraitArr[2]);
        portraitData.Add(26000 + 3, portraitArr[3]);
        portraitData.Add(26000 + 4, portraitArr[4]);
        portraitData.Add(26000 + 5, portraitArr[5]);
        portraitData.Add(26000 + 6, portraitArr[6]);
        portraitData.Add(26000 + 7, portraitArr[7]);
        portraitData.Add(26000 + 8, portraitArr[8]);
        portraitData.Add(26000 + 9, portraitArr[9]);
        portraitData.Add(26000 + 10, portraitArr[10]);
        portraitData.Add(26000 + 11, portraitArr[11]);
        portraitData.Add(26000 + 12, portraitArr[12]);
        portraitData.Add(26000 + 13, portraitArr[13]);
        portraitData.Add(26000 + 14, portraitArr[14]);

        //스테이지4 - 여기는 퀘스트와 관련없는 일반 아이템

        //침대-퀘스트 전
        talkData.Add(40000, new string[] { "(침대다.):0", "(지금은 방안을 더 살펴보는 게 우선이다.):0"});
        portraitData.Add(40000 + 0, portraitArr[0]);

        //침대-퀘스트 후
        talkData.Add(29000, new string[] { "(침대는 같이 사는 사람이 썼었다.):0" });
        portraitData.Add(29000 + 0, portraitArr[0]);

        //전등
        talkData.Add(50000, new string[] { "(전등이다.):0", "(방 안이 밝아 굳이 켜지 않아도 될 것 같다.):0" });
        portraitData.Add(50000 + 0, portraitArr[0]);

        //옷장-퀘스트 전
        talkData.Add(30000, new string[] { "(옷장이다.):0", "(침구류와 옷가지들이 있다.):0" });
        portraitData.Add(30000 + 0, portraitArr[0]);

        //옷장-퀘스트 후
        talkData.Add(31000, new string[] { "(옷장이다.):0", "(밤이 되면 여기 있던 이불을 꺼내, 그 위에 누워 잠들곤 했었지...):0" });
        portraitData.Add(31000 + 0, portraitArr[0]);
     

        //냉장고-퀘스트 전
        talkData.Add(41000, new string[] { "(냉장고다.):0", "(냉장고 안엔 아무것도 없다.):0", "(왜 아무것도 없지...?):14" });
        portraitData.Add(41000 + 0, portraitArr[0]);
        portraitData.Add(41000 + 1, portraitArr[1]);
        portraitData.Add(41000 + 2, portraitArr[2]);
        portraitData.Add(41000 + 3, portraitArr[3]);
        portraitData.Add(41000 + 4, portraitArr[4]);
        portraitData.Add(41000 + 5, portraitArr[5]);
        portraitData.Add(41000 + 6, portraitArr[6]);
        portraitData.Add(41000 + 7, portraitArr[7]);
        portraitData.Add(41000 + 8, portraitArr[8]);
        portraitData.Add(41000 + 9, portraitArr[9]);
        portraitData.Add(41000 + 10, portraitArr[10]);
        portraitData.Add(41000 + 11, portraitArr[11]);
        portraitData.Add(41000 + 12, portraitArr[12]);
        portraitData.Add(41000 + 13, portraitArr[13]);
        portraitData.Add(41000 + 14, portraitArr[14]);

        //냉장고-퀘스트 후
        talkData.Add(32000, new string[] { "(냉장고다.):0", "(냉장고 안엔 아무것도 없다.):0", "(...그땐 먹을 필요를 못 느꼈었다.):0" });
        portraitData.Add(32000 + 0, portraitArr[0]);


        //세탁기
        talkData.Add(33000, new string[] { "(세탁기다.):0","(세탁기 안엔 '서안 고등학교'의 교복이 있다.):0", "(...어디서 많이 봤는데?):18"});
        portraitData.Add(33000 + 0, portraitArr[0]);
        portraitData.Add(33000 + 1, portraitArr[1]);
        portraitData.Add(33000 + 2, portraitArr[2]);
        portraitData.Add(33000 + 3, portraitArr[3]);
        portraitData.Add(33000 + 4, portraitArr[4]);
        portraitData.Add(33000 + 5, portraitArr[5]);
        portraitData.Add(33000 + 6, portraitArr[6]);
        portraitData.Add(33000 + 7, portraitArr[7]);
        portraitData.Add(33000 + 8, portraitArr[8]);
        portraitData.Add(33000 + 9, portraitArr[9]);
        portraitData.Add(33000 + 10, portraitArr[10]);
        portraitData.Add(33000 + 11, portraitArr[11]);
        portraitData.Add(33000 + 12, portraitArr[12]);
        portraitData.Add(33000 + 13, portraitArr[13]);
        portraitData.Add(33000 + 14, portraitArr[14]);
        portraitData.Add(33000 + 15, portraitArr[15]);
        portraitData.Add(33000 + 16, portraitArr[16]);
        portraitData.Add(33000 + 17, portraitArr[17]);
        portraitData.Add(33000 + 18, portraitArr[18]);


        //창문
        talkData.Add(28000, new string[] { "(창문이다.):0", "(여전히 창 밖으로 검은 하늘이 보인다.):0" });
        portraitData.Add(28000 + 0, portraitArr[0]);


        //** Final Stage **//

        talkData.Add(47000, new string[] { "(제단이다.):0", "(다섯 개의 별의 조각이 합쳐져 밝게 빛난다.):0", "(더 이상 내가 할 것은 없다.):0", "(이제 남자와 미처 나누지 못한 얘기를 하러가자.):0" });
        portraitData.Add(47000 + 0, portraitArr[0]);
        portraitData.Add(47000 + 1, portraitArr[1]);
        portraitData.Add(47000 + 2, portraitArr[2]);
        portraitData.Add(47000 + 3, portraitArr[3]);
        portraitData.Add(47000 + 4, portraitArr[4]);
        portraitData.Add(47000 + 5, portraitArr[5]);
        portraitData.Add(47000 + 6, portraitArr[6]);
        portraitData.Add(47000 + 7, portraitArr[7]);
        portraitData.Add(47000 + 8, portraitArr[8]);
        portraitData.Add(47000 + 9, portraitArr[9]);
        portraitData.Add(47000 + 10, portraitArr[10]);
        portraitData.Add(47000 + 11, portraitArr[11]);
        portraitData.Add(47000 + 12, portraitArr[12]);
        portraitData.Add(47000 + 13, portraitArr[13]);
        portraitData.Add(47000 + 14, portraitArr[14]);
        portraitData.Add(47000 + 15, portraitArr[15]);
        portraitData.Add(47000 + 16, portraitArr[16]);
        portraitData.Add(47000 + 17, portraitArr[17]);
        portraitData.Add(47000 + 18, portraitArr[18]);


        talkData.Add(42000, new string[] { "마음이 급한 건 알겠지만...:37", "아직 해야 할 게 남아있지 않아?:37" });
        portraitData.Add(42000 + 0, portraitArr[0]);
        portraitData.Add(42000 + 1, portraitArr[1]);
        portraitData.Add(42000 + 2, portraitArr[2]);
        portraitData.Add(42000 + 3, portraitArr[3]);
        portraitData.Add(42000 + 4, portraitArr[4]);
        portraitData.Add(42000 + 5, portraitArr[5]);
        portraitData.Add(42000 + 6, portraitArr[6]);
        portraitData.Add(42000 + 7, portraitArr[7]);
        portraitData.Add(42000 + 8, portraitArr[8]);
        portraitData.Add(42000 + 9, portraitArr[9]);
        portraitData.Add(42000 + 10, portraitArr[10]);
        portraitData.Add(42000 + 11, portraitArr[11]);
        portraitData.Add(42000 + 12, portraitArr[12]);
        portraitData.Add(42000 + 13, portraitArr[13]);
        portraitData.Add(42000 + 14, portraitArr[14]);
        portraitData.Add(42000 + 15, portraitArr[15]);
        portraitData.Add(42000 + 16, portraitArr[16]);
        portraitData.Add(42000 + 17, portraitArr[17]);
        portraitData.Add(42000 + 18, portraitArr[18]);
        portraitData.Add(42000 + 19, portraitArr[19]);
        portraitData.Add(42000 + 20, portraitArr[20]);
        portraitData.Add(42000 + 21, portraitArr[21]);
        portraitData.Add(42000 + 22, portraitArr[22]);
        portraitData.Add(42000 + 23, portraitArr[23]);
        portraitData.Add(42000 + 24, portraitArr[24]);
        portraitData.Add(42000 + 25, portraitArr[25]);
        portraitData.Add(42000 + 26, portraitArr[26]);
        portraitData.Add(42000 + 27, portraitArr[27]);
        portraitData.Add(42000 + 28, portraitArr[28]);
        portraitData.Add(42000 + 29, portraitArr[29]);
        portraitData.Add(42000 + 30, portraitArr[30]);
        portraitData.Add(42000 + 31, portraitArr[31]);
        portraitData.Add(42000 + 32, portraitArr[32]);
        portraitData.Add(42000 + 33, portraitArr[33]);
        portraitData.Add(42000 + 34, portraitArr[34]);
        portraitData.Add(42000 + 35, portraitArr[35]);
        portraitData.Add(42000 + 36, portraitArr[36]);
        portraitData.Add(42000 + 37, portraitArr[37]);

        talkData.Add(43000, new string[] { "어서 가.:43" });
        portraitData.Add(43000 + 0, portraitArr[0]);
        portraitData.Add(43000 + 1, portraitArr[1]);
        portraitData.Add(43000 + 2, portraitArr[2]);
        portraitData.Add(43000 + 3, portraitArr[3]);
        portraitData.Add(43000 + 4, portraitArr[4]);
        portraitData.Add(43000 + 5, portraitArr[5]);
        portraitData.Add(43000 + 6, portraitArr[6]);
        portraitData.Add(43000 + 7, portraitArr[7]);
        portraitData.Add(43000 + 8, portraitArr[8]);
        portraitData.Add(43000 + 9, portraitArr[9]);
        portraitData.Add(43000 + 10, portraitArr[10]);
        portraitData.Add(43000 + 11, portraitArr[11]);
        portraitData.Add(43000 + 12, portraitArr[12]);
        portraitData.Add(43000 + 13, portraitArr[13]);
        portraitData.Add(43000 + 14, portraitArr[14]);
        portraitData.Add(43000 + 15, portraitArr[15]);
        portraitData.Add(43000 + 16, portraitArr[16]);
        portraitData.Add(43000 + 17, portraitArr[17]);
        portraitData.Add(43000 + 18, portraitArr[18]);
        portraitData.Add(43000 + 19, portraitArr[19]);
        portraitData.Add(43000 + 20, portraitArr[20]);
        portraitData.Add(43000 + 21, portraitArr[21]);
        portraitData.Add(43000 + 22, portraitArr[22]);
        portraitData.Add(43000 + 23, portraitArr[23]);
        portraitData.Add(43000 + 24, portraitArr[24]);
        portraitData.Add(43000 + 25, portraitArr[25]);
        portraitData.Add(43000 + 26, portraitArr[26]);
        portraitData.Add(43000 + 27, portraitArr[27]);
        portraitData.Add(43000 + 28, portraitArr[28]);
        portraitData.Add(43000 + 29, portraitArr[29]);
        portraitData.Add(43000 + 30, portraitArr[30]);
        portraitData.Add(43000 + 31, portraitArr[31]);
        portraitData.Add(43000 + 32, portraitArr[32]);
        portraitData.Add(43000 + 33, portraitArr[33]);
        portraitData.Add(43000 + 34, portraitArr[34]);
        portraitData.Add(43000 + 35, portraitArr[35]);
        portraitData.Add(43000 + 36, portraitArr[36]);
        portraitData.Add(43000 + 37, portraitArr[37]);
        portraitData.Add(43000 + 38, portraitArr[38]);
        portraitData.Add(43000 + 39, portraitArr[39]);
        portraitData.Add(43000 + 40, portraitArr[40]);
        portraitData.Add(43000 + 41, portraitArr[41]);
        portraitData.Add(43000 + 42, portraitArr[42]);
        portraitData.Add(43000 + 43, portraitArr[43]);
        portraitData.Add(43000 + 44, portraitArr[44]);
        portraitData.Add(43000 + 45, portraitArr[45]);
        portraitData.Add(43000 + 46, portraitArr[46]);
        portraitData.Add(43000 + 47, portraitArr[47]);

        talkData.Add(53000, new string[] { "이 문은 뭐지...?:14" });
        portraitData.Add(53000 + 0, portraitArr[0]);
        portraitData.Add(53000 + 1, portraitArr[1]);
        portraitData.Add(53000 + 2, portraitArr[2]);
        portraitData.Add(53000 + 3, portraitArr[3]);
        portraitData.Add(53000 + 4, portraitArr[4]);
        portraitData.Add(53000 + 5, portraitArr[5]);
        portraitData.Add(53000 + 6, portraitArr[6]);
        portraitData.Add(53000 + 7, portraitArr[7]);
        portraitData.Add(53000 + 8, portraitArr[8]);
        portraitData.Add(53000 + 9, portraitArr[9]);
        portraitData.Add(53000 + 10, portraitArr[10]);
        portraitData.Add(53000 + 11, portraitArr[11]);
        portraitData.Add(53000 + 12, portraitArr[12]);
        portraitData.Add(53000 + 13, portraitArr[13]);
        portraitData.Add(53000 + 14, portraitArr[14]);
        portraitData.Add(53000 + 15, portraitArr[15]);
        portraitData.Add(53000 + 16, portraitArr[16]);
        portraitData.Add(53000 + 17, portraitArr[17]);
        portraitData.Add(53000 + 18, portraitArr[18]);
        portraitData.Add(53000 + 19, portraitArr[19]);
        portraitData.Add(53000 + 20, portraitArr[20]);
        portraitData.Add(53000 + 21, portraitArr[21]);
        portraitData.Add(53000 + 22, portraitArr[22]);
        portraitData.Add(53000 + 23, portraitArr[23]);
        portraitData.Add(53000 + 24, portraitArr[24]);
        portraitData.Add(53000 + 25, portraitArr[25]);
        portraitData.Add(53000 + 26, portraitArr[26]);
        portraitData.Add(53000 + 27, portraitArr[27]);
        portraitData.Add(53000 + 28, portraitArr[28]);
        portraitData.Add(53000 + 29, portraitArr[29]);
        portraitData.Add(53000 + 30, portraitArr[30]);
        portraitData.Add(53000 + 31, portraitArr[31]);
        portraitData.Add(53000 + 32, portraitArr[32]);
        portraitData.Add(53000 + 33, portraitArr[33]);
        portraitData.Add(53000 + 34, portraitArr[34]);
        portraitData.Add(53000 + 35, portraitArr[35]);
        portraitData.Add(53000 + 36, portraitArr[36]);
        portraitData.Add(53000 + 37, portraitArr[37]);
        portraitData.Add(53000 + 38, portraitArr[38]);
        portraitData.Add(53000 + 39, portraitArr[39]);
        portraitData.Add(53000 + 40, portraitArr[40]);
        portraitData.Add(53000 + 41, portraitArr[41]);
        portraitData.Add(53000 + 42, portraitArr[42]);
        portraitData.Add(53000 + 43, portraitArr[43]);
        portraitData.Add(53000 + 44, portraitArr[44]);
        portraitData.Add(53000 + 45, portraitArr[45]);
        portraitData.Add(53000 + 46, portraitArr[46]);
        portraitData.Add(53000 + 47, portraitArr[47]);



        //10
        talkData.Add(10 + 200, new string[] { "(노트북이다.):0", "(전원 버튼을 누르면 켤 수 있을 것 같다.):0", "한 번 켜볼까?:0" });

        //Quest Talk
        //11
        talkData.Add(11 + 35000, new string[] { "(창문이다.):0", "(창밖으로 검은 하늘이 보인다.):0", "(구름도, 달도, 별도 없는 것이 하늘에 검은 물감을 뿌린 것 같다.):0" });

        //12
        talkData.Add(12 + 7900, new string[] { "너, 창밖에 봤어?:4", "응.:0", "왜 밖은 어두운데 별이 하나도 없는지 궁금하지 않아?:4", "음... 글쎄?:0", "이 세상엔 별이 많았는데 하나둘씩 떨어지기 시작하더니 하나도 남지 않게 된 거야.:4", "이대로 있다간 이 세상은 멸망하겠지.:4", "여긴 별이 없으면 존재할 수 없거든.:4", "혹시 얼마 전에 떨어진 마지막 별의 조각을 모아주면 안 될까?:4", "조각들을 모아서 제단에 올리면 돼.:4", "...알았어.:0" });

        //Quest Talk

        //13
        talkData.Add(13 + 73000, new string[] { "(문이다.):0", "철컥철컥...:24", "(닫혀있다.):0", "(열쇠가 있으면 열 수 있을 것 같다.):0" });

        //14
        talkData.Add(14 + 37000, new string[] { "전등이다.:0", "전등을 켜면 방이 밝아질 텐데...:0", "한 번 켜볼까?:0", "덜컥덜컥...:24", "(켜지지 않는다.):2", "툭.:24", "어? 방금 뭔가 떨어지는 소리가 들렸는데.:0" });

        //15
        talkData.Add(15 + 1600, new string[] { "(열쇠다.):0", "(일단 필요할지 모르니 줍자.):0" });
        portraitData.Add(1600 + 0, portraitArr[0]);

        //20
        talkData.Add(20 + 73000, new string[] { "(문이다.):0", "(방금 주워온 열쇠로 열 수 있을 것 같다.):0", "철컥:24", "(열렸다.):0" });

        //별의 조각1 찾기
        //20
        talkData.Add(21 + 34000, new string[] { "(세면대다.):0", "피곤한데 세수라도 할까?:2", "쏴아아아...:24", "(한결 괜찮아진 것 같다.):3", "(다시 한번 조사를 시작해 보자.):0" });

        //21
        talkData.Add(22 + 39000, new string[] { "(수건걸이다.):0", "(수건으로 젖은 얼굴을 닦았다.):0", "툭.:24", "(무언가 떨어지는 소리가 들렸다.):0" });

        //22
        talkData.Add(23 + 2700, new string[] { "(무언가 빛나는 조각이다.):0", "(걔가 말한 별의 조각이 이걸까?):0", "(일단 가져가서 보여줘야겠다.):0" });
        portraitData.Add(2700 + 0, portraitArr[0]);

        //23
        talkData.Add(24 + 7900, new string[] { "네가 말한 별의 조각이 이거야?:0", "맞아. 찾아줘서 고마워.:4", "여기서 찾을 수 있는 별의 조각은 이게 다일 거야.:4", "나머지는 다른 곳에 있을 테니, 그것도 찾아주면 안 될까?:4", "알았어.:0" });

        //24
        talkData.Add(25 + 44000, new string[] { "(밖으로 나가는 문이다.):0", "(잠겨있다.):0", "(번호 키가 있다.):0", "으음...:0", "이 방을 다시 한번 조사해봐야겠어.:0", "하나하나 자세히 보다 보면 문을 열 수 있는 힌트가 있을지도 몰라.:0" });

        //30
        talkData.Add(30 + 400, new string[] { "(책장이다.):0", "(책장에 붙어있는 종이가 보인다.):0", "[도서관 분류번호]:24", "[총류 - 000], [철학 - 100], [종교 - 200], [사회과학 - 300], [순수과학 - 400] :24", "[기술과학 - 500], [예술 - 600], [언어 - 700], [문학 - 800], [역사 - 900]:24" });

        //31-36
        talkData.Add(31 + 1000, new string[] { "(가스레인지다.):0", "(가스레인지에 쪽지가 붙어있다.):0", "[/순수과학)]:24" });
        talkData.Add(32 + 900, new string[] { "(개수대다.):0", "(개수대에 쪽지가 붙어있다.):0", "[+사회과학]:24" });
        talkData.Add(33 + 1200, new string[] { "(냉장고다.):0", "(냉장고 문에 쪽지가 붙어있다.):0", "[( )안에는 숫자 2개와 부호가 1개 있다.]:24" });
        talkData.Add(34 + 1300, new string[] { "(의자다.):0", "(의자에 쪽지가 붙어있다.):0", "[+언어]:24" });
        talkData.Add(35 + 1100, new string[] { "(의자다.):0", "(의자에 쪽지가 붙어있다.):0", "[(문학]:24" });
        talkData.Add(36 + 44000, new string[] { "(번호 키가 있는 문이다.):0", "(이제까지 모은 단서들을 조합해서 열어보자.):0" });


        // *** 스테이지 2 ***

        //
        //40

        talkData.Add(42 + 4600, new string[] { "(잠금장치가 있는 문이다.):0", "(6개의 문자를 입력해야 열 수 있다.):0","...:0","으음?:0", "(위에 누군가가 있는 것 같다.):0" });
        talkData.Add(43 + 7500, new string[] { "어?:7", "응?:0", "한별아...! 한별이 맞지?!:7", "드디어 나왔구나...!:9", "저기... 어떻게 내 이름을...?:0", "모를 리가 없잖아! 널 본 게 몇 년인데!:9" });

        //여기는 퀘스트일지도 모름.
        //42
        talkData.Add(40 + 2900, new string[] { "(타임캡슐의 비석이다.):0", "(물에 젖은 일부분이 붉게 보인다.):0", "물을 부으면 뭔가가 달라질 것 같은데...:0", "(비석에 어떤 글자가 적혀있다.):0", "[ N ]:24" });


        //43
        talkData.Add(41 + 3100, new string[] { "(타임캡슐의 비석이다.):0", "(물에 젖은 일부분이 푸르게 보인다.):0", "물을 부으면 뭔가가 달라질 것 같은데...:0", "(비석에 어떤 글자가 적혀있다.):0", "[ S ]:24" });

        //양동이(사라질 예정)
        //**퀘스트 아이템**
        //44
        talkData.Add(44 + 6000, new string[] { "(양동이다.):0", "(이걸로 분수 물을 받을 수 있을 것 같다.):0", "(가져가자.):0" });


        //45
        //분수 가운데 긴거임
        talkData.Add(45 + 55000, new string[] { "(분수다.):0", "(방금 가져온 양동이로 물을 담을 수 있을 것 같다.):0", "콸콸콸...:24", "(양동이에 어느 정도 물이 찼다.):0", "(이 물을 비석에 부어보자.):0" });

        //46
        talkData.Add(46 + 2900, new string[] { "(타임캡슐의 비석이다.):0", "(양동이에 받아온 물을 부어보았다.):0" });

        //47
        talkData.Add(47 + 3100, new string[] { "(타임캡슐의 비석이다.):0", "(양동이에 받아온 물을 부어보았다.):0" });

        //50
        talkData.Add(50 + 57000, new string[] { "(야구장이다.):0", "(이전에 누군가와 함께 온 듯한 느낌이 든다.):0", "(자세히 보니 입구 앞 초록색 표지판에 무언가가 쓰여 있다.):0", "[지금은 정규 시즌이 아닙니다. 다음에 또 방문해 주세요.]:24", "[ThOs Os not the regular season. Please vOsOt agaOn next tOme.]:24" });

        //51
        talkData.Add(51 + 58000, new string[] { "(버스다.):0", "(버스 창에 무언가가 붙어 있다.):0", "[첫 글자는 파란색, 세 번째 글자는 빨간색이다.]:24" });

        //52
        talkData.Add(52 + 59000, new string[] { "(관람차다.):0", "(안에 무언가가 있다.):0", "(노란색 쪽지다.):0", "노란색을 보니까 왠지 옆에서 봤던 텐트가 생각나네.:0","일단 쪽지 내용부터 확인하고 한 번 가보자.:0","(노란색 쪽지엔 이렇게 적혀 있다.):0", "[형, 사랑해.(I love O.)]:24", "(왠지 조금 슬픈 느낌이 든다.):2" });

        //퀘스트 텐트
        //**퀘스트 시 문구**
        //53
        talkData.Add(53 + 4100, new string[] { "(텐트다.):0", "(다른 텐트에 비해 연약해 보인다.):0", "(무언가 단단한 걸로 고정해 주면 좋을 것 같다.):0" });


        //돌(사라질 거)
        //**퀘스트 시 문구**
        //54
        talkData.Add(54 + 6100, new string[] { "(돌이다.):0", "(이 정도면 텐트를 고정하기에 알맞을 것 같다.):0", "(가져가자.):0" });


        //퀘스트 텐트
        //**퀘스트 시 문구**
        //55
        talkData.Add(55 + 4100, new string[] { "(텐트다.):0", "(방금 가져온 돌을 여기에 두면 될 것 같다.):0", "(그러고 보니... 돌이 있던 곳에 뭔가가 있었던 것 같은데...?):18" });

        //돌 밑에 쪽지
        //**퀘스트 아이템 아님. 그냥 둘 거임.**
        //56
        talkData.Add(56 + 61000, new string[] { "(붉은색 쪽지다.):0", "(쪽지에 어떤 글씨가 적혀있다.):0", "[세 번째와 여섯 번째 글자는 같다.]:24" });

        //캠핑카1
        //**퀘스트 아이템
        //60
        talkData.Add(60 + 62000, new string[] { "(캠핑카다.):0", "(문에 보라색 쪽지가 붙어있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[?? = 캠핑은 여러 번 해봤지만 캠핑카는 처음인걸? 뭘 가져갈까?]:24", "[?? = 갈아입을 옷, 수건, 간식거리도 챙겨야지. 얘들아, 너희 뭐 먹고 싶은 거 있니?]:24", "[??? = 난 과자!]:24", "[???? = 난 *주스*! 오렌지 *주스*! 아, *젤리*도!]:24" });


        //책상 오(2)-보라 쪽지
        //**퀘스트 아이템**
        //61
        talkData.Add(61 + 63000, new string[] { "(책상이다.):0", "(책상 위에 보라색 쪽지가 있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[네 번째 글자는 *사이에 있는 두 먹을 거리에 공통으로 들어간 글자 중 하나다.]:24" });


        //캐라반1
        //**퀘스트 아이템**
        //62
        talkData.Add(62 + 64000, new string[] { "(카라반이다.):0", "(문에 보라색 쪽지가 붙어있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[4번째 글자는 모음이 아니다.]:24" });


        //책상 왼(3)(나타날 거)-파랑 쪽지
        //**퀘스트 아이템**
        //63
        talkData.Add(63 + 65000, new string[] { "(책상이다.):0", "(책상 위에 파란색 쪽지가 있다.):0", "(쪽지에 어떤 글씨가 쓰여있다.):0", "[여섯 글자 중 첫 번째 글자만 대문자다.]:24", "(이 주변은 어느 정도 다 둘러본 것 같은데...):0", "(문을 열기 위한 힌트는 조금 모자란 것 같아.):0", "(혹시 걔가 가지고 있으려나?):0" });

        //퀘스트 대화2(태양 노트 보기 전)-앨 봐야 태양 노트 나타남
        //64
        talkData.Add(64 + 7500, new string[] { "저기, 너 이름이...:0", "지은이야. 임지은.:9", "뭐 물어볼 거 있어?:9", "혹시 쪽지 같은거... 본 적 있어? 빨강, 노랑, 초록, 파랑, 보라색 중에 아무거나.:0", "쪽지? 그리고보니 아까 뭔지 모르는 쪽지 하나를 줍긴 했는데...:11", "(그녀가 파란색과 노란색, 빨간색이 섞인 쪽지를 건넸다.):0", "(쪽지에는 글씨가 쓰여 있다.):0", "[넌,나의 태양이고 달이며 별이야.]:24", "[You are my 'OOO', my moon and all my star.]:24", "아, 그러고 보니 밑에 있는 책상에서 책 같은 걸 본 것 같아.:11", "책...?:18", "...알려줘서 고마워.:3", "(책상이 있는 곳으로 가봐야겠다.):0" });

        //책상 왼(2)(태양 책이 놓인 책상)
        //**퀘스트 책상**
        //65
        talkData.Add(65 + 66000, new string[] { "(책상이다.):0", "(책상 위에 태양 그림이 그려진 노트가 있다.):0", "(노트를 펼치자 어떤 글씨가 쓰여 있는 것이 보인다.):0", "[우리가 어렸을 적에 자주 놀던 그곳에 별이 있다.]:24", "자주 놀던 곳이라고...? 그게 어디지?:0", "...걔는 알고 있으려나?:0" });

        //퀘스트 대화3(태양 노트 본 후)
        //66
        talkData.Add(66 + 7500, new string[] { "혹시 뭐 좀 물어봐도 될까?:0", "당연하지! 뭔데?:9", "(태양 그림이 그려진 노트를 보여주며 물었다.):0", "여기, [우리가 어렸을 적에 자주 놀던 그곳]이라는 문장 말인데... 혹시 어딘 지 알아?:0", "알지! 네 동생하고 항상 거기 갔었잖아!:9", "...동생?:0", "..윽!:1", "(갑자기 머리가 지끈거린다.):1", "...괜찮아?:8", "...응. 아무것도 아니야. 그래서 거기가 어딘데?:3", "중앙 분수대야. 오면서 봤지?:9", "아아, 거기... 고마워.:3", "(분수대라... 물줄기가 세서 함부로 들어갈 수가 없었는데...):18", "(분수를 끌 방법이 없을까?):18" });

        //스위치(사라질 예정)
        //**퀘스트 아이템**
        //70
        talkData.Add(70 + 5900, new string[] { "(분수대 스위치다.):0", "(스파크가 튀어서 함부로 만질 수 없다.):0", "(안전하게 스위치를 누를 수 있는 방법이 없을까?):0" });

        //절연장갑
        //**퀘스트 아이템**
        //71
        talkData.Add(71 + 4500, new string[] { "(절연 장갑이다.):0", "(이걸로 안전하게 스위치를 누를 수 있을 것 같다.):0" });
        portraitData.Add(4500 + 0, portraitArr[0]);//보통

        //72
        talkData.Add(72 + 5900, new string[] { "(분수대 스위치다.):0", "(방금 주운 절연 장갑을 끼고 스위치를 만져보았다.):0", "철컥.:24", "(스위치를 내렸다.):0" });

        //별의 조각**퀘스트 아이템**
        //73
        talkData.Add(73 + 6300, new string[] { "(별의 조각이다.):0", "(조각 위에 초록색 쪽지가 있다.):0", "(쪽지에 글씨가 쓰여 있다.):0", "[다섯 번째 글자는 '나 자신'이다.]:24", "별의 조각은 이걸로 두 개 째지?:0", "(가져가자.):0" });
        portraitData.Add(6300 + 0, portraitArr[0]);//보통
        portraitData.Add(6300 + 1, portraitArr[1]);//보통
        portraitData.Add(6300 + 2, portraitArr[2]);//보통
        portraitData.Add(6300 + 3, portraitArr[3]);
        portraitData.Add(6300 + 4, portraitArr[4]);
        portraitData.Add(6300 + 5, portraitArr[5]);
        portraitData.Add(6300 + 6, portraitArr[6]);
        portraitData.Add(6300 + 7, portraitArr[7]);
        portraitData.Add(6300 + 8, portraitArr[8]);
        portraitData.Add(6300 + 9, portraitArr[9]);
        portraitData.Add(6300 + 10, portraitArr[10]);
        portraitData.Add(6300 + 11, portraitArr[11]);
        portraitData.Add(6300 + 12, portraitArr[12]);
        portraitData.Add(6300 + 13, portraitArr[13]);
        portraitData.Add(6300 + 14, portraitArr[14]);
        portraitData.Add(6300 + 15, portraitArr[15]);
        portraitData.Add(6300 + 16, portraitArr[16]);
        portraitData.Add(6300 + 17, portraitArr[17]);
        portraitData.Add(6300 + 18, portraitArr[18]);
        portraitData.Add(6300 + 19, portraitArr[19]);
        portraitData.Add(6300 + 20, portraitArr[20]);
        portraitData.Add(6300 + 21, portraitArr[21]);
        portraitData.Add(6300 + 22, portraitArr[22]);
        portraitData.Add(6300 + 23, portraitArr[23]);
        portraitData.Add(6300 + 24, portraitArr[24]);

        //퀘스트
        //74
        talkData.Add(74 + 4600, new string[] { "(잠금장치가 있는 문이다.):0", "(이제까지 모은 단서들을 조합해서 열어보자.):0" });


        //**스테이지3**

        //80
        
        talkData.Add(80+9500, new string[] { "...다음 장소로 가는 문이겠지?:17", "(빨리 이곳을 벗어나고 싶다...):16", "(문은 잠겨있다.):17","(열쇠를 찾으면 될 것 같다.):17" });

        //81
        
        talkData.Add(81+4200, new string[] { "너... 네가 어떻게 여기까지...?:17", "아니, 그게 중요한 게 아니지. 너, 혹시 여기 문 열쇠 가지고 있어?:17",  "...글세. 근데 너 안색이 안 좋은...:20", "...열쇠. 가지고 있냐고!:15", "(언성이 높아지고 숨이 거칠어진다.):16",  "...지금은 없어. 하지만 아마 이 공간 어딘가에 있을 거야.:4", "...알았어.:17", "(...젠장.):16" });

        //82
        
        talkData.Add(82 + 46000, new string[] { "(웬 종이가 떨어져 있다.):17", "(비행기표다.):17", "('왼쪽에서 오른쪽으로 A ~ F, 앞에서 뒤로 1 ~ 10'이란 안내 문구와 함께 좌석번호가 적혀 있다.):17", "(표에 적힌 좌석번호는 F7이다.):17", "(이 자리에 가면 열쇠가 있는 건가...?):17", "(빨리 가보자.):17" });

        //83
        
        talkData.Add(83 + 6600, new string[] { "( 비행기표에 적힌 좌석은 여기다.):17", "(...아. 실수로 표를 떨어뜨리고 말았다.):14", "(표를 줍기 위해 허릴 숙였다.):0" });


        //84
        talkData.Add(84 + 49000, new string[] { "뭐, 뭐야...?!:25", "(방금까지 푸르던 의자가 붉게 변했다.):25", "(의자를 만져보니 무언가에 젖은 것처럼 축축하다.):1", "(의자를 만진 손을 바라보니 피같은 선명한 붉은 액체로 흥건했다.):1", "...우욱.:16","(...헛구역질이 나올 것 같다.):16", "어서 이곳을 나가고 싶...:16", "(아니, 나가야만 한다. 무슨 수를 써서라도.):15" });

        //85
        
        talkData.Add(85 + 4300, new string[] { "너... 너... 지은이라고 했지? 혹시 열쇠 있어?:17", "아니, 있어야만 해. 나보다 먼저 이곳에 왔으니, 당연히 있겠지?:13", "...미안해. 이곳에 대해 난 어떤 말도 할 수 없어.:10" ,"여기는 오롯이 너 혼자서 해내야 해.:10", "...어째서?:17", "그건... 너 자신이 더 잘 알고 있을 거야.:10" });
        

        //86  
        talkData.Add(86 + 51000, new string[] { "(가방이다.):17", "(가방에 무언가 검게 그을린 자국이 있다.):17", "(가방 안에는 검게 타버린 옷과 먹을거리가 들어있다.):17", "...이게 뭐지?:12", "타버린 옷들 사이로 뭔가가 비죽 나와 있다.:12"," 포스트잇이다.:0", "포스트잇엔 이렇게 적혀 있다.:0", "[ ...ㄴ진아! 기념품 같은 거 안 사와도 되니까 즐겁게 놀다 와! 올 때 연락하고! ]:24", "...윽!:1", "(갑자기 머리가 지끈거린다.):16" });
        
        //87  
        talkData.Add(87 + 52000, new string[] { "(무언가가 밝게 빛나는 것이 보인다.):17", "(스마트폰이다.):17", "(화면을 켜보니 누군가에게 문자를 보낸 흔적이 있다.):0", "(수신자는 ‘김한별’이다.):0", "...나잖아?:14", "(...혼란스럽다. 내가 이 사람과 알고 있었다고?):14", "(문자 내용을 읽어보았다.):14", "[ 형. 비행기가 뭔가 이상해. 창밖을 보는데 검은 연기가 보여... ]:24", "(다른 내용은 보이지 않는다.):14", "(메인화면으로 돌아가 휴대폰 주인의 이름을 확인해봤다.):0", "...김선진?:14", "(두 번째 공간에 있던 문의 비밀번호와 같은 이름이다.):14", "...윽!:1", "(순간 누군가의 얼굴이 희미하게 떠올랐다.):19" });
        
        //퀘스트 90 
        talkData.Add(90 + 7000, new string[] { "(구명조끼다.):17", "(곳곳에 그을린 흔적이 있다.):17", "(...무슨 사고라도 있었던 걸까?):17", "(...무언가가 기억날 것 같다.):16" });
        portraitData.Add(7000 + 0, portraitArr[0]);
        portraitData.Add(7000 + 1, portraitArr[1]);
        portraitData.Add(7000 + 2, portraitArr[2]);
        portraitData.Add(7000 + 3, portraitArr[3]);
        portraitData.Add(7000 + 4, portraitArr[4]);
        portraitData.Add(7000 + 5, portraitArr[5]);
        portraitData.Add(7000 + 6, portraitArr[6]);
        portraitData.Add(7000 + 7, portraitArr[7]);
        portraitData.Add(7000 + 8, portraitArr[8]);
        portraitData.Add(7000 + 9, portraitArr[9]);
        portraitData.Add(7000 + 10, portraitArr[10]);
        portraitData.Add(7000 + 11, portraitArr[11]);
        portraitData.Add(7000 + 12, portraitArr[12]);
        portraitData.Add(7000 + 13, portraitArr[13]);
        portraitData.Add(7000 + 14, portraitArr[14]);
        portraitData.Add(7000 + 15, portraitArr[15]);
        portraitData.Add(7000 + 16, portraitArr[16]);
        portraitData.Add(7000 + 17, portraitArr[17]);


        //91
        talkData.Add(91 + 56000, new string[] { "(라디오다.):17", "(다이얼을 돌려서 주파수를 맞춰봤다.):17", "치지직...:24", "어떤 소리가 들리기 시작한다.:0", "[ 오늘 오전 11시경 제주도로 향하던 비행기가 폭발로 인해 추락하는 사고가 발생했습니다. ]:24", "[ 해당 비행기에는 수학여행을 가던 ‘서안 고등학교’학생들이 탑승하고 있었던 것으로 알려져... ]:24",  "(뒷 내용은 들리지 않는다.):2", "(...이제 이곳에서 찾을 건 없을 것 같다.):17", "(남은 건... 후드를 쓴 남자에게 가면 된다.):17","(그가 열쇠의 행방을 알고 있다는 그런 확신이 든다.):12" });     
        //92
        talkData.Add(92 + 4200, new string[] { "다 찾았어?:4","너... 여기에 대해 알고 있는 거지?:17","여기서 무슨 일이 일어났는지. 그리고 내가 찾은 물건들의 주인이 누구인지.:17", "...맞아. 너도 처음부터 알고 있었잖아.:4","...내가?:14", "...윽!:1", "(머리가 지끈거린다...!):16", "동시에 무언가가 떨어지는 소리가 들렸다.:16" });
      
        //93
        talkData.Add(93 + 7200, new string[] { "(이건... 정신과 약이다.):14","(...내 주머니에 들어있었다.):14","(이게 왜...?):18","(후드를 쓴 남자가 당황한 날 가만히 바라보고 있다...):14", "(일단 그와 대화를 계속해보자.):12" });
        //talkData.Add(10200, new string[] { "(이건... 정신과 약이다.):14", "(...내 주머니에 들어있었다.):14", "(이게 왜...?):18" });
        portraitData.Add(7200 + 0, portraitArr[0]);
        portraitData.Add(7200 + 1, portraitArr[1]);
        portraitData.Add(7200 + 2, portraitArr[2]);
        portraitData.Add(7200 + 3, portraitArr[3]);
        portraitData.Add(7200 + 4, portraitArr[4]);
        portraitData.Add(7200 + 5, portraitArr[5]);
        portraitData.Add(7200 + 6, portraitArr[6]);
        portraitData.Add(7200 + 7, portraitArr[7]);
        portraitData.Add(7200 + 8, portraitArr[8]);
        portraitData.Add(7200 + 9, portraitArr[9]);
        portraitData.Add(7200 + 10, portraitArr[10]);
        portraitData.Add(7200 + 11, portraitArr[11]);
        portraitData.Add(7200 + 12, portraitArr[12]);
        portraitData.Add(7200 + 13, portraitArr[13]);
        portraitData.Add(7200 + 14, portraitArr[14]);
        portraitData.Add(7200 + 15, portraitArr[15]);
        portraitData.Add(7200 + 16, portraitArr[16]);
        portraitData.Add(7200 + 17, portraitArr[17]);
        portraitData.Add(7200 + 18, portraitArr[18]);

        //94
        talkData.Add(94 + 4200, new string[] { "...괜찮아?:22","(후드를 쓴 남자의 걱정스러운 목소리가 들렸다.):14","(순간 남자에게서 어떤 얼굴이 보였던 것 같다.):14","(스마트폰을 봤을 때 머릿속에서 떠올랐던 이미지의 인물과 비슷해 보였다.):19","...뭔갈 알아낸 듯한 모양이네.:21","(남자가 옅은 미소를 지으며 무언가를 건넸다.):14"});

        //95
        talkData.Add(95 + 5300, new string[] { "(노란색 열쇠다.):0","내가 도와줄 수 있는 건 여기까지야.:21","어서 가.:21","계속 앞으로 나아가는 거야.:21","형이라면 할 수 있어.:23" });
        portraitData.Add(5300 + 0, portraitArr[0]);
        portraitData.Add(5300 + 1, portraitArr[1]);
        portraitData.Add(5300 + 2, portraitArr[2]);
        portraitData.Add(5300 + 3, portraitArr[3]);
        portraitData.Add(5300 + 4, portraitArr[4]);
        portraitData.Add(5300 + 5, portraitArr[5]);
        portraitData.Add(5300 + 6, portraitArr[6]);
        portraitData.Add(5300 + 7, portraitArr[7]);
        portraitData.Add(5300 + 8, portraitArr[8]);
        portraitData.Add(5300 + 9, portraitArr[9]);
        portraitData.Add(5300 + 10, portraitArr[10]);
        portraitData.Add(5300 + 11, portraitArr[11]);
        portraitData.Add(5300 + 12, portraitArr[12]);
        portraitData.Add(5300 + 13, portraitArr[13]);
        portraitData.Add(5300 + 14, portraitArr[14]);
        portraitData.Add(5300 + 15, portraitArr[15]);
        portraitData.Add(5300 + 16, portraitArr[16]);
        portraitData.Add(5300 + 17, portraitArr[17]);
        portraitData.Add(5300 + 18, portraitArr[18]);
        portraitData.Add(5300 + 19, portraitArr[19]);
        portraitData.Add(5300 + 20, portraitArr[20]);
        portraitData.Add(5300 + 21, portraitArr[21]);
        portraitData.Add(5300 + 22, portraitArr[22]);
        portraitData.Add(5300 + 23, portraitArr[23]);

        //96
        talkData.Add(96 + 9900, new string[] { "(별의 조각이다.):0", "아까 봤을 땐 없었는데...:14","(...가져가자.):0" });
        portraitData.Add(9900 + 0, portraitArr[0]);
        portraitData.Add(9900 + 1, portraitArr[1]);
        portraitData.Add(9900 + 2, portraitArr[2]);
        portraitData.Add(9900 + 3, portraitArr[3]);
        portraitData.Add(9900 + 4, portraitArr[4]);
        portraitData.Add(9900 + 5, portraitArr[5]);
        portraitData.Add(9900 + 6, portraitArr[6]);
        portraitData.Add(9900 + 7, portraitArr[7]);
        portraitData.Add(9900 + 8, portraitArr[8]);
        portraitData.Add(9900 + 9, portraitArr[9]);
        portraitData.Add(9900 + 10, portraitArr[10]);
        portraitData.Add(9900 + 11, portraitArr[11]);
        portraitData.Add(9900 + 12, portraitArr[12]);
        portraitData.Add(9900 + 13, portraitArr[13]);
        portraitData.Add(9900 + 14, portraitArr[14]);

        //97
        talkData.Add(97 + 9500, new string[] {"(노란색 열쇠를 열쇠 구멍에 꽂았다.):0", "철컥!:24", "(열렸다.):0" });

        //** 스테이지4 **

        //100
        talkData.Add(100 + 10000, new string[] { "다음 장소로 가는 문이겠지?:0", "문 너머는 제단이야.:4", "응?:0", "(후드를 쓴 남자의 목소리가 들린다.):0", "(뒤따라온 건가?):0" });
        portraitData.Add(10000 + 0, portraitArr[0]);
        portraitData.Add(10000 + 1, portraitArr[1]);
        portraitData.Add(10000 + 2, portraitArr[2]);
        portraitData.Add(10000 + 3, portraitArr[3]);
        portraitData.Add(10000 + 4, portraitArr[4]);

        //101
        talkData.Add(101 + 11000, new string[] { "여기가 어딘지 알겠어?:4", "첫 번째 공간하고 거의 똑같은 원룸...:0", "가구들 색이 조금 다르긴 하지만...:0", ".....:4","(표정을 보아하니 원하는 대답이 아닌 듯하다.):0", "(방안을 더 살펴보자.):0" });

        //102
        talkData.Add(102 + 12000, new string[] { "(달력이다.):0", "(방금까지만 해도 없었는데...?):18", "(10월 2일에 동그라미가 처져있다.):0", "(이사 온 날이라 적혀 있다.):0"});

        //103
        talkData.Add(103 + 13000, new string[] { "(웬 액자가 있다.):0", "(얘도 방금까지만 해도 없었는데...?):18", "(액자 속 사진을 확인해 봤다.):0", "(야구장 앞에서 찍은 사진이다.):14", "(2번째 공간에서 본 야구장과 똑같이 생겼다.):14","(사진 속엔 두 사람이 있다.):14", "(한 사람은 나다.):26", "(그 옆에 있는 사람은...):27", "윽...!:1", "(흐릿했던 실루엣이 점차 선명해진다.):17" });

        //104
        talkData.Add(104 + 14000, new string[] { "(의자 위에 액자가 있다.):0", "(액자 속 사진의 배경은 카라반이다.):18", "(역시나 2번째 공간에서 본 곳이다.):0", "(사진 속엔 나와,):28", "(방금전 액자에서 본 남자가 찍혀 있다.):29", "(...서서히 기억이 난다.):14", "(이 사람은...):32" });

        //105
        talkData.Add(105 + 15000, new string[] { "(액자가 있다.):0", "(액자 속 사진을 확인해 봤다.):0", "(놀이공원에서 찍은 사진이다.):14", "(뒷배경엔 2번째 공간에서 본 관람차가 있다.):14", "(사진 속엔 세 사람이 있다.):14", "(임지은과):36", "(나,):30", "(그리고 앞에서 본 액자에 있던 남자다.):31", "(액자 테두리에 어떤 글씨가 쓰여 있다.):14", "[ 지은이와 내 동생 선진이와 함께 ]:32", "(...그래. 내가 왜 널 잊고 있었지...):32", "선진아...:33" });

        //106
        talkData.Add(106 + 16000, new string[] { "(세탁기 위에 '서안 고등학교'의 교복이 있다.):0", "(분명 조금 전까지만 해도 안에 있었는데...):18", "(교복을 확인해보니 이전에 없었던 이름표가 보인다.):14", "(이름표에 적힌 이름은 '김선진'이다.):14", "(그래... 역시 네 교복이었구나...):32" });

        //107
        talkData.Add(107 + 17000, new string[] { "(화면이 꺼진 노트북이다.):0", "(켜보자.):0" });

        //수정! 여기부터 110번대
        //108
        talkData.Add(108 + 48000, new string[] { "(인터넷 뉴스 창이 보인다.):0", "[9월 15일 오전 11시쯤 제주도로 향하던 비행기가 폭발로 인해 바다에 추락하는 사고가 발생했다.]:24", "[해당 여객기에 탑승했던 170명 전원이 사망하였으며,]:24", "[수학여행을 가던 '서안 고등학교' 학생들이 탑승하고 있었던 것으로 알려졌다.]:24", "[항공사 관계자는 현재 정확한 사고 원인을 조사하고 있다고 말했다.]:24", ".....:32" });

        //*** 110번대 퀘스트 ***
        //110
        talkData.Add(110 + 19000, new string[] { "(스마트폰이다.):0", "(잠금화면에 부재중 전화가 20통 이상 쌓인 것이 눈에 띈다.):0", "(발신자 이름은 '임지은'이다.):0", "(이외에도 그녀가 보낸 문자가 여러 개 보지 않은 채 쌓여있다.):0", "(잠금화면에서 본 마지막 문자의 내용은       [ 제발 아무것도 하지 말고 기다려줘. ]다.):17" });

        //111
        talkData.Add(111 + 20000, new string[] { "(책상 위에 커터칼이 있다.):14", "(이게 왜 여기에...):14", "(칼날에 붉은 피가 선명하게 묻어있다...):17" });

        //112
        talkData.Add(112 + 11000, new string[] { "...이젠 여기가 어딘지 알 것 같아?:21", "(나는 말없이 고개를 끄덕였다.):32", "여긴... 나하고 동생이 살던 곳이야.:32", "어렵게 얻은 원룸이었지만, 우린 같이 있을 수 있다는 것만으로도 행복했었어.:32", "(그가 아무런 반응 없이 그저 가만히 듣고만 있다...):4", "(잠시 후, 그가 주머니에서 카드 세 장을 꺼내더니 내 눈앞에 펼쳤다.):14", "자, 선택해.:4", "(...갑자기?):14", "(영문을 모르겠다.):14", "잠시 생각할 시간을 줄 수 있어?:18", "그래.:4" });

        //113
        talkData.Add(113 + 11000, new string[] { "뭘 선택할지 생각해봤어?:4", "...응.:0"});

        //114
        talkData.Add(114 + 11000, new string[] { "...처음 봤을 땐 누군지 몰랐지만, 이젠 알 것 같아.:34", "네 정체는...:32", "잠깐.:4", "지금은 내가 중요한 게 아냐.:4", "아직 끝나지 않았어.:4", "네가 이곳에 오기까지 어떤 목표가 있었잖아.:4", "그걸 다하고 나면... 네 질문에 대답해 줄게.:21", "...알았어.:32" });

        //115
        talkData.Add(115 + 22000, new string[] { "(화장실로 가는 문이다.):0", "(핏자국이 이곳으로 향하고 있다...):17", "(하지만 열쇠 구멍도 없을뿐더러 열리지 않는다.):17", "...다른 욕실은 열리지 않았을까?:0" });



        //116
        talkData.Add(116 + 73000, new string[] { "(...여기다.):0", "(들어가자.):0" });

        //**수정! 여기부터  120번대
        //120
        talkData.Add(120 + 23000, new string[] { "(변기 위에 물에 젖은 증명사진이 있다.):14", "(누군지는 알아볼 수 없다.):35", "('서안 고등학교'의 교복을 입고 있다는 것만 겨우 파악할 수 있다.):35", "(바닥에 물 한 방울도 없는 걸 보니, 이 젖은 자국의 정체는...):32" });

        //121
        talkData.Add(121 + 24000, new string[] { "(피가 묻은 커터칼이다.):17", "다른 원룸에서 본 게 어째서 여기에 있는 거지...?:17", "(무언가 불길한 예감이 든다...):17" });
        portraitData.Add(24000 + 0, portraitArr[0]);
        portraitData.Add(24000 + 1, portraitArr[1]);
        portraitData.Add(24000 + 2, portraitArr[2]);
        portraitData.Add(24000 + 3, portraitArr[3]);
        portraitData.Add(24000 + 4, portraitArr[4]);
        portraitData.Add(24000 + 5, portraitArr[5]);
        portraitData.Add(24000 + 6, portraitArr[6]);
        portraitData.Add(24000 + 7, portraitArr[7]);
        portraitData.Add(24000 + 8, portraitArr[8]);
        portraitData.Add(24000 + 9, portraitArr[9]);
        portraitData.Add(24000 + 10, portraitArr[10]);
        portraitData.Add(24000 + 11, portraitArr[11]);
        portraitData.Add(24000 + 12, portraitArr[12]);
        portraitData.Add(24000 + 13, portraitArr[13]);
        portraitData.Add(24000 + 14, portraitArr[14]);
        portraitData.Add(24000 + 15, portraitArr[15]);
        portraitData.Add(24000 + 16, portraitArr[16]);
        portraitData.Add(24000 + 17, portraitArr[17]);

        //*** 120번대 ***

        //122
        talkData.Add(122 + 25000, new string[] { "(욕조에 물이 가득 차올랐다.):0", "(물인지, 피인지 알 수 없을 정도로 새빨갛다.):17", "(순간 번뜩하고 어떤 장면이 떠올랐다.):1", "(내가 커터칼을 들고 욕조로 향하던 모습이...):1", "(...그렇구나. 나는 이곳에서...):32" });

        //123
        talkData.Add(123 + 25000, new string[] { "(욕조의 물을 빼면 무언가가 나올 것 같다는 생각이 든다.):0", "(손을 뻗어 욕조마개를 열었다.):17" });

        //124
        talkData.Add(124 + 26000, new string[] { "(물이 빠져나간 자리에 별의 조각이 있다.):14", "혹시나 했지만 진짜로 여기에 있을 줄이야...:14", "(이걸로 네 번째 조각이다.):0", "(이제 이곳에 볼일은 없다.):0", "(다시 원룸으로 돌아가자.):0" });

        //125
        talkData.Add(125 + 27000, new string[] { "(별의 조각이다.):0", "(...이걸로 다섯 개째다.):0", "(드디어 전부 다 모았다.):0", "(이제 제단으로 가자.):0" });
        portraitData.Add(27000 + 0, portraitArr[0]);


        //**여기부터 Final Stage 퀘스트**//
        //(130부터)

        //130
        talkData.Add(130 + 47000, new string[] { "여기가... 제단...:0" ,"여기 위에 별의 조각을 올려놓으면 되는 거지...?:18", "(이제까지 모은 별의 조각을 하나씩 놓아보자.):0" });
        

        //131
        talkData.Add(131 + 47000, new string[] { "(첫 번째 별의 조각을 올렸다.):0", "(두 번째 별의 조각을 올려보자.):0" });

        //132
        talkData.Add(132 + 47000, new string[] { "(두 번째 별의 조각을 올렸다.):0", "(제단에 올려놓은 두 개의 별의 조각이 합쳐진 것이 보인다.):14", "...놀라워할 때가 아니지.:0", "(빨리 별을 놓고 저 남자와 마저 얘기를 나눠야 한다.):0" });

        //133
        talkData.Add(133 + 47000, new string[] { "(세 번째 별의 조각을 올렸다.):0" });

        //134
        talkData.Add(134 + 47000, new string[] { "(네 번째 별의 조각을 올렸다.):0" });

        //135
        talkData.Add(135 + 47000, new string[] { "(마지막... 별의 조각을 제단 위에 올렸다.):0" });

        //136
        talkData.Add(136 + 42000, new string[] { "여기까지 오는데 많이 힘들었을 텐데... 고생 많았어.:23", "덕분에 이 세상에 다시 별이 뜰 수 있을거야.:23", ".....:32", "...나한테 말하고 싶은게 있다고 했었지?:37", "그게 뭐야?:23", ".....:32", "...네가 누군지 알 것 같아.:32", "...그래?:23", "내가 누군데?:37" });

        //137
        talkData.Add(137 + 42000, new string[] { "어째서 널 떠올리지 못했을까.:32", "하나밖에 없는 소중한 넌데...:32", "글세... :37" });
        

        //138
        talkData.Add(138 + 43000, new string[] { "나로선 형의 마음을 알 수 없으니 잘 모르겠지만...:44" ,"어쨌든 이렇게 다시 만나게 됐네, 형.  :47" });

        //**여기부터 140번대**//

        //140
        talkData.Add(140 + 43000, new string[] { "그동안 잘 지냈어?:47", "잘... 지냈을 리가 없잖아!:32", "보고 싶었다고, 정말로...:33", "(나는 선진이를 있는 힘껏 안았다.):32", "(손끝에 느껴지는 감각과 귀에 들리는 목소리가 그가 진짜 선진임을 알려주고 있었지만,):32", "(난 이미 알고 있었다.):32","(...이곳이 현실이 아니란 걸.):33", "(하지만...):32", "너와 헤어지고 싶지 않은데...:33", "(그때, 어떤 소리가 들려왔다.):24", "쿠구구....:24", "뭐지...?:14", "문이 나타나는 소리야.:44", "...문이라고? :14" });

        //141
        talkData.Add(141 + 43000, new string[] { "응. 현실 세계로 가는 문.:47", "...형도 짐작하고 있었잖아?:47", ".....:32", "그럼 내가 저 문으로 들어간다면...:32", "아쉽지만 작별인 거지.:43", "(이제야 얼굴을 봤는데...):32", "(벌써 헤어져야 한다고?):32", "(선진이와 조금만이라도,):32", "(아니, 예전처럼 계속 곁에 있고 싶다.):32", "(네가 없는 세상에 미련 같은 건 없으니까.):32", "(...일단 선진이와 계속 대화해보자.):32" });

        //142
        talkData.Add(142 + 43000, new string[] { "형, 여길 꼭 나가야 한다는 법은 없어.:44", "여기서 나갈지, 안 나갈지는 오롯이 형의 선택이야.:44", "내... 선택이라고.:32", "...결정했어.:0" });


        //**여기부턴 진엔딩 대사**//

        //143
        talkData.Add(143 + 43000, new string[] { "너와 헤어지긴 싫지만... 이곳까지 오면서 네가 해준 말들이 떠올랐어.:39","앞을 보고 나아가라고.:40", "항상 마음속에 별... 희망이 있다고.:40","나에게 있어 너는 내 삶의 유일한 희망이었어.:39", ".....:43", "네 소식을 들은 순간 자리에서 한 발짝도 움직일 수 없었어.:32", "삶의 원동력을 잃은 기분이었지.:32", "너와 마지막으로 한 마디라도 나눌 수 있었으면 좋겠다고...:33", "스스로 목숨을 앗아가기 전까지 간절히 바랐어.:33", "그래서 사실 지금, 이 순간이 마치 하늘에서 내게 준 선물같아.:39", "...아니, 네가 준비한 거려나.:40", ".....일찍 왔어.:46", "응?:14", "형 말이야.:45", "너무 일찍 왔다고!:45", "지금 형이 말한 거 내가 모르고 있었을 줄 알아?!:45", ".....:14", "지켜보고 있었다고.:42", "전부 다.:42", ".....:14", "형이 아픈 만큼 나도 아팠어.:42", "옆에서 괜찮다고 위로해주고 싶었는데...:42", "형이 날 볼 수도, 내 목소리를 들을 수도 없어서 얼마나 괴로웠는지 알아?:42", "그래...:39", "넌 언제나 내 곁에 있어 줬구나.:39", "난 그것도 모르고...:38", "알았으면 됐어.:41","...이제 헤어질 시간이야.:43", "이 공간은 곧 무너질 거야.:43", "어서 가.:43"});

        //144
        talkData.Add(144 + 53000, new string[] { ".....:32", "그런 눈빛 하지 마.:43", "그리고... 또 나 만나러 일찍 오면 가만 안 둔다!:45", "...그래.:39", "안녕, 선진아.:40", "...잘 가, 형.:43" });

        //145
        //talkData.Add(145 + 43000, new string[] { "나로선 형의 마음을 알 수 없으니 잘 모르겠지만...:0", "어쨌든 이렇게 다시 만나게 됐네, 형.  :0" });

        //146
        //talkData.Add(146 + 43000, new string[] { "나로선 형의 마음을 알 수 없으니 잘 모르겠지만...:0", "어쨌든 이렇게 다시 만나게 됐네, 형.  :0" });

        //147
        //talkData.Add(147 + 43000, new string[] { "나로선 형의 마음을 알 수 없으니 잘 모르겠지만...:0", "어쨌든 이렇게 다시 만나게 됐네, 형.  :0" });

        //148
        //talkData.Add(148 + 43000, new string[] { "나로선 형의 마음을 알 수 없으니 잘 모르겠지만...:0", "어쨌든 이렇게 다시 만나게 됐네, 형.  :0" });

    }



    public string GetTalk(int id, int talkIndex)//지정된 대화 문장을 반환하는 함수 생성함
    {
        if(! talkData.ContainsKey(id))//찾으려는 데이터가 없으면 퀘스트 대화순서 제거 후 재탐색
        {
            //<원래 있었던 거>

            /*if (!talkData.ContainsKey(id - id % 10))
              return GetTalk(id - id % 100, talkIndex);//첫번째 대화를 가져온다
            else
              return GetTalk(id - id % 10, talkIndex);//첫 번째 퀘스트 대화를 가져온다*/
            //반환 값이 있는 재귀함수는 return까지 꼭 써야함

            if (!talkData.ContainsKey(id - id % 100))
                return GetTalk(id - id % 1000, talkIndex);//첫번째 대화를 가져온다
            else if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex);//첫 번째 퀘스트 대화를 가져온다
            else if (talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 10, talkIndex);




        }

        //토크 인덱스가 다 끝나면 더 이상 남아있는 것이 없도록 함
        if (talkIndex == talkData[id].Length)
            return null;
        else//그 뒤에 있는 대화 마저 하기
            return talkData[id][talkIndex];

        



    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {//지정된 초상화 스프라이트를 반환할 함수 생성

        return portraitData[id + portraitIndex];
    }

}
