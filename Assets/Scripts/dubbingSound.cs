using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
public class dubbingSound : MonoBehaviour
{
    public Slider voiceSlider;
    private float dubbingVol = 0.5f;
    public AudioSource voice1, voice2, voice3, voice4, voice5, voice6, voice7, voice8, voice9, voice10, voice11;//더빙
    // Start is called before the first frame update
    void Start()
    {
        //보이스 음량 비어있으면 0.5f 값으로 가져오기
        dubbingVol = PlayerPrefs.GetFloat("dubbingVol", 0.5f);
        if(voiceSlider!=null){
            voiceSlider.value = dubbingVol;
            //AI보이스 크기 조절
            if(voice1!=null){
                voice1.volume = voiceSlider.value;
            }if(voice2!=null){
                voice2.volume = voiceSlider.value;
            }if(voice3!=null){
                voice3.volume = voiceSlider.value;
            }if(voice4!=null){
                voice4.volume = voiceSlider.value;
            }if(voice5!=null){
                voice5.volume = voiceSlider.value;
            }if(voice6!=null){
                voice6.volume = voiceSlider.value;
            }if(voice7!=null){
                voice7.volume = voiceSlider.value;
            }if(voice8!=null){
                voice8.volume = voiceSlider.value;
            }if(voice9!=null){
                voice9.volume = voiceSlider.value;
            }if(voice10!=null){
                voice10.volume = voiceSlider.value;
            }if(voice11!=null){
                voice11.volume = voiceSlider.value;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        //슬라이더로 AI보이스 조절
        if(voiceSlider!=null){
            //AI보이스 크기 조절
            if(voice1!=null){
                voice1.volume = voiceSlider.value;
            }if(voice2!=null){
                voice2.volume = voiceSlider.value;
            }if(voice3!=null){
                voice3.volume = voiceSlider.value;
            }if(voice4!=null){
                voice4.volume = voiceSlider.value;
            }if(voice5!=null){
                voice5.volume = voiceSlider.value;
            }if(voice6!=null){
                voice6.volume = voiceSlider.value;
            }if(voice7!=null){
                voice7.volume = voiceSlider.value;
            }if(voice8!=null){
                voice8.volume = voiceSlider.value;
            }if(voice9!=null){
                voice9.volume = voiceSlider.value;
            }if(voice10!=null){
                voice10.volume = voiceSlider.value;
            }if(voice11!=null){
                voice11.volume = voiceSlider.value;
            }

            dubbingVol = voiceSlider.value;
        }
        //슬라이더 값 초기화되지 않도록 값 저장하기
        PlayerPrefs.SetFloat("dubbingVol", dubbingVol);
    }
}
