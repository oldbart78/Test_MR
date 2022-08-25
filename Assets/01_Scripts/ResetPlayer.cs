using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public Transform _resetTransform;
    public GameObject _playerRig;
    public Camera _playerHeadCamera;



    public void ResetPosition()
    {

        float rotationAngleY = _resetTransform.rotation.eulerAngles.y - _playerHeadCamera.transform.rotation.eulerAngles.y;
        _playerRig.transform.Rotate(0, rotationAngleY, 0);

        var distanceDiff = _resetTransform.position - _playerHeadCamera.transform.position;

        _playerRig.transform.position += distanceDiff;


    }


    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
