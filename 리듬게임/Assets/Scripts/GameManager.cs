using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Unity.VisualScripting.Antlr3.Runtime;
using Unity.VisualScripting.FullSerializer;
using UnityEngine.EventSystems;
using JetBrains.Annotations;
//이벤트 시스템은 gpt참조

public class GameManager : MonoBehaviour
{
    public AudioClip sfx; // 효과음 재생(버튼을 눌렀을 때)
    AudioSource auso; //오디오 소스 gpt참조
    public GameObject[] btn1; // 곡 선택 버튼(누르면 btn1[i]비활성화, Name[i], fi[i], btn2[i], bgi[i]활성화)//5.1
    public GameObject[] btn2; // 게임 시작 버튼(btn1[i]를 눌렀을 때 활성화, 눌렀을 때 해당 장면으로 이동(이건 내가 이을 거임))//5.2
    public GameObject[] mne; // 곡, 작곡가 이름(btn1[i]를 눌렀을 때 활성화)//4
    public GameObject[] bgi; // 뒤에 나오는 사진(btn1[i]를 눌렀을 때 활성화)//6 // 게임 배경화면 bgi들
    public GameObject[] fi; // 앨범 이미지(btn1[i]를 눌렀을 때 활성화)//3
    public GameObject Screen;//1 // 곡 선택 전체 배경화면
    public GameObject BG;//2
    public GameObject BGI; //게임 전체 배경화면

    private static int pastI = 12;
    private static int i;
    private int cnt = 0; // 이거 왜 만듦?

    ////gpt참조
    //private float lastClickTime = 0f;
    //private float catchTime = 0.25f; // 더블클릭 간격 시간


    void Awake()
    {
        
        auso = GetComponent<AudioSource>();
       
    }

    //i값 변동
    public void Set1()
    {
        i = 0;
    }

    public void Set2()
    {
        i = 1;
    }

    public void Set3()
    {
        i = 2;
    }

    public void Set4()
    {
        i = 3;
    }
    public void Set5()
    {
        i = 4;
    }

    public void Set6()
    {
        i = 5;
    }

    public void Set7()
    {
        i = 6;
    }

    public void Set8()
    {
        i = 7;
    }

    public void Set9()
    {
        i = 8;
    }

    public void Set10()
    {
        i = 9;
    }

    public void Set11()
    {
        i = 10;
    }   

    public void Set12()
    {
        i = 11;
    }

    public void R()
    {
        btn1[i].SetActive(true);
        btn2[i].SetActive(false);
        mne[i].SetActive(false);
        bgi[i].SetActive(false);
        fi[i].SetActive(false);
        Screen.SetActive(true);
        BGI.SetActive(true);
    }



    public void Click() //?
    {
        if (i != pastI && cnt != 0)
        {
           
            btn1[pastI].SetActive(true);
            btn2[pastI].SetActive(false);
            mne[pastI].SetActive(false);
            bgi[pastI].SetActive(false); //수정
            fi[pastI].SetActive(false);
            Screen.SetActive(true);
            BGI.SetActive(true);
        }
        btn1[i].SetActive(false);
        btn2[i].SetActive(true);
        bgi[i].SetActive(false); //수정
        Screen.SetActive(true);
        BGI.SetActive(true);
        pastI = i;
        cnt++;

        for (int i = 0; i < 12; i++)
        {
            if (GameManager.i == i)
            {
                mne[i].SetActive(true);
                fi[i].SetActive(true);
                break; //창진이 도움
            }
            mne[i].SetActive(false);
            fi[i].SetActive(false);
        }
    }


    public void Play() //케이디 참고
    {
        if (i == pastI)
        {
            PlaySound();
            bgi[i].SetActive(true);
            Screen.SetActive(false);
            BGI.SetActive(true);
        }
    }

    //gpt참조
    // Update is called once per frame
    void Update()
    {
        //gpt참조
        if (bgi[i].activeSelf)
        {
            // 만약 뒤로가기 키(ESC 키)가 눌렸다면
            if (Input.GetKeyDown(KeyCode.Escape)) //bgi창에서만 실행 되도록 수정 바람
            {
                // 여기에 뒤로가는 동작을 추가합니다.
                R();
                //Debug.Log("뒤로");  //작동 테스트(성공)
            }
        }
    }

    void PlaySound()
    {
        auso.Play();
    }
}


//gpt 참조
//public void OnPointerClick(PointerEventData eventData)
//{
//    if (Time.time - lastClickTime < catchTime)
//    {
//        // 더블클릭 시 실행할 작업을 여기에 추가합니다.
//        Debug.Log("Double Click Detected!");

//        // 더블클릭 이후에는 마지막 클릭 시간을 초기화합니다.
//        lastClickTime = 0f;
//    }
//    else
//    {
//        // 더블클릭이 아닌 경우 현재 클릭 시간을 기록합니다.
//        lastClickTime = Time.time;
//    }
//}


//public void Back() //케이디 참고 //스스로 만든 것
//{
//    Awake();
//}



//void Start() //케이디 참고
//{
//    setsong();
//}

//public class Music() //케이디 참고
//{
//    btn1, btn2;
//    int sng = 0;

//    public  void Nextsong()
//    {
//        sou.("Touch");

//        if (++sng > btn1.Length - 1)
//            sng = 0;

//        setsong();
//    }

//    public void Priorsong()
//    {
//        sou.("Touch");

//        if (--sng < 0)
//            sng = btn1.Length - 1;

//        setsong();
//    }

//    void Setsong()
//    {
//        btn1[sng];
//    }
//} 

