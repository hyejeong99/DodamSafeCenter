using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class mainButton : MonoBehaviour, IPointerClickHandler
{
    public string scene;
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(scene);
    }
}
