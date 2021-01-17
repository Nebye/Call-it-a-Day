using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Camera_Follow : MonoBehaviour
{
    public Transform player;
    public float cameraDis = 20.0f;

    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = (Screen.height / 2) / cameraDis;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

}
