using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundloop : MonoBehaviour
{

    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed,0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
