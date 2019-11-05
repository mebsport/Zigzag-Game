using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public Text splashText;

    IEnumerator Start()
    {
        splashText.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Game");
    }
    void FadeIn()
    {
        splashText.CrossFadeAlpha(1.0f, 1.5f, false);
    }
    void FadeOut()
    {
        splashText.CrossFadeAlpha(0.0f, 2.4f, false);
    }
}
