using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float input;

    [ContextMenu("Floor Test")]
    private void FloorTest()
    {
        float Out = 0f;
        DoFloor(input, out Out);
    }

    private void DoFloor(float In, out float Out)
    {
        Out = Mathf.FloorToInt(In);
        Debug.Log(In + " > " + Out);
    }
}
