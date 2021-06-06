
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class TextureOffsetAnimation : UdonSharpBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private float scrollSpeedHorizontal = 0.5f;
    [SerializeField] private float scrollSpeedVertical = 0.5f;
    void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        float offsetHorizontal = Time.time * scrollSpeedHorizontal;
        float offsetVertical = Time.time * scrollSpeedVertical;
        image.material.SetTextureOffset("_MainTex", new Vector2(offsetHorizontal, -offsetVertical));
    }
}
