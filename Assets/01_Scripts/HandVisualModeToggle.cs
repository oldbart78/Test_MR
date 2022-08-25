using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandVisualModeToggle : MonoBehaviour
{
    [SerializeField]
    private float HandVisualModeChangeInSeconds = 3.0f;

    private float internalTimer = 0;

    public GameObject hand_r;

    public Material[] materials;

    public int m_number = 0;

    /*
    public Material ghostMaterial;

    public Material skinMaterial;

    public Material Red;
    */


    // Update is called once per frame
    void Update()
    {
        if (internalTimer >= HandVisualModeChangeInSeconds)
        {
            internalTimer = 0;

            if(m_number > 3)
            {
                m_number = 0;
                            }
            else
            {
                m_number++;
            }

            //materials = new Material[m_number];

            hand_r.GetComponent<SkinnedMeshRenderer>().material = materials[m_number];
        }
        else
        {
            internalTimer += Time.deltaTime * 1.0f;
        }
    }
}
