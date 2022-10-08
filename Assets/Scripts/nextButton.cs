using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class nextButton : MonoBehaviour, IPointerClickHandler
{
    Queue selectQ = selectQClass.selectQ;
    int beforeQC;
    bool isDone;

    GameObject scene;
    int maxChildCount;
    int curChildCount;

    public string sceneToLoad;

    //BGM
    public AudioClip springLaugh;
    public AudioClip springDrink;
    public AudioClip springCough;
    public AudioClip springEat;
    AudioSource audioSource;

    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        isDone = false;

        scene = GameObject.Find("scene");
        maxChildCount = scene.transform.childCount;
        curChildCount = 0;

        //기침 효과음 재생
        audioSource.clip=springCough;
        audioSource.Play();
    }


    void Update()
    {
        if(selectQ.Count > beforeQC && !isDone)    //  선택이 감지되면 다음 화면으로 전환
        {
            scene.transform.GetChild(curChildCount).gameObject.SetActive(false);
            curChildCount++;
            scene.transform.GetChild(curChildCount).gameObject.SetActive(true);

            isDone = true;
        }
        Debug.Log(curChildCount);

        //bgm재생
        switch (curChildCount){
            case 1:
                audioSource.Stop();
                audioSource.clip=springLaugh;
                audioSource.Play();
                break;
            case 3:
                audioSource.Stop();
                break;
            case 5:
                audioSource.clip=springDrink;
                audioSource.Play();
                break;
            case 7:
                audioSource.clip=springEat;
                audioSource.Play();
                break;
        } 
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("클릭 감지");
        if(curChildCount == maxChildCount - 1)  //  스토리가 끝나면
        {
            SceneManager.LoadScene(sceneToLoad);
            return;
        }


        scene.transform.GetChild(curChildCount).gameObject.SetActive(false);

        if(scene.transform.GetChild(curChildCount).tag == "goSelect")   // 다음 활성화할 오브젝트가 선택지라면
        {
            this.GetComponent<Image>().enabled = false;    //  넥스트버튼 이미지 무효
            isDone = false;    //  다음 선택여부를 감지하기 위해 돌려놓음
            beforeQC = selectQ.Count;   //  선택됐음을 감지하기 위해 선택 전 큐 사이즈 저장
        }


        curChildCount++;
        scene.transform.GetChild(curChildCount).gameObject.SetActive(true);

    }
}

