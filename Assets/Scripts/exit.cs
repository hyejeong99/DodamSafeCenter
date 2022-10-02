using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class exit : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("MainScene");
    }
}
