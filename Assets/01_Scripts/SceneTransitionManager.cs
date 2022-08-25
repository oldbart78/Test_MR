using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public int sceneIndex;          // �̵��� �� �ε���

    public void GoToScene()
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }


    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        // ���̵�
        SceneManager.LoadScene(sceneIndex);
    }

    public void GoToSceneAsync()
    {
        StartCoroutine(GoToSceneAsyncRoutine(sceneIndex));
    }


    IEnumerator GoToSceneAsyncRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();

        // ���̵�
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        operation.allowSceneActivation = false;

        float timer = 0;
        while(timer <= fadeScreen.fadeDuration && !operation.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        operation.allowSceneActivation = true; ;

    }

}
