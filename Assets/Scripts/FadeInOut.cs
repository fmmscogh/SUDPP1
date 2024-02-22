using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public float fadeDuration = 1f; // ���̵� ��/�ƿ� ���� �ð�
    CanvasGroup group;
    private void Start()
    {
        group = FindObjectOfType<CanvasGroup>();
    }    

    // ���̵� �� ȿ��
    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(group, group.alpha, 1f, fadeDuration));
    }

    // ���̵� �ƿ� ȿ��
    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(group, group.alpha, 0f, fadeDuration));
    }

    // CanvasGroup�� ���� ���� ������ �����Ͽ� ���̵� ��/�ƿ� ȿ�� ����
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
