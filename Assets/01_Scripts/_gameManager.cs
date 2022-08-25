using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _gameManager : MonoBehaviour
{
    public GameObject player;
    public Transform _restPosition;


    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = _restPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
