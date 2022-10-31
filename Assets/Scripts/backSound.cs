using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class backSound : MonoBehaviour
{
    public Slider backSlider;
    public AudioSource audio;//배경음악
    public AudioSource effect1, effect2, effect3, effect4, effect5;//효과음

    private float backVol = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        //배경음악 음량 비어있으면 0.3f 값으로 가져오기
        backVol = PlayerPrefs.GetFloat("backvol", 0.3f);
        backSlider.value = backVol;
        audio.volume = backSlider.value;

        //효과음
        effect1.volume = backSlider.value*1.5f;
        effect2.volume=backSlider.value*1.6f;
        effect3.volume=backSlider.value*0.3f;
        effect4.volume=backSlider.value*1.6f;
        effect5.volume=backSlider.value*1.6f;
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        //슬라이더로 배경음악 조절
        audio.volume = backSlider.value;
        backVol = backSlider.value;
        //슬라이더 값 초기화되지 않도록 값 저장하기
        PlayerPrefs.SetFloat("backvol", backVol);

        //효과음 조절
        effect1.volume = backSlider.value*1.5f;
        effect2.volume = backSlider.value*1.6f;
        effect3.volume = backSlider.value*0.3f;
        effect4.volume = backSlider.value*1.6f;
        effect5.volume = backSlider.value*1.6f;
    }

}
