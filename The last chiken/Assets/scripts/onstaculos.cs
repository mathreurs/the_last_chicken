using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class onstaculos : MonoBehaviour
{
    public float velocidade;

    public GameObject spawn;

    
    
    private void Update()
    {
        
        velocidade = background.instance.speed + (background.instance.speed/0.9f);
        transform.position = new Vector2(transform.position.x - velocidade * Time.deltaTime,transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("parede"))
        {
            transform.position = spawn.transform.position;
        }
    }


}
