using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{

    //public VectorValue startingPosition;//�� �̵������� ����


    public float Speed;
    public GameManager manager;//�Ŵ��� �Լ� �ҷ����� �ϴ°�
    Rigidbody2D rigid;
    Animator anim;
    float h;
    float v;
    bool isHorizonMove; //�����̵��̳�
    Vector3 dirVec;//���� �ٶ󺸰� �ִ� ���� ���� ���� ����
    GameObject scanObject;//��ĵ�� �Ǿ���

    //����� Ű ��
    int up_Value;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    int down_Value;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    int left_Value;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    int right_Value;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool up_Down;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool down_Down;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool left_Down;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool right_Down;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool up_Up;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool down_Up;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool left_Up;//Ű���� ���� ����Ʈ������ �������� �����ϰ�
    bool right_Up;//Ű���� ���� ����Ʈ������ �������� �����ϰ�

    //static public PlayerAction instance;//�� �̵������� ����


    //public string currentMapName;//�� �̵������� ����
    //private BoxCollider2D boxCollider;//�� �̵������� ����


    [SerializeField]//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����

    //SerializeFied�� �տ� �ۺ� ���� ���� ��Ÿ���� ���ִ� �� ����

    //��������1 ��ݱ��
    GameObject codePanel, closedStage1_Door, openedStage1_Door, codePanel2, closedStage2_Door, openedStage2_Door;//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
    public static bool isStage1_DoorOpened, isStage2_DoorOpened = false;//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����

    //public GameObject ControlSet;//��Ʈ�� ��Ʈ������ ���� �� �� �Ǹ� �����

    //��������2 ��ݱ��
    //GameObject codePanel2, closedStage2_Door, openedStage2_Door;//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
    //public static bool isStage2_DoorOpened = false;//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����

    //public GameObject ControlSet2;//��Ʈ�� ��Ʈ������ ���� �� �� �Ǹ� �����


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();//�� �ȵǸ� �ٽû츮��
        anim = GetComponent<Animator>();//�� �ȵǸ� �ٽ� �츮��


        /*if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject); // ���� ������Ʈ �ı�����

            rigid = GetComponent<Rigidbody2D>();//�� �ȵǸ� �ٽû츮��
            anim = GetComponent<Animator>();//�� �ȵǸ� �ٽ� �츮��
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);

        }*/
    }
    
    void Update()
    {
        //����ϰ� PC���� ������
        h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal")+ right_Value + left_Value; //����
        v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical")+ up_Value + down_Value; //����


        //������ ��

        //���º���(isAction)�� ����Ͽ� �÷��̾� �̵� ����(��ȭ�� �� �����̸� �� �Ǵϱ�)
        //�׼��� ������ �����̸� 0 / false�̴�.(�������� ��!)

        //�̰� PC�� ���
        //h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal"); //����
        //v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical"); //����

        //�̰� Mobile�� ���
        //h = manager.isAction ? 0 : right_Value+left_Value; //����
        //v = manager.isAction ? 0 : up_Value+down_Value; //����


        //Mobile �� PC����
        bool hDown = manager.isAction ? false : Input.GetButtonDown("Horizontal")|| right_Down || left_Down;
        bool vDown = manager.isAction ? false : Input.GetButtonDown("Vertical")|| up_Down || down_Down;
        bool hUp = manager.isAction ? false : Input.GetButtonUp("Horizontal")|| right_Up || left_Up;
        bool vUp = manager.isAction ? false : Input.GetButtonUp("Vertical") || up_Up || down_Up;

        //��������1 ��ݱ��
        if (isStage1_DoorOpened)//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
        {
            codePanel.SetActive(false);//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
            closedStage1_Door.SetActive(true);//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
            openedStage1_Door.SetActive(false);//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����

        }

        //��������2 ��ݱ��
        if (isStage2_DoorOpened)//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
        {
            codePanel2.SetActive(false);//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
            closedStage2_Door.SetActive(true);//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
            openedStage2_Door.SetActive(false);//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����

        }


        //��ư�� �ô��� �������� üũ
        //PC
        /* bool hDown = manager.isAction ? false : Input.GetButtonDown("Horizontal");
         bool vDown = manager.isAction ? false : Input.GetButtonDown("Vertical");
         bool hUp = manager.isAction ? false : Input.GetButtonUp("Horizontal");
         bool vUp = manager.isAction ? false : Input.GetButtonUp("Vertical");*/

        //Mobile
        /*bool hDown = manager.isAction ? false : right_Down|| left_Down;
        bool vDown = manager.isAction ? false : up_Down||down_Down;
        bool hUp = manager.isAction ? false : right_Up||left_Up;
        bool vUp = manager.isAction ? false : up_Up||down_Up;*/


        //�����̵� üũ
        if (hDown)
            isHorizonMove = true;
        else if (vDown)
            isHorizonMove = false;
        else if (hUp || vUp)
            isHorizonMove = h != 0;

        //�ִϸ��̼�
        if (anim.GetInteger("hAxisRaw") != h)
        {//h�� �ƴϸ� hAxisRaw���� �־��
            anim.SetBool("isChange", true);
            anim.SetInteger("hAxisRaw", (int)h);//h�� v��float�� �����ؼ� int�� ���� ����ȯ
        }
        else if (anim.GetInteger("vAxisRaw") != v)
        {//v�� �ƴϸ� vAxisRaw���� �־��
            anim.SetBool("isChange", true);
            anim.SetInteger("vAxisRaw", (int)v);//h�� v��float�� �����ؼ� int�� ���� ����ȯ
        }
        else//v�� h���� �ٲ��� �ʾ��� ��
            anim.SetBool("isChange", false);

        //����
        if (vDown && v == 1)//���� Vertial������ �����µ� �� ���� 1�̸�(��)
            dirVec = Vector3.up;//Vector3.up�� �������� �̵��̶� �ǹ̴�.
        else if (vDown && v == -1)//���� Vertial������ �����µ� �� ���� -1�̸�(�Ʒ�)
            dirVec = Vector3.down;
        else if (hDown && h == -1)//���� Horizontal������ �����µ� �� ���� -1�̸�(����)
            dirVec = Vector3.left;
        else if (hDown && h == 1)//���� Horizontal������ �����µ� �� ���� 1�̸�(������)
            dirVec = Vector3.right;


        //Object�� ��ĵ�غ���
        //�����̽� �ٸ� �����µ�scanObject�� ������� ������(��ĵ�� �� ������)
        if (Input.GetButtonDown("Jump") && scanObject != null)//����Ƽ���� �����̽� �ٴ� Jump��.
            manager.Action(scanObject);//�Ŵ������� ��ĵ�� �� ���
                                       //�����̽� �� ������ isAction�� ���ϰ� �Ǹ��� �÷��װ� �������� ��ȭâ�� 
                                       //�������� ĳ���Ͱ� ������ �� �ִ�.


        //Mobile �ʱ�ȭ//����� ��ư������ �������
        //Down, Up������ ������ ������ False�� �ʱ�ȭ
        up_Down=false;
        down_Down= false;
        left_Down= false;
        right_Down= false;
        up_Up= false;
        down_Up= false;
        left_Up= false;
        right_Up= false;
        







    }

    void FixedUpdate()
        {
            //������
            Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
            //�����̵�(isHorizonMove)�� ������ ���η� �����̰� �ƴϸ� ���η� ��������

            rigid.velocity = moveVec * Speed;

            //Ray(�繰 ��ĵ�ϱ� ���� ���� �ڵ�)
            //���� ������ ���
            Debug.DrawRay(rigid.position, dirVec * 0.7f, new Color(0, 1, 0));//��� �� ���� rigidbody ��ġ�� ����
                                                                             //������ ������ ���ߴ� ��, ���̴� 0.7f������ ����, ���� ���(0, 1, 0)
            RaycastHit2D raycastHit = Physics2D.Raycast(rigid.position, dirVec, 0.7f, LayerMask.GetMask("Object"));
            //Object�� ��ĵ�� �� ����

            //�տ� Object�� ������(collider�� ������)
            if (raycastHit.collider != null)
            {
                scanObject = raycastHit.collider.gameObject;
            }
            //���� Object�� ������
            else
            {
                scanObject = null;//��ĵ�� �� ����
            }


        }


    

    void OnTriggerEnter2D(Collider2D col)//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
    {
        //�������� 1 ��ݱ��
        if (col.gameObject.name.Equals("Stage1_Door") && !isStage1_DoorOpened)
        {
            //ControlSet.SetActive(false);
            codePanel.SetActive(true);//����


        }

        //��������2 ��ݱ��
        if (col.gameObject.name.Equals("Stage2_Door") && !isStage2_DoorOpened)
        {
            //ControlSet.SetActive(false);
            codePanel2.SetActive(true);//����


        }



        // ControlSet.SetActive(false);//���� ���� ����. �÷��̾ �������� ���ϵ��� �Ϸ���. �� �Ǹ� �����

    }


    void OnTriggerExit2D(Collider2D col)//��ݱ�ɶ����� �ϰ� ����. �� �Ǹ� �����
    {
        //��������1 ��ݱ��
        if (col.gameObject.name.Equals("Stage1_Door"))
        {
            codePanel.SetActive(false);//����
        }

        //��������2 ��ݱ��
        if (col.gameObject.name.Equals("Stage2_Door"))
        {
            codePanel2.SetActive(false);//����
        }
    }







    public void ButtonDown(string type)//�÷��̾� ������ ��ư������ �������
    {
        switch (type)//4������ ó���ϱ� ���� �Ű������� Ȱ���� Switch�� ���
        {
            case "U":
                up_Value = 1;//�� ���⸶�� ������ �Ҵ�
                up_Down = true;
                break;
            case "D":
                down_Value = -1;
                down_Down = true;
                break;
            case "L":
                left_Value = -1;
                left_Down = true;
                break;
            case "R":
                right_Value = 1;
                right_Down = true;
                break;
            case "A":
                if (scanObject != null)
                    manager.Action(scanObject);
                break;
            case "C":
                manager.SubMenuActive();
                break;

        }

    }

    public void ButtonUp(string type)//�÷��̾� ������ ��ư������ �������
        //��ư�� ���� ��
    {
        switch (type)//4������ ó���ϱ� ���� �Ű������� Ȱ���� Switch�� ���
        {
            case "U":
                up_Value = 0;
                up_Up = true;
                break;
            case "D":
                down_Value = 0;
                down_Up = true;
                break;
            case "L":
                left_Value = 0;
                left_Up = true;
                break;
            case "R":
                right_Value = 0;
                right_Up = true;
                break;

        }
    }
    
}
