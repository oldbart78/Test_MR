using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    public bool fadeOnStart = true;
    public float fadeDuration = 2;
    public Color fadeColor;
    private Renderer faderenderer;

    // Start is called before the first frame update
    void Start()
    {
        
        faderenderer = GetComponent<Renderer>();
        if (fadeOnStart)
            FadeIn();
    }

    public void FadeIn()
    {
        Fade(1, 0);
    }

    public void FadeOut()
    {
        Fade(0, 1);
    }




    public void Fade(float alphaIn, float alphaout)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaout));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaout)
    {
        float timer = 0;
        while(timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaout, timer / fadeDuration);

            faderenderer.material.SetColor("_BaseColor", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color newColor2 = fadeColor;
        newColor2.a = alphaout;
        faderenderer.material.SetColor("_BaseColor", newColor2);
    }



}
