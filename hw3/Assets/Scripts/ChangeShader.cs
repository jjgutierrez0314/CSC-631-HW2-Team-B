using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour
{
    public Material[] material;
    public GameObject obj;
    Renderer rend;

    public void SetShader()
    {
        if (rend.sharedMaterial == material[0])
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rend = obj.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (rend.sharedMaterial == material[0])
            {
                rend.sharedMaterial = material[1];
            }
            else
            {
                rend.sharedMaterial = material[0];
            }
        }
    }
}
