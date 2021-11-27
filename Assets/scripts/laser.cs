using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    private float a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime / 10;
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, a);
    }
}
