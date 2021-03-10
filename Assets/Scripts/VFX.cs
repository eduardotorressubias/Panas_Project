using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX : MonoBehaviour
{
    // Start is called before the first frame update
    private float counterTime;
    public float time;
    public GameObject vfx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counterTime += Time.deltaTime;
        if (counterTime >= time)
        {
            vfx.SetActive(true);
        }
        
    }
}
