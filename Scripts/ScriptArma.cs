using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptArma : MonoBehaviour
{
    public Transform posicaoSpawn;
    public GameObject bala;
    public float velocidade = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        
            var bala1 = Instantiate(bala, posicaoSpawn.position, posicaoSpawn.rotation);
           bala1.GetComponent<Rigidbody>().velocity = posicaoSpawn.forward * velocidade;
        
        }
    }
}
