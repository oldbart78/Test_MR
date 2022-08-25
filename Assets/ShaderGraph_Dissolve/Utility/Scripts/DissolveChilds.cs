using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DissolveExample
{
    public class DissolveChilds : MonoBehaviour
    {
        float value = 0;

        // Start is called before the first frame update
        List<Material> materials = new List<Material>();
        bool PingPong = false;
        void Start()
        {
            var renders = GetComponentsInChildren<Renderer>();
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

        // Update is called once per frame
        void Update()
        {
            // 반복시 
            //var value = Mathf.PingPong(Time.time * 0.5f, 1f);
            //SetValue(value);
                        
            value += Time.deltaTime * 0.2f;
            SetValue(value);
        }

        //IEnumerator enumerator()
        //{

        //    //float value =         while (true)
        //    //{
        //    //    Mathf.PingPong(value, 1f);
        //    //    value += Time.deltaTime;
        //    //    SetValue(value);
        //    //    yield return new WaitForEndOfFrame();
        //    //}
        //}

        public void SetValue(float value)
        {
            //if (value >= 1) return;

            for (int i = 0; i < materials.Count; i++)
            {
                materials[i].SetFloat("_Dissolve", value);
            }
        }
    }
}