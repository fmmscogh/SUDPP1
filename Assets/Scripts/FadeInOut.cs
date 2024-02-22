using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public float fadeDuration = 1f; // 페이드 인/아웃 지속 시간
    CanvasGroup group;
    private void Start()
    {
        group = FindObjectOfType<CanvasGroup>();
    }    

    // 페이드 인 효과
    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(group, group.alpha, 1f, fadeDuration));
    }

    // 페이드 아웃 효과
    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(group, group.alpha, 0f, fadeDuration));
    }

    // CanvasGroup의 알파 값을 서서히 변경하여 페이드 인/아웃 효과 구현
    IEnumerator FadeCanvasGroup(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
            canvasGroup.alpha = alpha;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = endAlpha;
    }
}
