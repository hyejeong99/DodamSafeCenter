using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class slider : MonoBehaviour, IPointerClickHandler
{
    public GameObject popUp;
    public void OnPointerClick(PointerEventData eventData)
    {
        //설정 버튼 누르면 슬라이더 보이기
        popUp.SetActive(true);
    }
}
