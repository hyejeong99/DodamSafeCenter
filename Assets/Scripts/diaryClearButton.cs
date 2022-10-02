using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class diaryClearButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("MainScene");
    }

}
