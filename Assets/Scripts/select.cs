using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class select : MonoBehaviour, IPointerClickHandler
{
    //  타 스크립트에서 chatBox 끄기, Panel 켜기하며 호출됨
    public Queue selectQ = selectQClass.selectQ;
    GameObject nextButton;
    public GameObject umbrellaBG, raincoatBG;

    void Start()
    {
        nextButton = GameObject.Find("nextButton");
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if(this.tag == "select1")
        {
            selectQ.Enqueue(0);
            PlayerPrefs.SetInt("select", 0);
            if(umbrellaBG!=null){
                if(SceneManager.GetActiveScene().name=="SummerStoryScene"){//우산
                    umbrellaBG.SetActive(true);
                }
            }
        }
        else if (this.tag == "select2")
        {
            selectQ.Enqueue(1);
            if(raincoatBG!=null){
                if(SceneManager.GetActiveScene().name=="SummerStoryScene"){//우비
                    raincoatBG.SetActive(true);
                }
            }
        }

        nextButton.GetComponent<Image>().enabled = true;
    }

}
