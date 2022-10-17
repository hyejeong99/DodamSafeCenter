using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class select : MonoBehaviour, IPointerClickHandler
{
    //  타 스크립트에서 chatBox 끄기, Panel 켜기하며 호출됨
    public Queue selectQ = selectQClass.selectQ;
    GameObject nextButton;

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
        }
        else if (this.tag == "select2")
        {
            selectQ.Enqueue(1);
        }

        nextButton.GetComponent<Image>().enabled = true;
    }

}
