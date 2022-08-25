using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class _ChangeSceneManager : MonoBehaviour
{
    public TextMeshProUGUI _tmp;

    private void Start()
    {
        _tmp.text = "Start!!";
    }


    private void OnTriggerEnter(Collider collider)
    {

        _tmp.text = collider.name;
        if (collider.tag == "Player")
        {
            SceneChange();
        }
    }


    public void SceneChange()
    {
        SceneManager.LoadScene("SceneChangeTest_2");
    }
}
