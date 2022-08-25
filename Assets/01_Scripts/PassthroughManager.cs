using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassthroughManager : MonoBehaviour
{
    public OVRPassthroughLayer passthroughLayer;
    public OVRInput.Button button;
    public OVRInput.Controller controller;
    public GameObject starfields;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(button, controller))
        {
            passthroughLayer.hidden = !passthroughLayer.hidden;
            starfields.SetActive(!starfields.activeSelf);
        }
    }
}
