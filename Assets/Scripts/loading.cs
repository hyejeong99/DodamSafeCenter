using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(WaitAndLoadScene());
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene("MainScene");
    }
}
