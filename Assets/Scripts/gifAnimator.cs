using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gifAnimator : MonoBehaviour
{
    public Texture2D[] frames;
    private float fps = 60.0f;

    // Update is called once per frame
    void Update()
    {
        float index = Time.time * fps;
        index = index % frames.Length;
        GetComponent<Renderer>().material.mainTexture = frames[(int)index];
    }
}
