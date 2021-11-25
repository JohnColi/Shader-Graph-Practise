using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disslove_2D : MonoBehaviour
{
    Material material;
    bool isDissloving = false;
    float fade = 1;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isDissloving = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SetFade(1);
        }

        if (isDissloving)
        {
            fade -= Time.deltaTime;

            if (fade <= 0)
            {
                fade = 0;
                isDissloving = false;
            }
            material.SetFloat("_Fade", fade);
        }
    }

    private void SetFade(float fade)
    {
        this.fade = fade;
        material.SetFloat("_Fade", fade);
    }
}
