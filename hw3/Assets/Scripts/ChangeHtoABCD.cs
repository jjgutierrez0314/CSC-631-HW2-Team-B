using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeHtoABCD : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("A,B,C,D");
    }
}
