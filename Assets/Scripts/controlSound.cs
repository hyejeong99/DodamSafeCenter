using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlSound : MonoBehaviour
{
    public AudioSource audio;//배경음악
    public AudioSource effect1, effect2, effect3, effect4, effect5, effect6;//효과음

    private float backVol = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        //슬라이더로 변경한 배경음악 값 받아오기
        backVol = PlayerPrefs.GetFloat("backvol", 0.1f);
        audio.volume = backVol;

        //계절별로 효과음 크기 조정해주기
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
                effect2.volume = backVol*2.0f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect2.volume = backVol*2.0f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect2.volume = backVol*0.6f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect2.volume = backVol*3.33f;
            }
        }
        if(effect3!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect3.volume=backVol*5.0f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect3.volume = backVol*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect3.volume = backVol*0.3f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect3.volume = backVol*1.66f;
            }
        }
        if(effect4!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect4.volume=backVol*2.37f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect4.volume = backVol*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect4.volume = backVol*1.66f;
            }
        }
        if(effect5!=null){
            if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect5.volume = backVol*1.66f;
            }
        }if(effect6!=null){
            if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect6.volume = backVol*1.33f;
            }
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
