using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using Unity.VisualScripting.Antlr3.Runtime;
using Unity.VisualScripting.FullSerializer;
using UnityEngine.EventSystems;
using JetBrains.Annotations;
//�̺�Ʈ �ý����� gpt����

public class GameManager : MonoBehaviour
{
    public AudioClip sfx; // ȿ���� ���(��ư�� ������ ��)
    AudioSource auso; //����� �ҽ� gpt����
    public GameObject[] btn1; // �� ���� ��ư(������ btn1[i]��Ȱ��ȭ, Name[i], fi[i], btn2[i], bgi[i]Ȱ��ȭ)//5.1
    public GameObject[] btn2; // ���� ���� ��ư(btn1[i]�� ������ �� Ȱ��ȭ, ������ �� �ش� ������� �̵�(�̰� ���� ���� ����))//5.2
    public GameObject[] mne; // ��, �۰ �̸�(btn1[i]�� ������ �� Ȱ��ȭ)//4
    public GameObject[] bgi; // �ڿ� ������ ����(btn1[i]�� ������ �� Ȱ��ȭ)//6 // ���� ���ȭ�� bgi��
    public GameObject[] fi; // �ٹ� �̹���(btn1[i]�� ������ �� Ȱ��ȭ)//3
    public GameObject Screen;//1 // �� ���� ��ü ���ȭ��
    public GameObject BG;//2
    public GameObject BGI; //���� ��ü ���ȭ��

    private static int pastI = 12;
    private static int i;
    private int cnt = 0; // �̰� �� ����?

    ////gpt����
    //private float lastClickTime = 0f;
    //private float catchTime = 0.25f; // ����Ŭ�� ���� �ð�


    void Awake()
    {
        
        auso = GetComponent<AudioSource>();
       
    }

    //i�� ����
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
            bgi[pastI].SetActive(false); //����
            fi[pastI].SetActive(false);
            Screen.SetActive(true);
            BGI.SetActive(true);
        }
        btn1[i].SetActive(false);
        btn2[i].SetActive(true);
        bgi[i].SetActive(false); //����
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
                break; //â���� ����
            }
            mne[i].SetActive(false);
            fi[i].SetActive(false);
        }
    }


    public void Play() //���̵� ����
    {
        if (i == pastI)
        {
            PlaySound();
            bgi[i].SetActive(true);
            Screen.SetActive(false);
            BGI.SetActive(true);
        }
    }

    //gpt����
    // Update is called once per frame
    void Update()
    {
        //gpt����
        if (bgi[i].activeSelf)
        {
            // ���� �ڷΰ��� Ű(ESC Ű)�� ���ȴٸ�
            if (Input.GetKeyDown(KeyCode.Escape)) //bgiâ������ ���� �ǵ��� ���� �ٶ�
            {
                // ���⿡ �ڷΰ��� ������ �߰��մϴ�.
                R();
                //Debug.Log("�ڷ�");  //�۵� �׽�Ʈ(����)
            }
        }
    }

    void PlaySound()
    {
        auso.Play();
    }
}


//gpt ����
//public void OnPointerClick(PointerEventData eventData)
//{
//    if (Time.time - lastClickTime < catchTime)
//    {
//        // ����Ŭ�� �� ������ �۾��� ���⿡ �߰��մϴ�.
//        Debug.Log("Double Click Detected!");

//        // ����Ŭ�� ���Ŀ��� ������ Ŭ�� �ð��� �ʱ�ȭ�մϴ�.
//        lastClickTime = 0f;
//    }
//    else
//    {
//        // ����Ŭ���� �ƴ� ��� ���� Ŭ�� �ð��� ����մϴ�.
//        lastClickTime = Time.time;
//    }
//}


//public void Back() //���̵� ���� //������ ���� ��
//{
//    Awake();
//}



//void Start() //���̵� ����
//{
//    setsong();
//}

//public class Music() //���̵� ����
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

