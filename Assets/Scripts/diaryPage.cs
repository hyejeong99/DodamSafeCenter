using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class diaryPage : MonoBehaviour, IPointerClickHandler
{
    TextMeshProUGUI diaryText;
    int page;

    Queue selectQ;

    public int weather;    // 봄 = 1, 여름 = 2, 가을 = 3, 겨울 = 4
    int summerText;
    List<List<string>> selectList;

    void Start()
    {
        diaryText = gameObject.GetComponent<TextMeshProUGUI>();
        page = 1;
        

        selectList = new List<List<string>>();
        for (int i = 0; i < 3; i++)
        {
            selectList.Add(new List<string>());
        }
        selectQ = selectQClass.selectQ;
        WriteText();
    }
    
    void WriteText()
    {
        switch (weather)
        {
            case 1:
                selectList[0].Add("일회용 마스크를 쓰고 학교로 갔다. ");
                selectList[0].Add("KF 마스크를 쓰고 학교로 갔다. ");
                selectList[1].Add("시원한 탄산음료를 마시고 난 후에도 목이 아파 물을 많이 마셨다. ");
                selectList[1].Add("물을 벌컥벌컥 마시고나니 괜찮아진 것 같았다. ");
                selectList[2].Add("환기를 했더니 답답한 느낌이 없어지는 것 같았다. 부모님이 오셔서 미세먼지가 심해도 환기는 하는게 좋다며 칭찬해주셨다. ");
                selectList[2].Add("그래도 미세먼지가 심하니 창문을 닫고 쉬고 있었다. 부모님이 오셔서 미세먼지가 심해도 환기는 하는게 좋다며 창문을 열었다. ");
                break;

            case 2:
                selectList[0].Add("우산을 쓰고 나갔다. 그런데 바람 때문에 우산이 자꾸 날아가려고 해서 힘들었다. ");
                selectList[0].Add("우비를 입고 나갔다. ");
                selectList[1].Add("집에 돌아가서 창문을 닫고 학교로 뛰었다. ");
                selectList[1].Add("지각하면 안되니 학교로 갔다. ");
                selectList[2].Add("재난 문자를 차단해보라고 했다. 그러자 옆에 있던 승희가 재난 문자를 차단하면 안된다고 알려줬다. ");
                selectList[2].Add("알림 설정을 바꿔보라고 말했다. ");
                break;

            case 3:
                selectList[0].Add("놀라서 밖으로 나갔다. ");
                selectList[0].Add("놀라서 아빠에게 전화했더니, 밖으로 나가라고 하셨다. ");
                selectList[1].Add("집으로 들어가려고 했는데, 아주머니가 조금 더 기다려보자고 하셨다. ");
                selectList[1].Add("그래도 조금 더 기다려봤다. ");
                selectList[2].Add("나는 민준이에게 무서웠다고 말했다. ");
                selectList[2].Add("다른 사람이 위험하니 그런 장난은 하지 말라고 말렸다. ");
                break;

            case 4:
                selectList[0].Add("추울까봐 장갑을 끼고 학교에 갔다. ");
                selectList[0].Add("눈을 밟으며 학교에 갔다. ");
                selectList[1].Add("그래도 주머니에 손을 넣었다. 그랬더니 미끄러워서 몇 번 넘어질뻔 했다. ");
                selectList[1].Add("길이 미끄러워서 넘어질까봐 주머니에서 손을 뺐다. ");
                selectList[2].Add("그래도 학원에 가려고 하는데, ");
                selectList[2].Add("부모님께 전화하려고 하는데, ");
                break;
        }   //  계절별로 선택지 텍스트 리스트에 넣어두기

        switch (weather)
        {
            case 1:
                diaryText.text = "오늘은 미세먼지가 심해서 하늘이 뿌옜다. ";
                diaryText.text += selectList[0][(int)selectQ.Dequeue()];
                diaryText.text += "선생님이 미세먼지가 심한 날에는 KF 마스크를 쓰는 것이 좋다고 말씀하셨다. " +
                    "오늘은 원래 체육 야외 수업이 있는 날인데 미세먼지가 심해서 취소됐다. " +
                    "하지만 대신에 친구들과 영화를 보며 반에서 재밌게 놀수 있어서 좋았다.\n" +
                    "학교 수업이 끝나고 집으로 돌아와 쉬고 있는데 미세먼지 때문에 목이 불편했다. ";
                diaryText.text += selectList[1][(int)selectQ.Dequeue()];
                diaryText.text += "미세먼지가 심해서 오늘 하루 종일 실내에만 있으니 답답한 느낌이 들었다. ";
                diaryText.text += selectList[2][(int)selectQ.Dequeue()];
                diaryText.text += "같이 맛있는 저녁을 먹으니 아팠던 목이 싹 낫는 것 같았다. 끝!";
                break;

            case 2:
                diaryText.text = "오늘은 태풍이 왔다. 아침에 비가 오니 ";
                diaryText.text += selectList[0][(int)selectQ.Dequeue()];
                diaryText.text += "그런데 내가 깜빡하고 집 창문을 열어놓고 나온 게 생각났다. 고민하다가 ";
                summerText = (int)selectQ.Dequeue();    //  추가 텍스트 대비하여 저장
                diaryText.text += selectList[1][summerText];
                diaryText.text += "반 친구들이 모두 물에 젖은 생쥐같아서 웃겼다.\n" +
                    "그런데 수업 시간에 민준이 핸드폰에서 재난 문자 알림이 울려서 민준이가 짜증을 냈다. 나는 ";
                diaryText.text += selectList[2][(int)selectQ.Dequeue()];
                diaryText.text += "\n학교가 끝나고 아빠가 데리러 오셔서 같이 집에 갔다. ";
                if(summerText == 1)
                {
                    diaryText.text += "그런데 내가 아침에 창문을 열고 나가서 집에 비가 흥건했다. 아빠는 다음부터 문을 꼭 닫아야 한다고 말하셨다. ";
                }
                diaryText.text += "그리고 아빠는 비가 온다며 전을 부쳐주셨다. " +
                    "태풍은 안 왔으면 좋겠지만 전은 매일 먹고 싶다. 끝!";
                break;

            case 3:
                diaryText.text = "어제 집에 있을 때 소화전이 울렸다. ";
                diaryText.text += selectList[0][(int)selectQ.Dequeue()];
                diaryText.text += "앞집 아주머니랑 건물 밖으로 나갔다. " +
                    "아주머니가 비상벨이 울리면 우선 밖으로 나가야 한다고 말하셨다. 그런데 밖에서 보니 불이 안 난 것 같았다. ";
                diaryText.text += selectList[1][(int)selectQ.Dequeue()];
                diaryText.text += "\n기다리니 경비 아저씨가 와서 누군가 장난친 것 같다며 들어가라고 하셨다. " +
                    "자기가 올 때까지 잘 기다렸다며 나를 칭찬해주셨다. " +
                    "\n그런데 오늘 학교에서 알게 되었는데, 민준이가 어제 장난을 친 것이었다. ";
                diaryText.text += selectList[2][(int)selectQ.Dequeue()];
                diaryText.text += "민준이는 미안하다고 했고, 오늘 같이 떡볶이를 먹고 화해했다. 끝!";
                break;

            case 4:
                diaryText.text = "오늘은 아침에 눈이 많이 쌓여있었다. ";
                diaryText.text += selectList[0][(int)selectQ.Dequeue()];
                diaryText.text += "눈이 와서 그런지 바닥이 엄청 미끄러웠다. ";
                diaryText.text += selectList[1][(int)selectQ.Dequeue()];
                diaryText.text += "\n그런데 학교에 있는 사이에 눈이 더 왔다. 학원에 가야 하는데 걱정이 됐다. ";
                diaryText.text += selectList[2][(int)selectQ.Dequeue()];
                diaryText.text += "선생님이 반에서 기다리라고 하셨다. 그동안 친구들이랑 떠들고 재미있게 놀았다. " +
                    "조금 이따가 집까지 데려다 주셨는데, 같이 가는 친구들끼리 눈싸움도 해서 즐거웠다. " +
                    "내일은 일어나서 눈사람을 만들어야지. 끝!";
                break;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(page < diaryText.textInfo.pageCount)
        {
            diaryText.pageToDisplay = ++page;
            if(page == diaryText.textInfo.pageCount)
            {
                GameObject.Find("stamp").gameObject.GetComponent<Image>().enabled = true;
            }
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
