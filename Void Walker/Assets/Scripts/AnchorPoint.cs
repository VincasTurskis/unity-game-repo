using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorPoint : MonoBehaviour
{
    public bool isUsed = false;
    public float angle = 0; // Says which way any possible module attached to this point should be facing, from 0 to 360 (0 is up)

    private SpriteRenderer colorSprite;
    void Awake()
    {
        colorSprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
    }
    public SpriteRenderer GetColorSprite()
    {
        return colorSprite;
    }
}
