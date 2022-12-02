using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBala : MonoBehaviour
{
    public float vida = 3f;

    
    void Awake()
    {
        Destroy(gameObject, vida);
    
    }

    void OnCollisionEnter(Collision objeto)
    {
        Destroy(objeto.gameObject);
        Destroy(gameObject);
    
    }

    
    
}
