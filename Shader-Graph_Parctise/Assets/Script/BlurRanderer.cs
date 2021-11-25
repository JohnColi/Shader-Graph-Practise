using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlurRanderer : MonoBehaviour
{
    [SerializeField] Camera blurCamera;
    [SerializeField] Material blurMaterial;
    [SerializeField] RenderTexture _renderTexture;

    // Start is called before the first frame update
    void Start()
    {
        //if (blurCamera.targetTexture != null)
        //{
        //    blurCamera.targetTexture.Release();
        //}
        //blurCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32);
        //blurMaterial.SetTexture("_RenTex", blurCamera.targetTexture);

        //_renderTexture.width = Screen.width;
        //_renderTexture.height = Screen.height;
    }

}
