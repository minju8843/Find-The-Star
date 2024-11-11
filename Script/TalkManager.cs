using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;//string[]���ڿ��� �迭. ���ڸ� ���� �����Ŷ�
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;
    //�ʻ�ȭ ��������Ʈ�� ������ �迭 ����

    void Awake()
    {//���� �κ��� �ʱ�ȭ



        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();//�����͸� ����־��ִ� ������

        
    }


    void GenerateData()
    {
        


        //��������1
        talkData.Add(7900, new string[] { "�̰� ����...:0", "(���ɽ����� �ǵ���ô�.):0", "���� ����, �������!:5", "����! ��¦�̾�!: 1", "�� �׷��� ���� �ž�? �� �� �� ����?:4", "��. �� ���̴µ�...:0", "...�׷�?:4"});
        portraitData.Add(7900 + 0, portraitArr[0]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(7900 + 1, portraitArr[1]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(7900 + 2, portraitArr[2]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(7900 + 3, portraitArr[3]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(7900 + 4, portraitArr[4]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(7900 + 5, portraitArr[5]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(7900 + 6, portraitArr[6]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]


        talkData.Add(73000, new string[] { "ȭ��Ƿ� ���ϴ� ���̴�.:0"});
        portraitData.Add(73000 + 0, portraitArr[0]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(73000 + 1, portraitArr[1]);//����
        portraitData.Add(73000 + 2, portraitArr[2]);//����
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

        talkData.Add(200, new string[] { "(��Ʈ���̴�.):0", "(���� ��ư�� ������ �� �� ���� �� ����.):0" });
        portraitData.Add(200 + 0, portraitArr[0]);

        talkData.Add(68000, new string[] { "(�����̴�.):0", "(���� �ȿ� �ʵ�� �̺��� �ִ�.):0" });
        portraitData.Add(68000 + 0, portraitArr[0]);

        //���� �ִ� å��
        talkData.Add(400, new string[] { "(å���̴�.):0", "(å�忡 �پ��ִ� ���̰� ���δ�.):0", "[������ �з���ȣ]:24", "[�ѷ� - 000], [ö�� - 100], [���� - 200], [��ȸ���� - 300], [�������� - 400] :24", "[������� - 500], [���� - 600], [��� - 700], [���� - 800], [���� - 900]:24" });
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
  
     

        //������ å��
        talkData.Add(76000, new string[] { "(å���̴�.):0", "(������� �𸣴� ������ å�� �а� ���� �ʴ�.):2" });
        portraitData.Add(76000 + 0, portraitArr[0]);
        portraitData.Add(76000 + 1, portraitArr[1]);
        portraitData.Add(76000 + 2, portraitArr[2]);

        //������ ����1
        //talkData.Add(8900, new string[] { "(��Ź ���ڴ�.):0" });
        //portraitData.Add(8900 + 0, portraitArr[0]);

        //���� �ִ� ����1
        talkData.Add(1100, new string[] { "(���ڴ�.):0", "(���ڿ� ������ �پ��ִ�.):0", "[(����]:24" });
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

        //������ ����2
        //talkData.Add(8800, new string[] { "(��Ź ���ڴ�.):0" });
        //portraitData.Add(8800 + 0, portraitArr[0]);

        //���� �ִ� ����2
        talkData.Add(1300, new string[] { "(���ڴ�.):0", "(���ڿ� ������ �پ��ִ�.):0", "[+���]:24" });
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

        //�׳� �����
        talkData.Add(79000, new string[] { "(������.):0", "(����� �ȿ� �ƹ��͵� ����.):0" });
        portraitData.Add(79000 + 0, portraitArr[0]);


        //���� �ִ� �����
        talkData.Add(1200, new string[] { "(������.):0", "(����� ���� ������ �پ��ִ�.):0", "[( )�ȿ��� ���� 2���� ��ȣ�� 1�� �ִ�.]:24" });
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

        //�׳� ����������
        talkData.Add(78000, new string[] { "(������������.):0", "(�� �� �Ѻ���?):0", "ġ������...:24", "(������ �ʴ´�.):0" });
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

        //���� �ִ� ����������
        talkData.Add(1000, new string[] { "(������������.):0", "(������������ ������ �پ��ִ�.):0", "[/��������)]:24" });
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

        //�׳� ������
        talkData.Add(77000, new string[] { "(������.):0", "(���������� Ʋ���?):0", "������...:24", "(���� �� ���´�.):0" });
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


        //���� �ִ� ������
        talkData.Add(900, new string[] { "(�������.):0", "(�����뿡 ������ �پ��ִ�.):0", "[+��ȸ����]:24" });
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

        talkData.Add(35000, new string[] { "(â���̴�.):0", "(â������ ���� �ϴ��� ���δ�.):0", "(������, �޵�, ���� ���� ���� �ϴÿ� ���� ������ �Ѹ� �� ����.):0"});
        portraitData.Add(35000 + 0, portraitArr[0]);
        
        talkData.Add(69000, new string[] { "(ħ���.):0", "(���� �ǰ������� ������ ���� ������ ���� �� �켱�̴�.):0" });
        portraitData.Add(69000 + 0, portraitArr[0]);

        talkData.Add(37000, new string[] { "(�����̴�.):0"});
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

        talkData.Add(70000, new string[] { "(��Ź���.):0", "(��Ź�� �ȿ� ���𰡰� �ִ�.):0", "(�����̴�.):0", "��𼱰� �� ���� �ִ� �� ������...:0" });
        portraitData.Add(70000 + 0, portraitArr[0]);      

        talkData.Add(71000, new string[] { "(��Ź�̴�.):0", "(���ϰ� ���̰� �ִ�.):0", "(���̿� � �۾��� ���� �ִ�.):0", "[�������κ����� ������ �ǳ�ó�� ���� �ھƸ� �����ϴ� ���̴�.]:24" });
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

        talkData.Add(44000, new string[] { "(���� ���������� ���� ���̴�.):0", "(��ȣ Ű�� �ִ�.):0" });
        portraitData.Add(44000 + 0, portraitArr[0]);
        portraitData.Add(44000 + 1, portraitArr[1]);


        talkData.Add(80000, new string[] { "ȭ�鿡 � �۾��� �����ִ�.:0", "[ �츮���� �Ҹ��ؼ� �ȵ� ���� ���� �Ҹ��Ѵ�. 2021.09.15 ���� 11�� ] :24" });
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

        talkData.Add(75000, new string[] { "(������.):0" });
        portraitData.Add(75000 + 0, portraitArr[0]);

        talkData.Add(74000, new string[] { "(�����.):0" });
        portraitData.Add(74000 + 0, portraitArr[0]);

        talkData.Add(34000, new string[] { "(������.):0" });
        portraitData.Add(34000 + 0, portraitArr[0]);
        portraitData.Add(34000 + 1, portraitArr[1]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(34000 + 2, portraitArr[2]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
        portraitData.Add(34000 + 3, portraitArr[3]);//id+�� ��° ���忡 ����� ����, [�ʻ�ȭ ��ȣ]
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


        talkData.Add(39000, new string[] { "(���ǰ��̴�.):0" });
        portraitData.Add(39000 + 0, portraitArr[0]);
        portraitData.Add(39000 + 1, portraitArr[1]);//����
        portraitData.Add(39000 + 2, portraitArr[2]);//����
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

        /*talkData.Add(2200, new string[] { "(�������̴�.):0" });
        portraitData.Add(2200 + 0, portraitArr[0]);*/

        talkData.Add(4600, new string[] { "(�����ġ�� �ִ� ���̴�.):0", "(���� 6�ڸ� ���ڸ� �˾Ƴ��� ���ߴ�.) :2", "(�ֺ��� �� ã�ƺ���.):0" });
        portraitData.Add(4600 + 0, portraitArr[0]);//����
        portraitData.Add(4600 + 1, portraitArr[1]);//���� ���
        portraitData.Add(4600 + 2, portraitArr[2]);//����
        portraitData.Add(4600 + 3, portraitArr[3]);//����

        //��������2
        talkData.Add(7500, new string[] { "��... �Ȼ��� �� ���� ���̴µ�, ������?:8", "��?:0", "��. ������. ����... �Ӹ��� ���� ���̾�.:3", "�׷�...:11" });
        portraitData.Add(7500 + 0, portraitArr[0]);//����
        portraitData.Add(7500 + 1, portraitArr[1]);//���� ���
        portraitData.Add(7500 + 2, portraitArr[2]);//����
        portraitData.Add(7500 + 3, portraitArr[3]);//����

        portraitData.Add(7500 + 4, portraitArr[4]);//NPC1-����
        portraitData.Add(7500 + 5, portraitArr[5]);//NPC1-���� ����
        portraitData.Add(7500 + 6, portraitArr[6]);//NPC1-ȭ��

        portraitData.Add(7500 + 7, portraitArr[7]);//NPC2-���
        portraitData.Add(7500 + 8, portraitArr[8]);//NPC2-��Ȳ �� ����
        portraitData.Add(7500 + 9, portraitArr[9]);//NPC2-�̼�
        portraitData.Add(7500 + 10, portraitArr[10]);//NPC2-�� ���� ����. �̾���
        portraitData.Add(7500 + 11, portraitArr[11]);//NPC2-�⺻ ǥ��

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

        //�Ϲ� ���(�߱����� ����Ʈ���� �׳� ���� ����.)

        //(2023.02.25)-����Ʈ���� �׳� ������ ��� �� �ôµ� �� �� ����� �ž�? �� ��찡 �߻��� �� �ֱ⿡ �߰��Ѵ�
        //���� ������ ��ȣ�� 97000
        talkData.Add(97000, new string[] { "(�߱����̴�.):0", "(������ �������� �Բ� �� ���� ������ ���.):0" });
        portraitData.Add(97000 + 0, portraitArr[0]);//����
        portraitData.Add(97000 + 1, portraitArr[1]);//����
        portraitData.Add(97000 + 2, portraitArr[2]);//����
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



        talkData.Add(57000, new string[] { "(�߱����̴�.):0", "(������ �������� �Բ� �� ���� ������ ���.):0", "(�ڼ��� ���� �Ա� �� �ʷϻ� ǥ���ǿ� ���𰡰� ���� �ִ�.):0", "[������ ���� ������ �ƴմϴ�. ������ �� �湮�� �ּ���.]:24", "[ThOs Os not the regular season. Please vOsOt agaOn next tOme.]:24" });
        portraitData.Add(57000 + 0, portraitArr[0]);//����
        portraitData.Add(57000 + 1, portraitArr[1]);//����
        portraitData.Add(57000 + 2, portraitArr[2]);//����
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

        //**������� �м�**(16��)
        talkData.Add(55000, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
        portraitData.Add(55000 + 0, portraitArr[0]);//����
        portraitData.Add(55000 + 1, portraitArr[1]);//���� ���
        portraitData.Add(55000 + 2, portraitArr[2]);//����
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


        /* talkData.Add(6500, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(6500 + 0, portraitArr[0]);//����
         portraitData.Add(6500 + 1, portraitArr[1]);//���� ���
         portraitData.Add(6500 + 2, portraitArr[2]);//����

         talkData.Add(6600, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(6600 + 0, portraitArr[0]);//����
         portraitData.Add(6600 + 1, portraitArr[1]);//���� ���
         portraitData.Add(6600 + 2, portraitArr[2]);//����

         talkData.Add(6700, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(6700 + 0, portraitArr[0]);//����
         portraitData.Add(6700 + 1, portraitArr[1]);//���� ���
         portraitData.Add(6700 + 2, portraitArr[2]);//����

         talkData.Add(6800, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(6800 + 0, portraitArr[0]);//����
         portraitData.Add(6800 + 1, portraitArr[1]);//���� ���
         portraitData.Add(6800 + 2, portraitArr[2]);//����

         talkData.Add(6900, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(6900 + 0, portraitArr[0]);//����
         portraitData.Add(6900 + 1, portraitArr[1]);//���� ���
         portraitData.Add(6900 + 2, portraitArr[2]);//����

         talkData.Add(7000, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7000 + 0, portraitArr[0]);//����
         portraitData.Add(7000 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7000 + 2, portraitArr[2]);//����

         talkData.Add(7100, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7100 + 0, portraitArr[0]);//����
         portraitData.Add(7100 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7100 + 2, portraitArr[2]);//����

         talkData.Add(7200, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7200 + 0, portraitArr[0]);//����
         portraitData.Add(7200 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7200 + 2, portraitArr[2]);//����

         talkData.Add(7300, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7300 + 0, portraitArr[0]);//����
         portraitData.Add(7300 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7300 + 2, portraitArr[2]);//����

         talkData.Add(7400, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7400 + 0, portraitArr[0]);//����
         portraitData.Add(7400 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7400 + 2, portraitArr[2]);//����

         talkData.Add(7500, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7500 + 0, portraitArr[0]);//����
         portraitData.Add(7500 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7500 + 2, portraitArr[2]);//����

         talkData.Add(7600, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7600 + 0, portraitArr[0]);//����
         portraitData.Add(7600 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7600 + 2, portraitArr[2]);//����

         talkData.Add(7700, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7700 + 0, portraitArr[0]);//����
         portraitData.Add(7700 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7700 + 2, portraitArr[2]);//����

         talkData.Add(7800, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7800 + 0, portraitArr[0]);//����
         portraitData.Add(7800 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7800 + 2, portraitArr[2]);//����

         talkData.Add(7900, new string[] { "(�м���.):0", "(������ ���� ������, ���ٱⰡ ���� ���Ҹ� �� ��Ⱑ ���� �ʴ´�.):2" });
         portraitData.Add(7900 + 0, portraitArr[0]);//����
         portraitData.Add(7900 + 1, portraitArr[1]);//���� ���
         portraitData.Add(7900 + 2, portraitArr[2]);//����*/

        //�Ϲ� ���(������ ����Ʈ���� �׳� ���� ����.)

        // *** (2023.02.25)-����Ʈ���� �׳� ������ ��� �� �ôµ� �� �� ����� �ž�? �� ��찡 �߻��� �� �ֱ⿡ �߰��Ѵ� ***
        //���� ������ ��ȣ�� 98000

        talkData.Add(98000, new string[] { "(������.):0" });
        portraitData.Add(98000 + 0, portraitArr[0]);//����
        portraitData.Add(98000 + 1, portraitArr[1]);//����
        portraitData.Add(98000 + 2, portraitArr[2]);//����
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


        talkData.Add(58000, new string[] { "(������.):0", "(���� â�� ���𰡰� �پ� �ִ�.):0", "[ù ���ڴ� �Ķ���, �� ��° ���ڴ� �������̴�.]:24" });
        portraitData.Add(58000 + 0, portraitArr[0]);//����
        portraitData.Add(58000 + 1, portraitArr[1]);//����
        portraitData.Add(58000 + 2, portraitArr[2]);//����
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

        //�Ϲ� ���
        //2400���� 81000
        talkData.Add(81000, new string[] { "(��������.):0", "(���� ĭ �ȿ��� �ƹ��͵� ����.):2" });
        portraitData.Add(81000 + 0, portraitArr[0]);//����
        portraitData.Add(81000 + 1, portraitArr[1]);//����
        portraitData.Add(81000 + 2, portraitArr[2]);//����

        //�Ϲ� ���
        talkData.Add(36000, new string[] { "(��������.):0", "(��� ĭ �ȿ��� �ƹ��͵� ����.):2" });
        portraitData.Add(36000 + 0, portraitArr[0]);//����
        portraitData.Add(36000 + 1, portraitArr[1]);//����
        portraitData.Add(36000 + 2, portraitArr[2]);//����

        //***��������***
        //�Ϲ� ���
        talkData.Add(59000, new string[] { "(��������.):0", "(�ȿ� ���𰡰� �ִ�.):0", "(����� ������.):0", "(������ �̷��� ���� �ִ�.):0", "[��, �����.(I love O.)]:24", "(���� ���� ���� ������ ���.):2" });
        portraitData.Add(59000 + 0, portraitArr[0]);//����
        portraitData.Add(59000 + 1, portraitArr[1]);//����
        portraitData.Add(59000 + 2, portraitArr[2]);//����
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

        //�Ϲ� ���
        //2600�� 82000
        talkData.Add(82000, new string[] { "(��������.):0", "(������ ĭ �ȿ��� �ƹ��͵� ����.):2" });
        portraitData.Add(82000 + 0, portraitArr[0]);//����
        portraitData.Add(82000 + 1, portraitArr[1]);//����
        portraitData.Add(82000 + 2, portraitArr[2]);//����

        //**Ÿ��ĸ�� 8�� ����***
        //2800->83000
        talkData.Add(83000, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ NE ]:24" });
        portraitData.Add(83000 + 0, portraitArr[0]);//����
        portraitData.Add(83000 + 1, portraitArr[1]);//����
        portraitData.Add(83000 + 2, portraitArr[2]);//����
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
        talkData.Add(84000, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ E ]:24" });
        portraitData.Add(84000 + 0, portraitArr[0]);//����
        portraitData.Add(84000 + 1, portraitArr[1]);//����
        portraitData.Add(84000 + 2, portraitArr[2]);//����
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
        talkData.Add(85000, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ SE ]:24" });
        portraitData.Add(85000 + 0, portraitArr[0]);//����
        portraitData.Add(85000 + 1, portraitArr[1]);//����
        portraitData.Add(85000 + 2, portraitArr[2]);//����
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
        talkData.Add(86000, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ SW ]:24" });
        portraitData.Add(86000 + 0, portraitArr[0]);//����
        portraitData.Add(86000 + 1, portraitArr[1]);//����
        portraitData.Add(86000 + 2, portraitArr[2]);//����
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
        talkData.Add(87000, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ W ]:24" });
        portraitData.Add(87000 + 0, portraitArr[0]);//����
        portraitData.Add(87000 + 1, portraitArr[1]);//����
        portraitData.Add(87000 + 2, portraitArr[2]);//����
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
        talkData.Add(88000, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ NW ]:24" });
        portraitData.Add(88000 + 0, portraitArr[0]);//����
        portraitData.Add(88000 + 1, portraitArr[1]);//����
        portraitData.Add(88000 + 2, portraitArr[2]);//����
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

        //Ÿ��ĸ���� �ް�(��)
       // talkData.Add(3900, new string[] { "(Ÿ��ĸ�� ����� �� ��ȫ�� �����̴�.):0" });
        //portraitData.Add(3900 + 0, portraitArr[0]);//����

        //Ÿ��ĸ���� �ް�(��)
        //talkData.Add(4000, new string[] { "(Ÿ��ĸ�� ����� �� Ǫ���� �����̴�.):0" });
        //portraitData.Add(4000 + 0, portraitArr[0]);//����

        //��(����� ��)
        talkData.Add(6100, new string[] { "(���̴�.):0" });
        portraitData.Add(6100 + 0, portraitArr[0]);//����

        //��(��Ÿ�� ��)
        //**����Ʈ ������ �ƴ�. �׳� �� ����.**
        //8200->89000
        talkData.Add(89000, new string[] { "(���̴�.):0" });
        portraitData.Add(89000 + 0, portraitArr[0]);//����

        //�� �ؿ� ����
        talkData.Add(61000, new string[] { "(������ ������.):0", "(������ � �۾��� ���� �ִ�.):0", "[�� ��°�� ���� ��° ���ڴ� ����.]:24" });
        portraitData.Add(61000 + 0, portraitArr[0]);//����
        portraitData.Add(61000 + 1, portraitArr[1]);//����
        portraitData.Add(61000 + 2, portraitArr[2]);//����
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

        //������ ��Ʈ
        //8100->90000
        talkData.Add(90000, new string[] { "(���� ������ ��Ʈ��.):0" });
        portraitData.Add(90000 + 0, portraitArr[0]);//����
        /*portraitData.Add(4200 + 1, portraitArr[1]);//���� ���
        portraitData.Add(4200 + 2, portraitArr[2]);//����
        portraitData.Add(4200 + 3, portraitArr[3]);//����*/

        //��Ʈ2
       /* talkData.Add(4200, new string[] { "(��Ʈ��.):0" });
        portraitData.Add(4200 + 0, portraitArr[0]);//����

        //��Ʈ3
        talkData.Add(4300, new string[] { "(��Ʈ��.):0" });
        portraitData.Add(4300 + 0, portraitArr[0]);//����*/

        //��Ʈ4
       /* talkData.Add(4400, new string[] { "(��Ʈ��.):0" });
        portraitData.Add(4400 + 0, portraitArr[0]);//����    */    

        //ķ��ī1(����� ����)
        talkData.Add(4700, new string[] { "(ķ��ī��.):0" });
        portraitData.Add(4700 + 0, portraitArr[0]);//����

        //ķ��ī1(�������� ��)
        talkData.Add(62000, new string[] { "(ķ��ī��.):0", "(���� ����� ������ �پ��ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[?? = ķ���� ���� �� �غ����� ķ��ī�� ó���ΰ�? �� ��������?]:24", "[?? = �������� ��, ����, ���İŸ��� ì�ܾ���. ����, ���� �� �԰� ���� �� �ִ�?]:24", "[??? = �� ����!]:24", "[???? = �� *�ֽ�*! ������ *�ֽ�*! ��, *����*��!]:24" });
        portraitData.Add(62000 + 0, portraitArr[0]);//����
        portraitData.Add(62000 + 1, portraitArr[1]);//����
        portraitData.Add(62000 + 2, portraitArr[2]);//����
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

        //ķ��ī2
        /*talkData.Add(4800, new string[] { "(ķ��ī��.):0" });
        portraitData.Add(4800 + 0, portraitArr[0]);//����*/

        //ķ��ī3
        /*talkData.Add(4900, new string[] { "(ķ��ī��.):0" });
        portraitData.Add(4900 + 0, portraitArr[0]);//����*/

        //ĳ���1(����� ����)
        talkData.Add(5000, new string[] { "(ī����̴�.):0" });
        portraitData.Add(5000 + 0, portraitArr[0]);//����

        //ĳ���1(�������� ��)
        talkData.Add(64000, new string[] { "(ī����̴�.):0", "(���� ����� ������ �پ��ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[4��° ���ڴ� ������ �ƴϴ�.]:24" });
        portraitData.Add(64000 + 0, portraitArr[0]);//����
        portraitData.Add(64000 + 1, portraitArr[1]);//����
        portraitData.Add(64000 + 2, portraitArr[2]);//����
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

        //ĳ���2
        /*talkData.Add(5100, new string[] { "(ĳ����̴�.):0" });
        portraitData.Add(5100 + 0, portraitArr[0]);//����

        //ĳ���3
        talkData.Add(5200, new string[] { "(ĳ����̴�.):0" });
        portraitData.Add(5200 + 0, portraitArr[0]);//����*/

        //å�� ��(1)
        /*talkData.Add(5300, new string[] { "(å���̴�.):0" });
        portraitData.Add(5300 + 0, portraitArr[0]);//����*/

        //å�� ��(2)(����� ����)
        talkData.Add(5400, new string[] { "(å���̴�.):0" });
        portraitData.Add(5400 + 0, portraitArr[0]);//����

        //å�� ��(2)(�¾� å�� ���� å��)
        //������� ����
        talkData.Add(66000, new string[] { "(å���̴�.):0", "(å�� ���� �¾� �׸��� �׷��� ��Ʈ�� �ִ�.):0", "(��Ʈ�� ��ġ�� � �۾��� ���� �ִ� ���� ���δ�.):0", "[�츮�� ����� ���� ���� ��� �װ��� ���� �ִ�.]:24" });
        portraitData.Add(66000 + 0, portraitArr[0]);//����
        portraitData.Add(66000 + 1, portraitArr[1]);//����
        portraitData.Add(66000 + 2, portraitArr[2]);//����
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

        //å�� ��(3)(����� ����)
        talkData.Add(5500, new string[] { "(å���̴�.):0" });
        portraitData.Add(5500 + 0, portraitArr[0]);//����

        //å�� ��(3)(��Ÿ�� ��)-�Ķ� ����
        talkData.Add(65000, new string[] { "(å���̴�.):0", "(å�� ���� �Ķ��� ������ �ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[���� ���� �� ù ��° ���ڸ� �빮�ڴ�.]:24" });
        portraitData.Add(65000 + 0, portraitArr[0]);//����
        portraitData.Add(65000 + 1, portraitArr[1]);//����
        portraitData.Add(65000 + 2, portraitArr[2]);//����
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

        //å�� ��(1)
        /*talkData.Add(5600, new string[] { "(å���̴�.):0" });
        portraitData.Add(5600 + 0, portraitArr[0]);//����*/

        //å�� ��(2)(����� ����)
        talkData.Add(5700, new string[] { "(å���̴�.):0" });
        portraitData.Add(5700 + 0, portraitArr[0]);//����

        //å�� ��(2)-���� ����
        talkData.Add(63000, new string[] { "(å���̴�.):0", "(å�� ���� ����� ������ �ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[�� ��° ���ڴ� *���̿� �ִ� �� ���� �Ÿ��� �������� �� ���� �� �ϳ���.]:24" });
        portraitData.Add(63000 + 0, portraitArr[0]);//����
        portraitData.Add(63000 + 1, portraitArr[1]);//����
        portraitData.Add(63000 + 2, portraitArr[2]);//����
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

        //å�� ��(3)
        /*talkData.Add(5800, new string[] { "(å���̴�.):0" });
        portraitData.Add(5800 + 0, portraitArr[0]);//����*/

        //����ġ(����� ����)
        talkData.Add(5900, new string[] { "(�м��� ����ġ�� ����ִ� ���̴�.):0", "(����ũ�� Ƣ� �Ժη� ���� �� ����.):0" });
        portraitData.Add(5900 + 0, portraitArr[0]);//����
        portraitData.Add(5900 + 1, portraitArr[1]);//����
        portraitData.Add(5900 + 2, portraitArr[2]);//����
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

        //������ ����ġ
        //8000->91000
        talkData.Add(91000, new string[] { "(�м��� ����ġ��.):0", "(�ٽ� �м��� �� ����?):0", "ö��ö��...:24", "...:0", "(���� �� �� ����...):2" });
        portraitData.Add(91000 + 0, portraitArr[0]);//����
        portraitData.Add(91000 + 1, portraitArr[1]);//���� ���
        portraitData.Add(91000 + 2, portraitArr[2]);//����
        portraitData.Add(91000 + 3, portraitArr[3]);//����
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

        //�絿��(�Ϲ�)
        talkData.Add(6000, new string[] { "(�絿�̴�.):0" });
        portraitData.Add(6000 + 0, portraitArr[0]);//����

        //����Ʈ ��Ʈ
        talkData.Add(4100, new string[] { "(��Ʈ��.):0", "(�ٸ� ��Ʈ�� ���� ������ ���δ�.):0" });
        portraitData.Add(4100 + 0, portraitArr[0]);//����
        portraitData.Add(4100 + 1, portraitArr[1]);//����
        portraitData.Add(4100 + 2, portraitArr[2]);//����
        portraitData.Add(4100 + 3, portraitArr[3]);//����
        portraitData.Add(4100 + 4, portraitArr[4]);//����
        portraitData.Add(4100 + 5, portraitArr[5]);//����
        portraitData.Add(4100 + 6, portraitArr[6]);//����
        portraitData.Add(4100 + 7, portraitArr[7]);//����
        portraitData.Add(4100 + 8, portraitArr[8]);//����
        portraitData.Add(4100 + 9, portraitArr[9]);//����
        portraitData.Add(4100 + 10, portraitArr[10]);//����
        portraitData.Add(4100 + 11, portraitArr[11]);//����
        portraitData.Add(4100 + 12, portraitArr[12]);//����
        portraitData.Add(4100 + 13, portraitArr[13]);//����
        portraitData.Add(4100 + 14, portraitArr[14]);//����
        portraitData.Add(4100 + 15, portraitArr[15]);//����
        portraitData.Add(4100 + 16, portraitArr[16]);//����
        portraitData.Add(4100 + 17, portraitArr[17]);//����
        portraitData.Add(4100 + 18, portraitArr[18]);//����

        talkData.Add(2900, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(���� ���� �Ϻκ��� �Ӱ� ���δ�.):0", "���� ������ ������ �޶��� �� ������...:0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ N ]:24" });
        portraitData.Add(2900 + 0, portraitArr[0]);//����
        portraitData.Add(2900 + 1, portraitArr[1]);//����
        portraitData.Add(2900 + 2, portraitArr[2]);//����
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

        talkData.Add(3100, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(���� ���� �Ϻκ��� Ǫ���� ���δ�.):0", "���� ������ ������ �޶��� �� ������...:0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ S ]:24" });
        portraitData.Add(3100 + 0, portraitArr[0]);//����
        portraitData.Add(3100 + 1, portraitArr[1]);//����
        portraitData.Add(3100 + 2, portraitArr[2]);//����
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

        //������ Ÿ��ĸ��
        //3700->92000
        talkData.Add(92000, new string[] { "(������ ���� ���̴�.):0", "�񼮿� [ N ]�̶�� ���� �۾��� �����ϰ� ���δ�.:0" });
        portraitData.Add(92000 + 0, portraitArr[0]);//����


        //�Ķ��� Ÿ��ĸ��
        //3800->93000
        talkData.Add(93000, new string[] { "(�Ķ��� ���� ���̴�.):0", "�񼮿� [ S ]�̶�� ���� �۾��� �����ϰ� ���δ�.:0" });
        portraitData.Add(93000 + 0, portraitArr[0]);//����

        //��������3
        talkData.Add(54000, new string[] { "(���� ��ҷ� ���� ���̴�.):17", "��ݱ��� �и� �����־��µ�...?:17", "(��й�ȣ��, ���豸�۵� ����...):17", "(�����̸� �������� ������ �ʴ´�...):17" });
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


        talkData.Add(9500, new string[] { "(���� ��ҷ� ���� ���̴�.):17", "(...�Ϸ绡�� �̰��� ����� �ʹ�):17" });
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


        talkData.Add(4200, new string[] { "���� ��� ũ�� ��ȣ���ϰ�, ������ �а� ��.:4", "�׷��� ������ ���̱� ������ �ž�.:4" });
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

        talkData.Add(46000, new string[] { "(�����ǥ��.):17", "[ ���ʿ��� ���������� A ~ F, �տ��� �ڷ� 1 ~ 10 ]�̶� �ȳ� ������ �Բ� �¼���ȣ�� ���� �ִ�.:17", "(ǥ�� ���� �¼���ȣ�� F7�̴�.):17" });
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

        talkData.Add(6600, new string[] { "(F7 �¼��̴�.):17" });
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

        talkData.Add(49000, new string[] { "(...�Ӱ� ���� ���ڴ�.):16" });
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

        //talkData.Add(7000, new string[] { "(����������.):17", "(������ ������ ������ �ִ�.):17", "(...���� ���� �־��� �ɱ�?):17" });
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

        talkData.Add(51000, new string[] { "(������ �ڱ��� �ִ� �����̴�.):17", "(���� ������ ������ ���ǲ�� ������ ����...):19" });
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

        talkData.Add(56000, new string[] { "(������.):17", "(���̾��� ������ ���ļ��� ����ô�.):17", "ġ����...:0", "� �Ҹ��� �鸮�� �����Ѵ�.:0", "[ ���� ���� 11�ð� ���ֵ��� ���ϴ� ����Ⱑ ���߷� ���� �߶��ϴ� ��� �߻��߽��ϴ�. ]:24", "[ �ش� ����⿡�� ���п����� ���� ������ ����б����л����� ž���ϰ� �־��� ������ �˷���... ]:24", "(�� ������ �鸮�� �ʴ´�.):2" });
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

        talkData.Add(52000, new string[] { "(����Ʈ���̴�.):17", "(ȭ���� �Ѻ��� ���������� ���ڸ� ���� ������ �ִ�.):0", "(�����ڴ� �����Ѻ����̴�.):0", "...����.:17", "(���� ������ �о�Ҵ�.):17", "[ ��. ����Ⱑ ���� �̻���. â���� ���µ� ���� ���Ⱑ ����... ]:24", "(�ٸ� ������ ������ �ʴ´�.):17", "(����ȭ������ ���ư� �޴��� ������ �̸��� Ȯ���غô�.):17", "(...'�輱��'�̴�.):14", "(.....):19" });
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



        //** ��������4 **

        //������ ��
        talkData.Add(18000, new string[] { "(�������� ���� ���̴�.):0","(���� ������ �� ã�� ������ �� �� ����.):0" });
        portraitData.Add(18000 + 0, portraitArr[0]);
        portraitData.Add(18000 + 1, portraitArr[1]);
        portraitData.Add(18000 + 2, portraitArr[2]);
        portraitData.Add(18000 + 3, portraitArr[3]);
        portraitData.Add(18000 + 4, portraitArr[4]);

        //NPC1
        talkData.Add(11000, new string[] { "�̴����� �����̾�.:4", "�������� ���� ���� �ؾ� �� �� ���� �ʾ�?:4" });
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

        //�޷�
        talkData.Add(12000, new string[] { "(�޷��̴�.):0", "(�޷��� 10�� 2�Ͽ� ���׶�̰� ó���ִ�.):0", "('�̻� �� ��'�̶� ���� �ִ�.):0" });
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

        //â�� �� ����
        talkData.Add(13000, new string[] { "(���ڴ�.):0", "(���� �� ������ Ȯ���� �ô�.):0", "(�߱��� �տ��� ���� �����̴�.):0", "(2��° �������� �� �߱���� �Ȱ��� �����.):0", "(���� �ӿ� �� ����� �ִ�.):0", "(�� ����� ����.):26", "(�׸��� �� ���� �ִ� �����...):27", ".....:32" });
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

        //���� �� ����
        talkData.Add(14000, new string[] { "(���ڰ� �ִ�.):0", "(���� �� ������ ����� ī����̴�.):0", "(���ó� 2��° �������� �� ���̴�.):0", "(���� �ӿ� ����...):28", "(�� ���ڰ� ���� �ִ�.):29", "(�� �����...):32" });
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

        //���������� ����
        talkData.Add(15000, new string[] {"(���ڰ� �ִ�.):0", "(���� �� ������ Ȯ���� �ô�.):0", "(���̰������� ���� �����̴�.):0", "(�޹�濣 2��° �������� �� �������� �ִ�.):0", "(���� �ӿ� �� ����� �ִ�.):0", "(��������):36", "(��,):30", "(�׸��� �տ��� �� ���ڿ� �ִ� ���ڴ�.):31", "(���� �׵θ��� � �۾��� ���� �ִ�.):14", "[ �����̿� �� ���� �����̿� �Բ� ]:32", "������...:33" });
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

        //��Ź�� ��
        talkData.Add(16000, new string[] { "(��Ź�� ���� '���� ����б�'�� ������ �ִ�.):0",  "(���� �̸�ǥ�� ���� �̸��� '�輱��'�̴�.):32", "(�׷�... ���� �� �����̾�����...):32" });
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


        //�������� ��Ʈ��
        talkData.Add(17000, new string[] { "(������ ���� ��Ʈ���̴�.):0" });
        portraitData.Add(17000 + 0, portraitArr[0]);

        //�������� ��Ʈ��
        talkData.Add(48000, new string[] { "(���ͳ� ���� â�� ���δ�):0", "[9�� 15�� ���� 11���� ���ֵ��� ���ϴ� ����Ⱑ ���߷� ���� �ٴٿ� �߶��ϴ� ��� �߻��ߴ�.]:24", "[�ش� �����⿡ ž���ߴ� 170�� ������ ����Ͽ�����,]:24", "[���п����� ���� '���� ����б�' �л����� ž���ϰ� �־��� ������ �˷�����.]:24", "[�װ��� �����ڴ� ���� ��Ȯ�� ��� ������ �����ϰ� �ִٰ� ���ߴ�.]:24", ".....:32" });
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


        //����Ʈ��
        talkData.Add(19000, new string[] { "(����Ʈ���̴�.):0", "(���ȭ�鿡 ������ ��ȭ�� 20�� �̻� ���� ���� ���� ���.):0", "(�߽��� �̸��� '������'�̴�.):0", "(�̿ܿ��� �׳డ ���� ���ڰ� ���� �� ���� ���� ä �׿��ִ�.):0", "(���ȭ�鿡�� �� ������ ������ ������       [ ���� �ƹ��͵� ���� ���� ��ٷ���. ]��.):17" });
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


        //å�� Ŀ��Į
        talkData.Add(20000, new string[] { "(å�� ���� Ŀ��Į�� �ִ�.):14", "(�̰� �� ���⿡...):14", "(Į���� ���� �ǰ� �����ϰ� �����ִ�...):17" });
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


        //ȭ��ǹ�-����Ʈ ��
        talkData.Add(21000, new string[] { "(ȭ��Ƿ� ���� ���̴�):0", "(���� ���۵� �����Ӵ��� ������ �ʴ´�.):0" });
        portraitData.Add(21000 + 0, portraitArr[0]);

        //ȭ��ǹ�-����Ʈ ��
        talkData.Add(22000, new string[] { "(�̰��� �ƴϴ�.):0", "(ù ��° ���� ������ ����� �װ����� ���� �Ѵ�.):0"});
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

        //�������
        talkData.Add(23000, new string[] { "(���� ���� ���� ���� ��������� �ִ�.):14", "(�������� �˾ƺ� �� ����.):35", "('���� ����б�'�� ������ �԰� �ִٴ� �͸� �ܿ� �ľ��� �� �ִ�.):35", "(�ٴڿ� �� �� ��ﵵ ���� �� ����, �� ���� �ڱ��� ��ü��...):32" });
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

        //���� �� ����
        talkData.Add(25000, new string[] { "(������ ���� ���� ���ö���.):0", "(������, ������ �� �� ���� ������ ��������.):17", "(���� �����ϰ� � ����� ���ö���.):1", "(���� Ŀ�ͳ��� ��� ������ ���ϴ� �����...):1", "(...�׷�����. ���� �̰�����...):32" });
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


        //����&������ �ִϸ��̼�
        talkData.Add(26000, new string[] { "(���� �������� �ڸ��� ���� ������ �ִ�):14", "Ȥ�ó� ������ ��¥�� ���⿡ ���� ���̾�...:14", "(�̰ɷ� �� ��° �����̴�.):0", "(���� �̰����� ������ ����.):0", "(�ٽ� �������� ���ư���.):0" });
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

        //��������4 - ����� ����Ʈ�� ���þ��� �Ϲ� ������

        //ħ��-����Ʈ ��
        talkData.Add(40000, new string[] { "(ħ���.):0", "(������ ����� �� ���캸�� �� �켱�̴�.):0"});
        portraitData.Add(40000 + 0, portraitArr[0]);

        //ħ��-����Ʈ ��
        talkData.Add(29000, new string[] { "(ħ��� ���� ��� ����� �����.):0" });
        portraitData.Add(29000 + 0, portraitArr[0]);

        //����
        talkData.Add(50000, new string[] { "(�����̴�.):0", "(�� ���� ��� ���� ���� �ʾƵ� �� �� ����.):0" });
        portraitData.Add(50000 + 0, portraitArr[0]);

        //����-����Ʈ ��
        talkData.Add(30000, new string[] { "(�����̴�.):0", "(ħ������ �ʰ������� �ִ�.):0" });
        portraitData.Add(30000 + 0, portraitArr[0]);

        //����-����Ʈ ��
        talkData.Add(31000, new string[] { "(�����̴�.):0", "(���� �Ǹ� ���� �ִ� �̺��� ����, �� ���� ���� ���� �߾���...):0" });
        portraitData.Add(31000 + 0, portraitArr[0]);
     

        //�����-����Ʈ ��
        talkData.Add(41000, new string[] { "(������.):0", "(����� �ȿ� �ƹ��͵� ����.):0", "(�� �ƹ��͵� ����...?):14" });
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

        //�����-����Ʈ ��
        talkData.Add(32000, new string[] { "(������.):0", "(����� �ȿ� �ƹ��͵� ����.):0", "(...�׶� ���� �ʿ並 �� ��������.):0" });
        portraitData.Add(32000 + 0, portraitArr[0]);


        //��Ź��
        talkData.Add(33000, new string[] { "(��Ź���.):0","(��Ź�� �ȿ� '���� ����б�'�� ������ �ִ�.):0", "(...��� ���� �ôµ�?):18"});
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


        //â��
        talkData.Add(28000, new string[] { "(â���̴�.):0", "(������ â ������ ���� �ϴ��� ���δ�.):0" });
        portraitData.Add(28000 + 0, portraitArr[0]);


        //** Final Stage **//

        talkData.Add(47000, new string[] { "(�����̴�.):0", "(�ټ� ���� ���� ������ ������ ��� ������.):0", "(�� �̻� ���� �� ���� ����.):0", "(���� ���ڿ� ��ó ������ ���� ��⸦ �Ϸ�����.):0" });
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


        talkData.Add(42000, new string[] { "������ ���� �� �˰�����...:37", "���� �ؾ� �� �� �������� �ʾ�?:37" });
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

        talkData.Add(43000, new string[] { "� ��.:43" });
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

        talkData.Add(53000, new string[] { "�� ���� ����...?:14" });
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
        talkData.Add(10 + 200, new string[] { "(��Ʈ���̴�.):0", "(���� ��ư�� ������ �� �� ���� �� ����.):0", "�� �� �Ѻ���?:0" });

        //Quest Talk
        //11
        talkData.Add(11 + 35000, new string[] { "(â���̴�.):0", "(â������ ���� �ϴ��� ���δ�.):0", "(������, �޵�, ���� ���� ���� �ϴÿ� ���� ������ �Ѹ� �� ����.):0" });

        //12
        talkData.Add(12 + 7900, new string[] { "��, â�ۿ� �þ�?:4", "��.:0", "�� ���� ��ο ���� �ϳ��� ������ �ñ����� �ʾ�?:4", "��... �۽�?:0", "�� ���� ���� ���Ҵµ� �ϳ��Ѿ� �������� �����ϴ��� �ϳ��� ���� �ʰ� �� �ž�.:4", "�̴�� �ִٰ� �� ������ ����ϰ���.:4", "���� ���� ������ ������ �� ���ŵ�.:4", "Ȥ�� �� ���� ������ ������ ���� ������ ����ָ� �� �ɱ�?:4", "�������� ��Ƽ� ���ܿ� �ø��� ��.:4", "...�˾Ҿ�.:0" });

        //Quest Talk

        //13
        talkData.Add(13 + 73000, new string[] { "(���̴�.):0", "ö��ö��...:24", "(�����ִ�.):0", "(���谡 ������ �� �� ���� �� ����.):0" });

        //14
        talkData.Add(14 + 37000, new string[] { "�����̴�.:0", "������ �Ѹ� ���� ����� �ٵ�...:0", "�� �� �Ѻ���?:0", "��������...:24", "(������ �ʴ´�.):2", "��.:24", "��? ��� ���� �������� �Ҹ��� ��ȴµ�.:0" });

        //15
        talkData.Add(15 + 1600, new string[] { "(�����.):0", "(�ϴ� �ʿ����� �𸣴� ����.):0" });
        portraitData.Add(1600 + 0, portraitArr[0]);

        //20
        talkData.Add(20 + 73000, new string[] { "(���̴�.):0", "(��� �ֿ��� ����� �� �� ���� �� ����.):0", "ö��:24", "(���ȴ�.):0" });

        //���� ����1 ã��
        //20
        talkData.Add(21 + 34000, new string[] { "(������.):0", "�ǰ��ѵ� ������ �ұ�?:2", "���ƾƾ�...:24", "(�Ѱ� �������� �� ����.):3", "(�ٽ� �ѹ� ���縦 ������ ����.):0" });

        //21
        talkData.Add(22 + 39000, new string[] { "(���ǰ��̴�.):0", "(�������� ���� ���� �۾Ҵ�.):0", "��.:24", "(���� �������� �Ҹ��� ��ȴ�.):0" });

        //22
        talkData.Add(23 + 2700, new string[] { "(���� ������ �����̴�.):0", "(�°� ���� ���� ������ �̰ɱ�?):0", "(�ϴ� �������� ������߰ڴ�.):0" });
        portraitData.Add(2700 + 0, portraitArr[0]);

        //23
        talkData.Add(24 + 7900, new string[] { "�װ� ���� ���� ������ �̰ž�?:0", "�¾�. ã���༭ ����.:4", "���⼭ ã�� �� �ִ� ���� ������ �̰� ���� �ž�.:4", "�������� �ٸ� ���� ���� �״�, �װ͵� ã���ָ� �� �ɱ�?:4", "�˾Ҿ�.:0" });

        //24
        talkData.Add(25 + 44000, new string[] { "(������ ������ ���̴�.):0", "(����ִ�.):0", "(��ȣ Ű�� �ִ�.):0", "����...:0", "�� ���� �ٽ� �ѹ� �����غ��߰ھ�.:0", "�ϳ��ϳ� �ڼ��� ���� ���� ���� �� �� �ִ� ��Ʈ�� �������� ����.:0" });

        //30
        talkData.Add(30 + 400, new string[] { "(å���̴�.):0", "(å�忡 �پ��ִ� ���̰� ���δ�.):0", "[������ �з���ȣ]:24", "[�ѷ� - 000], [ö�� - 100], [���� - 200], [��ȸ���� - 300], [�������� - 400] :24", "[������� - 500], [���� - 600], [��� - 700], [���� - 800], [���� - 900]:24" });

        //31-36
        talkData.Add(31 + 1000, new string[] { "(������������.):0", "(������������ ������ �پ��ִ�.):0", "[/��������)]:24" });
        talkData.Add(32 + 900, new string[] { "(�������.):0", "(�����뿡 ������ �پ��ִ�.):0", "[+��ȸ����]:24" });
        talkData.Add(33 + 1200, new string[] { "(������.):0", "(����� ���� ������ �پ��ִ�.):0", "[( )�ȿ��� ���� 2���� ��ȣ�� 1�� �ִ�.]:24" });
        talkData.Add(34 + 1300, new string[] { "(���ڴ�.):0", "(���ڿ� ������ �پ��ִ�.):0", "[+���]:24" });
        talkData.Add(35 + 1100, new string[] { "(���ڴ�.):0", "(���ڿ� ������ �پ��ִ�.):0", "[(����]:24" });
        talkData.Add(36 + 44000, new string[] { "(��ȣ Ű�� �ִ� ���̴�.):0", "(�������� ���� �ܼ����� �����ؼ� �����.):0" });


        // *** �������� 2 ***

        //
        //40

        talkData.Add(42 + 4600, new string[] { "(�����ġ�� �ִ� ���̴�.):0", "(6���� ���ڸ� �Է��ؾ� �� �� �ִ�.):0","...:0","����?:0", "(���� �������� �ִ� �� ����.):0" });
        talkData.Add(43 + 7500, new string[] { "��?:7", "��?:0", "�Ѻ���...! �Ѻ��� ����?!:7", "���� ���Ա���...!:9", "����... ��� �� �̸���...?:0", "�� ���� ���ݾ�! �� �� �� �� ���ε�!:9" });

        //����� ����Ʈ������ ��.
        //42
        talkData.Add(40 + 2900, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(���� ���� �Ϻκ��� �Ӱ� ���δ�.):0", "���� ������ ������ �޶��� �� ������...:0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ N ]:24" });


        //43
        talkData.Add(41 + 3100, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(���� ���� �Ϻκ��� Ǫ���� ���δ�.):0", "���� ������ ������ �޶��� �� ������...:0", "(�񼮿� � ���ڰ� �����ִ�.):0", "[ S ]:24" });

        //�絿��(����� ����)
        //**����Ʈ ������**
        //44
        talkData.Add(44 + 6000, new string[] { "(�絿�̴�.):0", "(�̰ɷ� �м� ���� ���� �� ���� �� ����.):0", "(��������.):0" });


        //45
        //�м� ��� �����
        talkData.Add(45 + 55000, new string[] { "(�м���.):0", "(��� ������ �絿�̷� ���� ���� �� ���� �� ����.):0", "������...:24", "(�絿�̿� ��� ���� ���� á��.):0", "(�� ���� �񼮿� �ξ��.):0" });

        //46
        talkData.Add(46 + 2900, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�絿�̿� �޾ƿ� ���� �ξ�Ҵ�.):0" });

        //47
        talkData.Add(47 + 3100, new string[] { "(Ÿ��ĸ���� ���̴�.):0", "(�絿�̿� �޾ƿ� ���� �ξ�Ҵ�.):0" });

        //50
        talkData.Add(50 + 57000, new string[] { "(�߱����̴�.):0", "(������ �������� �Բ� �� ���� ������ ���.):0", "(�ڼ��� ���� �Ա� �� �ʷϻ� ǥ���ǿ� ���𰡰� ���� �ִ�.):0", "[������ ���� ������ �ƴմϴ�. ������ �� �湮�� �ּ���.]:24", "[ThOs Os not the regular season. Please vOsOt agaOn next tOme.]:24" });

        //51
        talkData.Add(51 + 58000, new string[] { "(������.):0", "(���� â�� ���𰡰� �پ� �ִ�.):0", "[ù ���ڴ� �Ķ���, �� ��° ���ڴ� �������̴�.]:24" });

        //52
        talkData.Add(52 + 59000, new string[] { "(��������.):0", "(�ȿ� ���𰡰� �ִ�.):0", "(����� ������.):0", "������� ���ϱ� ���� ������ �ô� ��Ʈ�� ��������.:0","�ϴ� ���� ������� Ȯ���ϰ� �� �� ������.:0","(����� ������ �̷��� ���� �ִ�.):0", "[��, �����.(I love O.)]:24", "(���� ���� ���� ������ ���.):2" });

        //����Ʈ ��Ʈ
        //**����Ʈ �� ����**
        //53
        talkData.Add(53 + 4100, new string[] { "(��Ʈ��.):0", "(�ٸ� ��Ʈ�� ���� ������ ���δ�.):0", "(���� �ܴ��� �ɷ� ������ �ָ� ���� �� ����.):0" });


        //��(����� ��)
        //**����Ʈ �� ����**
        //54
        talkData.Add(54 + 6100, new string[] { "(���̴�.):0", "(�� ������ ��Ʈ�� �����ϱ⿡ �˸��� �� ����.):0", "(��������.):0" });


        //����Ʈ ��Ʈ
        //**����Ʈ �� ����**
        //55
        talkData.Add(55 + 4100, new string[] { "(��Ʈ��.):0", "(��� ������ ���� ���⿡ �θ� �� �� ����.):0", "(�׷��� ����... ���� �ִ� ���� ������ �־��� �� ������...?):18" });

        //�� �ؿ� ����
        //**����Ʈ ������ �ƴ�. �׳� �� ����.**
        //56
        talkData.Add(56 + 61000, new string[] { "(������ ������.):0", "(������ � �۾��� �����ִ�.):0", "[�� ��°�� ���� ��° ���ڴ� ����.]:24" });

        //ķ��ī1
        //**����Ʈ ������
        //60
        talkData.Add(60 + 62000, new string[] { "(ķ��ī��.):0", "(���� ����� ������ �پ��ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[?? = ķ���� ���� �� �غ����� ķ��ī�� ó���ΰ�? �� ��������?]:24", "[?? = �������� ��, ����, ���İŸ��� ì�ܾ���. ����, ���� �� �԰� ���� �� �ִ�?]:24", "[??? = �� ����!]:24", "[???? = �� *�ֽ�*! ������ *�ֽ�*! ��, *����*��!]:24" });


        //å�� ��(2)-���� ����
        //**����Ʈ ������**
        //61
        talkData.Add(61 + 63000, new string[] { "(å���̴�.):0", "(å�� ���� ����� ������ �ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[�� ��° ���ڴ� *���̿� �ִ� �� ���� �Ÿ��� �������� �� ���� �� �ϳ���.]:24" });


        //ĳ���1
        //**����Ʈ ������**
        //62
        talkData.Add(62 + 64000, new string[] { "(ī����̴�.):0", "(���� ����� ������ �پ��ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[4��° ���ڴ� ������ �ƴϴ�.]:24" });


        //å�� ��(3)(��Ÿ�� ��)-�Ķ� ����
        //**����Ʈ ������**
        //63
        talkData.Add(63 + 65000, new string[] { "(å���̴�.):0", "(å�� ���� �Ķ��� ������ �ִ�.):0", "(������ � �۾��� �����ִ�.):0", "[���� ���� �� ù ��° ���ڸ� �빮�ڴ�.]:24", "(�� �ֺ��� ��� ���� �� �ѷ��� �� ������...):0", "(���� ���� ���� ��Ʈ�� ���� ���ڶ� �� ����.):0", "(Ȥ�� �°� ������ ��������?):0" });

        //����Ʈ ��ȭ2(�¾� ��Ʈ ���� ��)-�� ���� �¾� ��Ʈ ��Ÿ��
        //64
        talkData.Add(64 + 7500, new string[] { "����, �� �̸���...:0", "�����̾�. ������.:9", "�� ��� �� �־�?:9", "Ȥ�� ���� ������... �� �� �־�? ����, ���, �ʷ�, �Ķ�, ����� �߿� �ƹ��ų�.:0", "����? �׸����� �Ʊ� ���� �𸣴� ���� �ϳ��� �ݱ� �ߴµ�...:11", "(�׳డ �Ķ����� �����, �������� ���� ������ �ǳ޴�.):0", "(�������� �۾��� ���� �ִ�.):0", "[��,���� �¾��̰� ���̸� ���̾�.]:24", "[You are my 'OOO', my moon and all my star.]:24", "��, �׷��� ���� �ؿ� �ִ� å�󿡼� å ���� �� �� �� ����.:11", "å...?:18", "...�˷��༭ ����.:3", "(å���� �ִ� ������ �����߰ڴ�.):0" });

        //å�� ��(2)(�¾� å�� ���� å��)
        //**����Ʈ å��**
        //65
        talkData.Add(65 + 66000, new string[] { "(å���̴�.):0", "(å�� ���� �¾� �׸��� �׷��� ��Ʈ�� �ִ�.):0", "(��Ʈ�� ��ġ�� � �۾��� ���� �ִ� ���� ���δ�.):0", "[�츮�� ����� ���� ���� ��� �װ��� ���� �ִ�.]:24", "���� ��� ���̶��...? �װ� �����?:0", "...�´� �˰� ��������?:0" });

        //����Ʈ ��ȭ3(�¾� ��Ʈ �� ��)
        //66
        talkData.Add(66 + 7500, new string[] { "Ȥ�� �� �� ������� �ɱ�?:0", "�翬����! ����?:9", "(�¾� �׸��� �׷��� ��Ʈ�� �����ָ� ������.):0", "����, [�츮�� ����� ���� ���� ��� �װ�]�̶�� ���� ���ε�... Ȥ�� ��� �� �˾�?:0", "����! �� �����ϰ� �׻� �ű� �����ݾ�!:9", "...����?:0", "..��!:1", "(���ڱ� �Ӹ��� �����Ÿ���.):1", "...������?:8", "...��. �ƹ��͵� �ƴϾ�. �׷��� �űⰡ ���?:3", "�߾� �м����. ���鼭 ����?:9", "�ƾ�, �ű�... ����.:3", "(�м����... ���ٱⰡ ���� �Ժη� �� ���� �����µ�...):18", "(�м��� �� ����� ������?):18" });

        //����ġ(����� ����)
        //**����Ʈ ������**
        //70
        talkData.Add(70 + 5900, new string[] { "(�м��� ����ġ��.):0", "(����ũ�� Ƣ� �Ժη� ���� �� ����.):0", "(�����ϰ� ����ġ�� ���� �� �ִ� ����� ������?):0" });

        //�����尩
        //**����Ʈ ������**
        //71
        talkData.Add(71 + 4500, new string[] { "(���� �尩�̴�.):0", "(�̰ɷ� �����ϰ� ����ġ�� ���� �� ���� �� ����.):0" });
        portraitData.Add(4500 + 0, portraitArr[0]);//����

        //72
        talkData.Add(72 + 5900, new string[] { "(�м��� ����ġ��.):0", "(��� �ֿ� ���� �尩�� ���� ����ġ�� �������Ҵ�.):0", "ö��.:24", "(����ġ�� ���ȴ�.):0" });

        //���� ����**����Ʈ ������**
        //73
        talkData.Add(73 + 6300, new string[] { "(���� �����̴�.):0", "(���� ���� �ʷϻ� ������ �ִ�.):0", "(������ �۾��� ���� �ִ�.):0", "[�ټ� ��° ���ڴ� '�� �ڽ�'�̴�.]:24", "���� ������ �̰ɷ� �� �� °��?:0", "(��������.):0" });
        portraitData.Add(6300 + 0, portraitArr[0]);//����
        portraitData.Add(6300 + 1, portraitArr[1]);//����
        portraitData.Add(6300 + 2, portraitArr[2]);//����
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

        //����Ʈ
        //74
        talkData.Add(74 + 4600, new string[] { "(�����ġ�� �ִ� ���̴�.):0", "(�������� ���� �ܼ����� �����ؼ� �����.):0" });


        //**��������3**

        //80
        
        talkData.Add(80+9500, new string[] { "...���� ��ҷ� ���� ���̰���?:17", "(���� �̰��� ����� �ʹ�...):16", "(���� ����ִ�.):17","(���踦 ã���� �� �� ����.):17" });

        //81
        
        talkData.Add(81+4200, new string[] { "��... �װ� ��� �������...?:17", "�ƴ�, �װ� �߿��� �� �ƴ���. ��, Ȥ�� ���� �� ���� ������ �־�?:17",  "...�ۼ�. �ٵ� �� �Ȼ��� �� ����...:20", "...����. ������ �ֳİ�!:15", "(���� �������� ���� ��ĥ������.):16",  "...������ ����. ������ �Ƹ� �� ���� ��򰡿� ���� �ž�.:4", "...�˾Ҿ�.:17", "(...����.):16" });

        //82
        
        talkData.Add(82 + 46000, new string[] { "(�� ���̰� ������ �ִ�.):17", "(�����ǥ��.):17", "('���ʿ��� ���������� A ~ F, �տ��� �ڷ� 1 ~ 10'�̶� �ȳ� ������ �Բ� �¼���ȣ�� ���� �ִ�.):17", "(ǥ�� ���� �¼���ȣ�� F7�̴�.):17", "(�� �ڸ��� ���� ���谡 �ִ� �ǰ�...?):17", "(���� ������.):17" });

        //83
        
        talkData.Add(83 + 6600, new string[] { "( �����ǥ�� ���� �¼��� �����.):17", "(...��. �Ǽ��� ǥ�� ����߸��� ���Ҵ�.):14", "(ǥ�� �ݱ� ���� �㸱 ������.):0" });


        //84
        talkData.Add(84 + 49000, new string[] { "��, ����...?!:25", "(��ݱ��� Ǫ���� ���ڰ� �Ӱ� ���ߴ�.):25", "(���ڸ� �������� ���𰡿� ���� ��ó�� �����ϴ�.):1", "(���ڸ� ���� ���� �ٶ󺸴� �ǰ��� ������ ���� ��ü�� ����ߴ�.):1", "...���.:16","(...�걸������ ���� �� ����.):16", "� �̰��� ������ ��...:16", "(�ƴ�, �����߸� �Ѵ�. ���� ���� �Ἥ��.):15" });

        //85
        
        talkData.Add(85 + 4300, new string[] { "��... ��... �����̶�� ����? Ȥ�� ���� �־�?:17", "�ƴ�, �־�߸� ��. ������ ���� �̰��� ������, �翬�� �ְ���?:13", "...�̾���. �̰��� ���� �� � ���� �� �� ����.:10" ,"����� ������ �� ȥ�ڼ� �س��� ��.:10", "...��°��?:17", "�װ�... �� �ڽ��� �� �� �˰� ���� �ž�.:10" });
        

        //86  
        talkData.Add(86 + 51000, new string[] { "(�����̴�.):17", "(���濡 ���� �˰� ������ �ڱ��� �ִ�.):17", "(���� �ȿ��� �˰� Ÿ���� �ʰ� �����Ÿ��� ����ִ�.):17", "...�̰� ����?:12", "Ÿ���� �ʵ� ���̷� ������ ���� ���� �ִ�.:12"," ����Ʈ���̴�.:0", "����Ʈ�տ� �̷��� ���� �ִ�.:0", "[ ...������! ���ǰ ���� �� �� ��͵� �Ǵϱ� ��̰� ��� ��! �� �� �����ϰ�! ]:24", "...��!:1", "(���ڱ� �Ӹ��� �����Ÿ���.):16" });
        
        //87  
        talkData.Add(87 + 52000, new string[] { "(���𰡰� ��� ������ ���� ���δ�.):17", "(����Ʈ���̴�.):17", "(ȭ���� �Ѻ��� ���������� ���ڸ� ���� ������ �ִ�.):0", "(�����ڴ� �����Ѻ����̴�.):0", "...���ݾ�?:14", "(...ȥ��������. ���� �� ����� �˰� �־��ٰ�?):14", "(���� ������ �о�Ҵ�.):14", "[ ��. ����Ⱑ ���� �̻���. â���� ���µ� ���� ���Ⱑ ����... ]:24", "(�ٸ� ������ ������ �ʴ´�.):14", "(����ȭ������ ���ư� �޴��� ������ �̸��� Ȯ���غô�.):0", "...�輱��?:14", "(�� ��° ������ �ִ� ���� ��й�ȣ�� ���� �̸��̴�.):14", "...��!:1", "(���� �������� ���� ����ϰ� ���ö���.):19" });
        
        //����Ʈ 90 
        talkData.Add(90 + 7000, new string[] { "(����������.):17", "(������ ������ ������ �ִ�.):17", "(...���� ���� �־��� �ɱ�?):17", "(...���𰡰� ��ﳯ �� ����.):16" });
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
        talkData.Add(91 + 56000, new string[] { "(������.):17", "(���̾��� ������ ���ļ��� ����ô�.):17", "ġ����...:24", "� �Ҹ��� �鸮�� �����Ѵ�.:0", "[ ���� ���� 11�ð� ���ֵ��� ���ϴ� ����Ⱑ ���߷� ���� �߶��ϴ� ��� �߻��߽��ϴ�. ]:24", "[ �ش� ����⿡�� ���п����� ���� ������ ����б����л����� ž���ϰ� �־��� ������ �˷���... ]:24",  "(�� ������ �鸮�� �ʴ´�.):2", "(...���� �̰����� ã�� �� ���� �� ����.):17", "(���� ��... �ĵ带 �� ���ڿ��� ���� �ȴ�.):17","(�װ� ������ ����� �˰� �ִٴ� �׷� Ȯ���� ���.):12" });     
        //92
        talkData.Add(92 + 4200, new string[] { "�� ã�Ҿ�?:4","��... ���⿡ ���� �˰� �ִ� ����?:17","���⼭ ���� ���� �Ͼ����. �׸��� ���� ã�� ���ǵ��� ������ ��������.:17", "...�¾�. �ʵ� ó������ �˰� �־��ݾ�.:4","...����?:14", "...��!:1", "(�Ӹ��� �����Ÿ���...!):16", "���ÿ� ���𰡰� �������� �Ҹ��� ��ȴ�.:16" });
      
        //93
        talkData.Add(93 + 7200, new string[] { "(�̰�... ���Ű� ���̴�.):14","(...�� �ָӴϿ� ����־���.):14","(�̰� ��...?):18","(�ĵ带 �� ���ڰ� ��Ȳ�� �� ������ �ٶ󺸰� �ִ�...):14", "(�ϴ� �׿� ��ȭ�� ����غ���.):12" });
        //talkData.Add(10200, new string[] { "(�̰�... ���Ű� ���̴�.):14", "(...�� �ָӴϿ� ����־���.):14", "(�̰� ��...?):18" });
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
        talkData.Add(94 + 4200, new string[] { "...������?:22","(�ĵ带 �� ������ ���������� ��Ҹ��� ��ȴ�.):14","(���� ���ڿ��Լ� � ���� ������ �� ����.):14","(����Ʈ���� ���� �� �Ӹ��ӿ��� ���ö��� �̹����� �ι��� ����� ������.):19","...���� �˾Ƴ� ���� ����̳�.:21","(���ڰ� ���� �̼Ҹ� ������ ���𰡸� �ǳ޴�.):14"});

        //95
        talkData.Add(95 + 5300, new string[] { "(����� �����.):0","���� ������ �� �ִ� �� ���������.:21","� ��.:21","��� ������ ���ư��� �ž�.:21","���̶�� �� �� �־�.:23" });
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
        talkData.Add(96 + 9900, new string[] { "(���� �����̴�.):0", "�Ʊ� ���� �� �����µ�...:14","(...��������.):0" });
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
        talkData.Add(97 + 9500, new string[] {"(����� ���踦 ���� ���ۿ� �ȾҴ�.):0", "ö��!:24", "(���ȴ�.):0" });

        //** ��������4 **

        //100
        talkData.Add(100 + 10000, new string[] { "���� ��ҷ� ���� ���̰���?:0", "�� �ʸӴ� �����̾�.:4", "��?:0", "(�ĵ带 �� ������ ��Ҹ��� �鸰��.):0", "(�ڵ���� �ǰ�?):0" });
        portraitData.Add(10000 + 0, portraitArr[0]);
        portraitData.Add(10000 + 1, portraitArr[1]);
        portraitData.Add(10000 + 2, portraitArr[2]);
        portraitData.Add(10000 + 3, portraitArr[3]);
        portraitData.Add(10000 + 4, portraitArr[4]);

        //101
        talkData.Add(101 + 11000, new string[] { "���Ⱑ ����� �˰ھ�?:4", "ù ��° �����ϰ� ���� �Ȱ��� ����...:0", "������ ���� ���� �ٸ��� ������...:0", ".....:4","(ǥ���� �����ϴ� ���ϴ� ����� �ƴ� ���ϴ�.):0", "(����� �� ���캸��.):0" });

        //102
        talkData.Add(102 + 12000, new string[] { "(�޷��̴�.):0", "(��ݱ����� �ص� �����µ�...?):18", "(10�� 2�Ͽ� ���׶�̰� ó���ִ�.):0", "(�̻� �� ���̶� ���� �ִ�.):0"});

        //103
        talkData.Add(103 + 13000, new string[] { "(�� ���ڰ� �ִ�.):0", "(�굵 ��ݱ����� �ص� �����µ�...?):18", "(���� �� ������ Ȯ���� �ô�.):0", "(�߱��� �տ��� ���� �����̴�.):14", "(2��° �������� �� �߱���� �Ȱ��� �����.):14","(���� �ӿ� �� ����� �ִ�.):14", "(�� ����� ����.):26", "(�� ���� �ִ� �����...):27", "��...!:1", "(�帴�ߴ� �Ƿ翧�� ���� ����������.):17" });

        //104
        talkData.Add(104 + 14000, new string[] { "(���� ���� ���ڰ� �ִ�.):0", "(���� �� ������ ����� ī����̴�.):18", "(���ó� 2��° �������� �� ���̴�.):0", "(���� �ӿ� ����,):28", "(����� ���ڿ��� �� ���ڰ� ���� �ִ�.):29", "(...������ ����� ����.):14", "(�� �����...):32" });

        //105
        talkData.Add(105 + 15000, new string[] { "(���ڰ� �ִ�.):0", "(���� �� ������ Ȯ���� �ô�.):0", "(���̰������� ���� �����̴�.):14", "(�޹�濣 2��° �������� �� �������� �ִ�.):14", "(���� �ӿ� �� ����� �ִ�.):14", "(��������):36", "(��,):30", "(�׸��� �տ��� �� ���ڿ� �ִ� ���ڴ�.):31", "(���� �׵θ��� � �۾��� ���� �ִ�.):14", "[ �����̿� �� ���� �����̿� �Բ� ]:32", "(...�׷�. ���� �� �� �ذ� �־���...):32", "������...:33" });

        //106
        talkData.Add(106 + 16000, new string[] { "(��Ź�� ���� '���� ����б�'�� ������ �ִ�.):0", "(�и� ���� �������� �ص� �ȿ� �־��µ�...):18", "(������ Ȯ���غ��� ������ ������ �̸�ǥ�� ���δ�.):14", "(�̸�ǥ�� ���� �̸��� '�輱��'�̴�.):14", "(�׷�... ���� �� �����̾�����...):32" });

        //107
        talkData.Add(107 + 17000, new string[] { "(ȭ���� ���� ��Ʈ���̴�.):0", "(�Ѻ���.):0" });

        //����! ������� 110����
        //108
        talkData.Add(108 + 48000, new string[] { "(���ͳ� ���� â�� ���δ�.):0", "[9�� 15�� ���� 11���� ���ֵ��� ���ϴ� ����Ⱑ ���߷� ���� �ٴٿ� �߶��ϴ� ��� �߻��ߴ�.]:24", "[�ش� �����⿡ ž���ߴ� 170�� ������ ����Ͽ�����,]:24", "[���п����� ���� '���� ����б�' �л����� ž���ϰ� �־��� ������ �˷�����.]:24", "[�װ��� �����ڴ� ���� ��Ȯ�� ��� ������ �����ϰ� �ִٰ� ���ߴ�.]:24", ".....:32" });

        //*** 110���� ����Ʈ ***
        //110
        talkData.Add(110 + 19000, new string[] { "(����Ʈ���̴�.):0", "(���ȭ�鿡 ������ ��ȭ�� 20�� �̻� ���� ���� ���� ���.):0", "(�߽��� �̸��� '������'�̴�.):0", "(�̿ܿ��� �׳డ ���� ���ڰ� ���� �� ���� ���� ä �׿��ִ�.):0", "(���ȭ�鿡�� �� ������ ������ ������       [ ���� �ƹ��͵� ���� ���� ��ٷ���. ]��.):17" });

        //111
        talkData.Add(111 + 20000, new string[] { "(å�� ���� Ŀ��Į�� �ִ�.):14", "(�̰� �� ���⿡...):14", "(Į���� ���� �ǰ� �����ϰ� �����ִ�...):17" });

        //112
        talkData.Add(112 + 11000, new string[] { "...���� ���Ⱑ ����� �� �� ����?:21", "(���� ������ ���� ��������.):32", "����... ���ϰ� ������ ��� ���̾�.:32", "��ư� ���� �����̾�����, �츰 ���� ���� �� �ִٴ� �͸����ε� �ູ�߾���.:32", "(�װ� �ƹ��� ���� ���� ���� ������ ��� �ִ�...):4", "(��� ��, �װ� �ָӴϿ��� ī�� �� ���� �������� �� ���տ� ���ƴ�.):14", "��, ������.:4", "(...���ڱ�?):14", "(������ �𸣰ڴ�.):14", "��� ������ �ð��� �� �� �־�?:18", "�׷�.:4" });

        //113
        talkData.Add(113 + 11000, new string[] { "�� �������� �����غþ�?:4", "...��.:0"});

        //114
        talkData.Add(114 + 11000, new string[] { "...ó�� ���� �� ������ ��������, ���� �� �� ����.:34", "�� ��ü��...:32", "���.:4", "������ ���� �߿��� �� �Ƴ�.:4", "���� ������ �ʾҾ�.:4", "�װ� �̰��� ������� � ��ǥ�� �־��ݾ�.:4", "�װ� ���ϰ� ����... �� ������ ����� �ٰ�.:21", "...�˾Ҿ�.:32" });

        //115
        talkData.Add(115 + 22000, new string[] { "(ȭ��Ƿ� ���� ���̴�.):0", "(���ڱ��� �̰����� ���ϰ� �ִ�...):17", "(������ ���� ���۵� �����Ӵ��� ������ �ʴ´�.):17", "...�ٸ� ����� ������ �ʾ�����?:0" });



        //116
        talkData.Add(116 + 73000, new string[] { "(...�����.):0", "(����.):0" });

        //**����! �������  120����
        //120
        talkData.Add(120 + 23000, new string[] { "(���� ���� ���� ���� ��������� �ִ�.):14", "(�������� �˾ƺ� �� ����.):35", "('���� ����б�'�� ������ �԰� �ִٴ� �͸� �ܿ� �ľ��� �� �ִ�.):35", "(�ٴڿ� �� �� ��ﵵ ���� �� ����, �� ���� �ڱ��� ��ü��...):32" });

        //121
        talkData.Add(121 + 24000, new string[] { "(�ǰ� ���� Ŀ��Į�̴�.):17", "�ٸ� ���뿡�� �� �� ��°�� ���⿡ �ִ� ����...?:17", "(���� �ұ��� ������ ���...):17" });
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

        //*** 120���� ***

        //122
        talkData.Add(122 + 25000, new string[] { "(������ ���� ���� ���ö���.):0", "(������, ������ �� �� ���� ������ ��������.):17", "(���� �����ϰ� � ����� ���ö���.):1", "(���� Ŀ��Į�� ��� ������ ���ϴ� �����...):1", "(...�׷�����. ���� �̰�����...):32" });

        //123
        talkData.Add(123 + 25000, new string[] { "(������ ���� ���� ���𰡰� ���� �� ���ٴ� ������ ���.):0", "(���� ���� ���������� ������.):17" });

        //124
        talkData.Add(124 + 26000, new string[] { "(���� �������� �ڸ��� ���� ������ �ִ�.):14", "Ȥ�ó� ������ ��¥�� ���⿡ ���� ���̾�...:14", "(�̰ɷ� �� ��° �����̴�.):0", "(���� �̰��� ������ ����.):0", "(�ٽ� �������� ���ư���.):0" });

        //125
        talkData.Add(125 + 27000, new string[] { "(���� �����̴�.):0", "(...�̰ɷ� �ټ� ��°��.):0", "(���� ���� �� ��Ҵ�.):0", "(���� �������� ����.):0" });
        portraitData.Add(27000 + 0, portraitArr[0]);


        //**������� Final Stage ����Ʈ**//
        //(130����)

        //130
        talkData.Add(130 + 47000, new string[] { "���Ⱑ... ����...:0" ,"���� ���� ���� ������ �÷������� �Ǵ� ����...?:18", "(�������� ���� ���� ������ �ϳ��� ���ƺ���.):0" });
        

        //131
        talkData.Add(131 + 47000, new string[] { "(ù ��° ���� ������ �÷ȴ�.):0", "(�� ��° ���� ������ �÷�����.):0" });

        //132
        talkData.Add(132 + 47000, new string[] { "(�� ��° ���� ������ �÷ȴ�.):0", "(���ܿ� �÷����� �� ���� ���� ������ ������ ���� ���δ�.):14", "...������ ���� �ƴ���.:0", "(���� ���� ���� �� ���ڿ� ���� ��⸦ ������ �Ѵ�.):0" });

        //133
        talkData.Add(133 + 47000, new string[] { "(�� ��° ���� ������ �÷ȴ�.):0" });

        //134
        talkData.Add(134 + 47000, new string[] { "(�� ��° ���� ������ �÷ȴ�.):0" });

        //135
        talkData.Add(135 + 47000, new string[] { "(������... ���� ������ ���� ���� �÷ȴ�.):0" });

        //136
        talkData.Add(136 + 42000, new string[] { "������� ���µ� ���� ������� �ٵ�... ��� ���Ҿ�.:23", "���п� �� ���� �ٽ� ���� �� �� �����ž�.:23", ".....:32", "...������ ���ϰ� ������ �ִٰ� �߾���?:37", "�װ� ����?:23", ".....:32", "...�װ� ������ �� �� ����.:32", "...�׷�?:23", "���� ������?:37" });

        //137
        talkData.Add(137 + 42000, new string[] { "��°�� �� ���ø��� ��������.:32", "�ϳ��ۿ� ���� ������ �͵�...:32", "�ۼ�... :37" });
        

        //138
        talkData.Add(138 + 43000, new string[] { "���μ� ���� ������ �� �� ������ �� �𸣰�����...:44" ,"��·�� �̷��� �ٽ� ������ �Ƴ�, ��.  :47" });

        //**������� 140����**//

        //140
        talkData.Add(140 + 43000, new string[] { "�׵��� �� ���¾�?:47", "��... ������ ���� ���ݾ�!:32", "���� �;��ٰ�, ������...:33", "(���� �����̸� �ִ� ���� �ȾҴ�.):32", "(�ճ��� �������� ������ �Ϳ� �鸮�� ��Ҹ��� �װ� ��¥ �������� �˷��ְ� �־�����,):32", "(�� �̹� �˰� �־���.):32","(...�̰��� ������ �ƴ϶� ��.):33", "(������...):32", "�ʿ� ������� ���� ������...:33", "(�׶�, � �Ҹ��� ����Դ�.):24", "����....:24", "����...?:14", "���� ��Ÿ���� �Ҹ���.:44", "...���̶��? :14" });

        //141
        talkData.Add(141 + 43000, new string[] { "��. ���� ����� ���� ��.:47", "...���� �����ϰ� �־��ݾ�?:47", ".....:32", "�׷� ���� �� ������ ���ٸ�...:32", "�ƽ����� �ۺ��� ����.:43", "(������ ���� �ôµ�...):32", "(���� ������� �Ѵٰ�?):32", "(�����̿� ���ݸ��̶�,):32", "(�ƴ�, ����ó�� ��� �翡 �ְ� �ʹ�.):32", "(�װ� ���� ���� �̷� ���� �� �����ϱ�.):32", "(...�ϴ� �����̿� ��� ��ȭ�غ���.):32" });

        //142
        talkData.Add(142 + 43000, new string[] { "��, ���� �� ������ �Ѵٴ� ���� ����.:44", "���⼭ ������, �� �������� ������ ���� �����̾�.:44", "��... �����̶��.:32", "...�����߾�.:0" });


        //**������� ������ ���**//

        //143
        talkData.Add(143 + 43000, new string[] { "�ʿ� ������� ������... �̰����� ���鼭 �װ� ���� ������ ���ö���.:39","���� ���� ���ư����.:40", "�׻� �����ӿ� ��... ����� �ִٰ�.:40","������ �־� �ʴ� �� ���� ������ ����̾���.:39", ".....:43", "�� �ҽ��� ���� ���� �ڸ����� �� ��¦�� ������ �� ������.:32", "���� �������� ���� ����̾���.:32", "�ʿ� ���������� �� ����� ���� �� �־����� ���ڴٰ�...:33", "������ ����� �Ѿư��� ������ ������ �ٶ���.:33", "�׷��� ��� ����, �� ������ ��ġ �ϴÿ��� ���� �� ��������.:39", "...�ƴ�, �װ� �غ��� �ŷ���.:40", ".....���� �Ծ�.:46", "��?:14", "�� ���̾�.:45", "�ʹ� ���� �Դٰ�!:45", "���� ���� ���� �� ���� �𸣰� �־��� �� �˾�?!:45", ".....:14", "���Ѻ��� �־��ٰ�.:42", "���� ��.:42", ".....:14", "���� ���� ��ŭ ���� ���;�.:42", "������ �����ٰ� �������ְ� �;��µ�...:42", "���� �� �� ����, �� ��Ҹ��� ���� ���� ��� �󸶳� ���ο����� �˾�?:42", "�׷�...:39", "�� ������ �� �翡 �־� �ᱸ��.:39", "�� �װ͵� �𸣰�...:38", "�˾����� �ƾ�.:41","...���� ����� �ð��̾�.:43", "�� ������ �� ������ �ž�.:43", "� ��.:43"});

        //144
        talkData.Add(144 + 53000, new string[] { ".....:32", "�׷� ���� ���� ��.:43", "�׸���... �� �� ������ ���� ���� ���� �� �д�!:45", "...�׷�.:39", "�ȳ�, ������.:40", "...�� ��, ��.:43" });

        //145
        //talkData.Add(145 + 43000, new string[] { "���μ� ���� ������ �� �� ������ �� �𸣰�����...:0", "��·�� �̷��� �ٽ� ������ �Ƴ�, ��.  :0" });

        //146
        //talkData.Add(146 + 43000, new string[] { "���μ� ���� ������ �� �� ������ �� �𸣰�����...:0", "��·�� �̷��� �ٽ� ������ �Ƴ�, ��.  :0" });

        //147
        //talkData.Add(147 + 43000, new string[] { "���μ� ���� ������ �� �� ������ �� �𸣰�����...:0", "��·�� �̷��� �ٽ� ������ �Ƴ�, ��.  :0" });

        //148
        //talkData.Add(148 + 43000, new string[] { "���μ� ���� ������ �� �� ������ �� �𸣰�����...:0", "��·�� �̷��� �ٽ� ������ �Ƴ�, ��.  :0" });

    }



    public string GetTalk(int id, int talkIndex)//������ ��ȭ ������ ��ȯ�ϴ� �Լ� ������
    {
        if(! talkData.ContainsKey(id))//ã������ �����Ͱ� ������ ����Ʈ ��ȭ���� ���� �� ��Ž��
        {
            //<���� �־��� ��>

            /*if (!talkData.ContainsKey(id - id % 10))
              return GetTalk(id - id % 100, talkIndex);//ù��° ��ȭ�� �����´�
            else
              return GetTalk(id - id % 10, talkIndex);//ù ��° ����Ʈ ��ȭ�� �����´�*/
            //��ȯ ���� �ִ� ����Լ��� return���� �� �����

            if (!talkData.ContainsKey(id - id % 100))
                return GetTalk(id - id % 1000, talkIndex);//ù��° ��ȭ�� �����´�
            else if (!talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 100, talkIndex);//ù ��° ����Ʈ ��ȭ�� �����´�
            else if (talkData.ContainsKey(id - id % 10))
                return GetTalk(id - id % 10, talkIndex);




        }

        //��ũ �ε����� �� ������ �� �̻� �����ִ� ���� ������ ��
        if (talkIndex == talkData[id].Length)
            return null;
        else//�� �ڿ� �ִ� ��ȭ ���� �ϱ�
            return talkData[id][talkIndex];

        



    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {//������ �ʻ�ȭ ��������Ʈ�� ��ȯ�� �Լ� ����

        return portraitData[id + portraitIndex];
    }

}
