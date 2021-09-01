using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    public float Background_Speed;
    public Renderer backrenderer;


    // Update is called once per frame
    void Update()
    {
        backrenderer.material.mainTextureOffset += new Vector2(Background_Speed*Time.deltaTime, 0);         
    }
}
