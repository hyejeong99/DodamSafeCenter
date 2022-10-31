using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class controlSound : MonoBehaviour
{
    public AudioSource audio;//배경음악
    public AudioSource effect1, effect2, effect3, effect4, effect5;//효과음

    private float backVol = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        //슬라이더로 변경한 배경음악 값 받아오기
        backVol = PlayerPrefs.GetFloat("backvol", 0.1f);
        audio.volume = backVol;

        //효과음 받아오기
        effect1.volume = backVol*1.5f;
        effect2.volume=backVol*1.6f;
        effect3.volume=backVol*0.3f;
        effect4.volume=backVol*1.6f;
        effect5.volume=backVol*1.6f;
    }

}
