using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlSound : MonoBehaviour
{
    public AudioSource audio;//배경음악
    public AudioSource effect1, effect2, effect3, effect4, effect5;//효과음
    public AudioSource voice1, voice2, voice3, voice4, voice5, voice6, voice7, voice8, voice9, voice10, voice11;//더빙

    private float backVol = 0.3f;
    private float dubbingVol = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //슬라이더로 변경한 배경음악 값 받아오기
        backVol = PlayerPrefs.GetFloat("backvol", 0.3f);
        audio.volume = backVol;

        //슬라이더로 변경한 더빙 값 받아오기
        dubbingVol = PlayerPrefs.GetFloat("dubbingVol", 0.5f);

        //효과음 크기 조정
        if(effect1!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect1.volume = backVol*0.66f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect1.volume = backVol*1.33f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect1.volume = backVol*1.6f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect1.volume = backVol*1.33f;
            }
        }
        if(effect2!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect2.volume = backVol*1.0f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect2.volume = backVol*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect2.volume = backVol*0.6f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect2.volume = backVol*3.33f;
            }
        }
        if(effect3!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect3.volume=backVol*3.33f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect3.volume = backVol*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect3.volume = backVol*0.3f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect3.volume = backVol*1.33f;
            }
        }
        if(effect4!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect4.volume=backVol*2.37f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect4.volume = backVol*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect4.volume = backVol*1.33f;
            }
        }
        if(effect5!=null){
            if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect5.volume = backVol*1.33f;
            }
        }

        //AI보이스 크기 조절
        //AI보이스 음성 조절
        if(voice1!=null){
            voice1.volume = dubbingVol;
        }if(voice2!=null){
            voice2.volume = dubbingVol;
        }if(voice3!=null){
            voice3.volume = dubbingVol;
        }if(voice4!=null){
            voice4.volume = dubbingVol;
        }if(voice5!=null){
            voice5.volume = dubbingVol;
        }if(voice6!=null){
            voice6.volume = dubbingVol;
        }if(voice7!=null){
            voice7.volume = dubbingVol;
        }if(voice8!=null){
            voice8.volume = dubbingVol;
        }if(voice9!=null){
            voice9.volume = dubbingVol;
        }if(voice10!=null){
            voice10.volume = dubbingVol;
        }if(voice11!=null){
            voice11.volume = dubbingVol;
        }
        /*if(effect1!=null){
            effect1.volume = backVol*1.5f;
        }
        if(effect2!=null){
            effect2.volume=backVol*1.6f;
        }
        if(effect3!=null){
            effect3.volume=backVol*0.3f;
        }
        if(effect4!=null){
            effect4.volume=backVol*1.6f;
        }
        if(effect5!=null){
            effect5.volume=backVol*1.6f;
        }if(ellect6!=null){
            effect5.volume=backVol*1.6f;
        }*/
    }

}
