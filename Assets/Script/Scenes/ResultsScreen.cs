using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResultScreenManager : MonoBehaviour
{
    public CanvasGroup resultScreen;
    public float fadeDuration = 1f;
    
    void Start()
    {
        resultScreen.alpha = 0;
    }
    
    public void ShowResult()
    {
        StartCoroutine(FadeIn(resultScreen));
    }
    
    IEnumerator FadeIn(CanvasGroup canvasGroup)
    {
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = elapsed / fadeDuration;
            yield return null;
        }
        canvasGroup.alpha = 1;
    }
}
