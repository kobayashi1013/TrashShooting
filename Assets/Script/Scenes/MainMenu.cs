using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    public CanvasGroup startScreen;
    public float fadeDuration = 1f;
    
    void Start()
    {
        startScreen.alpha = 1;
    }

    public void StartGame()
    {
        StartCoroutine(FadeOut(startScreen, () => Debug.Log("Game Started!")));
    }
    
    IEnumerator FadeOut(CanvasGroup canvasGroup, System.Action onComplete)
    {
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = 1 - (elapsed / fadeDuration);
            yield return null;
        }
        canvasGroup.alpha = 0;
        onComplete?.Invoke();
    }
}