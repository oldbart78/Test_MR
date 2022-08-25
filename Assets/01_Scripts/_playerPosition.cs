using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class _playerPosition : MonoBehaviour
{
    public TextMeshProUGUI _playerposition;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerposition.text = Player.transform.position.ToString();
    }
}
