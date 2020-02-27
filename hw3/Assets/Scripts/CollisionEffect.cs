using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffect : MonoBehaviour {
    public Transform door;

    public Vector3 closedPosition = new Vector3 (0f, 10f, 20f);
    public Vector3 openPosition = new Vector3 (0f, 15f, 20f);

    public float openSpeed = 5f;

    private bool open = false;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (open) {
            door.position = Vector3.Lerp (door.position, openPosition, Time.deltaTime * openSpeed);
        } else {
            door.position = Vector3.Lerp (door.position, closedPosition, Time.deltaTime * openSpeed);
        }
    }

    private void OnTriggerEnter (Collider other) {
        if (other.tag == "Player") {
            openDoor ();
        }
    }

    private void OnTriggerExit (Collider other) {
        if (other.tag == "Player") {
            closeDoor ();
        }
    }

    public void closeDoor () {
        open = false;
    }

    public void openDoor () {
        open = true;
    }
}