using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    float velocidade = 5f;
    float velocidadeGirar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translate = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        float x = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;

        transform.Translate(x, 0, translate);
        
        
    }
}
