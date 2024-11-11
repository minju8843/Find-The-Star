using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{

    //public VectorValue startingPosition;//맵 이동때문에 만듧


    public float Speed;
    public GameManager manager;//매니저 함수 불러오게 하는거
    Rigidbody2D rigid;
    Animator anim;
    float h;
    float v;
    bool isHorizonMove; //수평이동이냐
    Vector3 dirVec;//현재 바라보고 있는 방향 값을 가진 변수
    GameObject scanObject;//스캔이 되었다

    //모바일 키 값
    int up_Value;//키보드 없이 스마트폰에서 움직임이 가능하게
    int down_Value;//키보드 없이 스마트폰에서 움직임이 가능하게
    int left_Value;//키보드 없이 스마트폰에서 움직임이 가능하게
    int right_Value;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool up_Down;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool down_Down;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool left_Down;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool right_Down;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool up_Up;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool down_Up;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool left_Up;//키보드 없이 스마트폰에서 움직임이 가능하게
    bool right_Up;//키보드 없이 스마트폰에서 움직임이 가능하게

    //static public PlayerAction instance;//맵 이동때문에 만듧


    //public string currentMapName;//맵 이동때문에 만듧
    //private BoxCollider2D boxCollider;//맵 이동때문에 만듧


    [SerializeField]//잠금기능때문에 하고 있음. 안 되면 지우기

    //SerializeFied는 앞에 퍼블릭 없는 것을 나타나게 해주는 것 같음

    //스테이지1 잠금기능
    GameObject codePanel, closedStage1_Door, openedStage1_Door, codePanel2, closedStage2_Door, openedStage2_Door;//잠금기능때문에 하고 있음. 안 되면 지우기
    public static bool isStage1_DoorOpened, isStage2_DoorOpened = false;//잠금기능때문에 하고 있음. 안 되면 지우기

    //public GameObject ControlSet;//컨트롤 세트떄문에 만든 거 안 되면 지우기

    //스테이지2 잠금기능
    //GameObject codePanel2, closedStage2_Door, openedStage2_Door;//잠금기능때문에 하고 있음. 안 되면 지우기
    //public static bool isStage2_DoorOpened = false;//잠금기능때문에 하고 있음. 안 되면 지우기

    //public GameObject ControlSet2;//컨트롤 세트떄문에 만든 거 안 되면 지우기


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();//맵 안되면 다시살리기
        anim = GetComponent<Animator>();//맵 안되면 다시 살리기


        /*if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject); // 게임 오브젝트 파괴금지

            rigid = GetComponent<Rigidbody2D>();//맵 안되면 다시살리기
            anim = GetComponent<Animator>();//맵 안되면 다시 살리기
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);

        }*/
    }
    
    void Update()
    {
        //모바일과 PC통합 움직임
        h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal")+ right_Value + left_Value; //가로
        v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical")+ up_Value + down_Value; //세로


        //움직임 값

        //상태변수(isAction)를 사용하여 플레이어 이동 제한(대화할 때 움직이면 안 되니까)
        //액션이 취해진 상태이면 0 / false이다.(움직이지 마!)

        //이건 PC일 경우
        //h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal"); //가로
        //v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical"); //세로

        //이건 Mobile일 경우
        //h = manager.isAction ? 0 : right_Value+left_Value; //가로
        //v = manager.isAction ? 0 : up_Value+down_Value; //세로


        //Mobile 과 PC통합
        bool hDown = manager.isAction ? false : Input.GetButtonDown("Horizontal")|| right_Down || left_Down;
        bool vDown = manager.isAction ? false : Input.GetButtonDown("Vertical")|| up_Down || down_Down;
        bool hUp = manager.isAction ? false : Input.GetButtonUp("Horizontal")|| right_Up || left_Up;
        bool vUp = manager.isAction ? false : Input.GetButtonUp("Vertical") || up_Up || down_Up;

        //스테이지1 잠금기능
        if (isStage1_DoorOpened)//잠금기능때문에 하고 있음. 안 되면 지우기
        {
            codePanel.SetActive(false);//잠금기능때문에 하고 있음. 안 되면 지우기
            closedStage1_Door.SetActive(true);//잠금기능때문에 하고 있음. 안 되면 지우기
            openedStage1_Door.SetActive(false);//잠금기능때문에 하고 있음. 안 되면 지우기

        }

        //스테이지2 잠금기능
        if (isStage2_DoorOpened)//잠금기능때문에 하고 있음. 안 되면 지우기
        {
            codePanel2.SetActive(false);//잠금기능때문에 하고 있음. 안 되면 지우기
            closedStage2_Door.SetActive(true);//잠금기능때문에 하고 있음. 안 되면 지우기
            openedStage2_Door.SetActive(false);//잠금기능때문에 하고 있음. 안 되면 지우기

        }


        //버튼을 뗐는지 눌렀는지 체크
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


        //수평이동 체크
        if (hDown)
            isHorizonMove = true;
        else if (vDown)
            isHorizonMove = false;
        else if (hUp || vUp)
            isHorizonMove = h != 0;

        //애니메이션
        if (anim.GetInteger("hAxisRaw") != h)
        {//h가 아니면 hAxisRaw값을 넣어라
            anim.SetBool("isChange", true);
            anim.SetInteger("hAxisRaw", (int)h);//h와 v를float로 설정해서 int로 강제 형변환
        }
        else if (anim.GetInteger("vAxisRaw") != v)
        {//v가 아니면 vAxisRaw값을 넣어라
            anim.SetBool("isChange", true);
            anim.SetInteger("vAxisRaw", (int)v);//h와 v를float로 설정해서 int로 강제 형변환
        }
        else//v와 h값이 바뀌지 않았을 때
            anim.SetBool("isChange", false);

        //방향
        if (vDown && v == 1)//만약 Vertial방향을 눌렀는데 그 값이 1이면(위)
            dirVec = Vector3.up;//Vector3.up은 위쪽으로 이동이란 의미다.
        else if (vDown && v == -1)//만약 Vertial방향을 눌렀는데 그 값이 -1이면(아래)
            dirVec = Vector3.down;
        else if (hDown && h == -1)//만약 Horizontal방향을 눌렀는데 그 값이 -1이면(왼쪽)
            dirVec = Vector3.left;
        else if (hDown && h == 1)//만약 Horizontal방향을 눌렀는데 그 값이 1이면(오른쪽)
            dirVec = Vector3.right;


        //Object를 스캔해보자
        //스페이스 바를 눌렀는데scanObject가 비어있지 않으면(스캔된 게 있으면)
        if (Input.GetButtonDown("Jump") && scanObject != null)//유니티에서 스페이스 바는 Jump다.
            manager.Action(scanObject);//매니저에서 스캔한 걸 출력
                                       //스페이스 바 물러서 isAction이 취하게 되면은 플래그가 내려가서 대화창이 
                                       //내려가면 캐릭터가 움직일 수 있다.


        //Mobile 초기화//모바일 버튼때문에 만든거임
        //Down, Up변수는 로직이 끝나면 False로 초기화
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
            //움직임
            Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
            //수평이동(isHorizonMove)이 맞으면 가로로 움직이고 아니면 세로로 움직여라

            rigid.velocity = moveVec * Speed;

            //Ray(사물 스캔하기 위해 쓰는 코드)
            //위에 방향대로 쏜다
            Debug.DrawRay(rigid.position, dirVec * 0.7f, new Color(0, 1, 0));//쏘는 건 현재 rigidbody 위치가 기준
                                                                             //방향은 위에서 구했던 것, 길이는 0.7f정도로 하자, 색은 녹색(0, 1, 0)
            RaycastHit2D raycastHit = Physics2D.Raycast(rigid.position, dirVec, 0.7f, LayerMask.GetMask("Object"));
            //Object만 스캔할 수 있음

            //앞에 Object가 있으면(collider가 있으면)
            if (raycastHit.collider != null)
            {
                scanObject = raycastHit.collider.gameObject;
            }
            //만약 Object가 없으면
            else
            {
                scanObject = null;//스캔된 게 없다
            }


        }


    

    void OnTriggerEnter2D(Collider2D col)//잠금기능때문에 하고 있음. 안 되면 지우기
    {
        //스테이지 1 잠금기능
        if (col.gameObject.name.Equals("Stage1_Door") && !isStage1_DoorOpened)
        {
            //ControlSet.SetActive(false);
            codePanel.SetActive(true);//닫힘


        }

        //스테이지2 잠금기능
        if (col.gameObject.name.Equals("Stage2_Door") && !isStage2_DoorOpened)
        {
            //ControlSet.SetActive(false);
            codePanel2.SetActive(true);//닫힘


        }



        // ControlSet.SetActive(false);//새로 만든 거임. 플레이어가 움직이지 못하도록 하려고. 안 되면 지우기

    }


    void OnTriggerExit2D(Collider2D col)//잠금기능때문에 하고 있음. 안 되면 지우기
    {
        //스테이지1 잠금기능
        if (col.gameObject.name.Equals("Stage1_Door"))
        {
            codePanel.SetActive(false);//열림
        }

        //스테이지2 잠금기능
        if (col.gameObject.name.Equals("Stage2_Door"))
        {
            codePanel2.SetActive(false);//열림
        }
    }







    public void ButtonDown(string type)//플레이어 움직임 버튼때문에 만든거임
    {
        switch (type)//4방향을 처리하기 위해 매개변수를 활용한 Switch문 사용
        {
            case "U":
                up_Value = 1;//각 방향마다 변수를 할당
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

    public void ButtonUp(string type)//플레이어 움직임 버튼때문에 만든거임
        //버튼을 뗐을 때
    {
        switch (type)//4방향을 처리하기 위해 매개변수를 활용한 Switch문 사용
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
