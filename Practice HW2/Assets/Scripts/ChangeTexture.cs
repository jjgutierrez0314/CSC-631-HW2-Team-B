using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviour {

    public Material Material1;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object;

    public void SetTexture() {
            Object.GetComponent<MeshRenderer>().material = Material1;
    }
}