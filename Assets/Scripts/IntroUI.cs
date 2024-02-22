using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroUI : MonoBehaviour
{
    FadeInOut fadeInOut;

    private void Awake()
    {
        fadeInOut = FindObjectOfType<FadeInOut>();
    }
    public void ChangeToMainScene()
    {
        Invoke("LoadScene", fadeInOut.fadeDuration);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
