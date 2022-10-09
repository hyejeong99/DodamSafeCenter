using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class playSound : MonoBehaviour, IPointerClickHandler
{

    //BGM
    public AudioClip ringBell;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.tag == "select2")
        {
            audioSource.clip=ringBell;
            audioSource.Play();
            Debug.Log("소리재생");
        }else{
            Debug.Log("모임");
        }
    }
}
