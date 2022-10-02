using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class mainButton : MonoBehaviour, IPointerClickHandler
{
    public string scene;
    public Queue<int> selectQ = new Queue<int>();
    
    public void OnPointerClick(PointerEventData eventData)
    {
        selectQ.Clear();
        SceneManager.LoadScene(scene);
    }
}
