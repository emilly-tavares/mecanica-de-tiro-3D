using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour
{
    public Vector2 mouse;
    public float sensibilidade = 1f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse.x += Input.GetAxis("Mouse X") * sensibilidade;
        player.transform.localRotation = Quaternion.Euler(0, mouse.x, 0);

    }
}
