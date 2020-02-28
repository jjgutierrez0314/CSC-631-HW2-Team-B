using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject sphere;

    public void Spawn(Vector3 position)
    {
        Instantiate(sphere).transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono); // Convert mouse position on screen to position in the game world

            Spawn(new Vector3(position.x, position.y, sphere.transform.position.z));
        }
    }
}
