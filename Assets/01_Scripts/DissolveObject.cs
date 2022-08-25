using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    float value = 0;
    bool isTouch = false;

    // Start is called before the first frame update
    List<Material> materials = new List<Material>();
    //bool PingPong = false;
    
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;


        var renders = GetComponents<Renderer>();
        for (int i = 0; i < renders.Length; i++)
        {
            materials.AddRange(renders[i].materials);
        }
    }

    private void Reset()
    {
        Start();
        SetValue(0);

    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (isTouch == true) return;

        if (other.tag == "Player")
        {
            isTouch = true;
            ChangeMaterial();
        }
    }

    public void ChangeMaterial()
    {
        rend.sharedMaterial = material[1];
        StartCoroutine(DissolveMaterial());
    }

    IEnumerator DissolveMaterial()
    {
        while (value <= 1)
        {
            value += Time.deltaTime * 0.2f;
            SetValue(value);
            yield return null;
        }
    }

    /*
    // Update is called once per frame
    void Update()
    {
        // ¹Ýº¹½Ã 
        //var value = Mathf.PingPong(Time.time * 0.5f, 1f);
        //SetValue(value);

        value += Time.deltaTime * 0.2f;
        SetValue(value);
    }
    */

    /*
    IEnumerator enumerator()
    {

        float value =         
        while (true)
        {
         Mathf.PingPong(value, 1f);
        value += Time.deltaTime;
        SetValue(value);
        yield return new WaitForEndOfFrame();
        }
    }
    */

    public void SetValue(float value)
    {
        //if (value >= 1) return;
        rend.material.SetFloat("_Dissolve", value);

        /*
        for (int i = 0; i < materials.Count; i++)
        {
            materials[i].SetFloat("_Dissolve", value);
        }
        */
    }

}