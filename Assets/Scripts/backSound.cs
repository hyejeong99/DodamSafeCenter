using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if(backSlider!=null){
            backSlider.value = backVol;
            audio.volume = backSlider.value;

        }
        // backSlider.value = backVol;
        // audio.volume = backSlider.value;

        //계절별로 효과음 크기 조정해주기
        if(effect1!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect1.volume = backSlider.value*0.66f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect1.volume = backSlider.value*1.33f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect1.volume = backSlider.value*1.6f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect1.volume = backSlider.value*1.33f;
            }
        }
        if(effect2!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect2.volume=backSlider.value*1.0f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect2.volume = backSlider.value*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect2.volume = backSlider.value*0.6f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect2.volume = backSlider.value*3.33f;
            }
        }
        if(effect3!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect3.volume=backSlider.value*3.33f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect3.volume = backSlider.value*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect3.volume = backSlider.value*0.3f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect3.volume = backSlider.value*1.33f;
            }
        }
        if(effect4!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect4.volume=backSlider.value*2.37f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect4.volume = backSlider.value*1.366f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect4.volume = backSlider.value*1.33f;
            }
        }
        if(effect5!=null){
            if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect5.volume = backSlider.value*1.33f;
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
        //슬라이더로 배경음악 조절
        if(backSlider!=null){
            audio.volume = backSlider.value;
            backVol = backSlider.value;
        }
        // audio.volume = backSlider.value;
        // backVol = backSlider.value;
        //슬라이더 값 초기화되지 않도록 값 저장하기
        PlayerPrefs.SetFloat("backvol", backVol);

        //효과음 조절
        /*if(effect1!=null){
            effect1.volume = backSlider.value*1.5f;
        }
        if(effect2!=null){
            effect2.volume=backSlider.value*1.6f;
        }
        if(effect3!=null){
            effect3.volume=backSlider.value*0.3f;
        }
        if(effect4!=null){
            effect4.volume=backSlider.value*1.6f;
        }
        if(effect5!=null){
            effect5.volume=backSlider.value*1.6f;
        }*/

        if(effect1!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect1.volume = backSlider.value*0.66f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect1.volume = backSlider.value*1.33f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect1.volume = backSlider.value*1.6f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect1.volume = backSlider.value*1.33f;
            }
        }
        if(effect2!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect2.volume=backSlider.value*2.0f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect2.volume = backSlider.value*2.0f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect2.volume = backSlider.value*0.6f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect2.volume = backSlider.value*3.33f;
            }
        }
        if(effect3!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect3.volume=backSlider.value*5.0f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect3.volume = backSlider.value*1.66f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect3.volume = backSlider.value*0.3f;
            }else if(SceneManager.GetActiveScene().name=="WinterStoryScene"){
                effect3.volume = backSlider.value*1.33f;
            }
        }
        if(effect4!=null){
            if(SceneManager.GetActiveScene().name=="SpringStoryScene"){
                effect4.volume=backSlider.value*2.37f;
            }else if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect4.volume = backSlider.value*1.366f;
            }else if(SceneManager.GetActiveScene().name=="FallStoryScene"){
                effect4.volume = backSlider.value*1.33f;
            }
        }
        if(effect5!=null){
            if(SceneManager.GetActiveScene().name=="SummerStoryScene"){
                effect5.volume = backSlider.value*1.33f;
            }
        }
    }

}
