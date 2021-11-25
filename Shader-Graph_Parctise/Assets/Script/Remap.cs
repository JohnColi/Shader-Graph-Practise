using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remap : MonoBehaviour
{
    public float In;
    public Vector2 InMinMax;
    public Vector2 OutMinMax;

    [ContextMenu("Remap Test")]
    private void RemapTest()
    {
        float Out = 0;
        Unity_Remap_float4(In, InMinMax, OutMinMax, out Out);
        Debug.LogFormat("{0} => {1}", In, Out);
    }

    void Unity_Remap_float4(float In, Vector2 InMinMax, Vector2 OutMinMax, out float Out)
    {
        Out = OutMinMax.x + (In - InMinMax.x) * (OutMinMax.y - OutMinMax.x) / (InMinMax.y - InMinMax.x);
    }
}
