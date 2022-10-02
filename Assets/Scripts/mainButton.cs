using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class mainButton : MonoBehaviour, IPointerClickHandler
{
    public string scene;
    public Queue selectQ = selectQClass.selectQ;


    public void OnPointerClick(PointerEventData eventData)
    {
        selectQ.Clear();
        SceneManager.LoadScene(scene);
    }
}
