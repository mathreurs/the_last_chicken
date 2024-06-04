using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fazendeiroManager : MonoBehaviour
{
    public GameObject antesGalinha,galinhaMaldita, sombraFazendeiro,pontoFa;
    public float speed;

    public Animator anim;
    private void Start()
    {
        
    }

    private void Update()
    {
        sombraFazendeiro.transform.position = Vector2.MoveTowards(pontoFa.transform.position, pontoFa.transform.position, speed * Time.deltaTime); ;
        if(player.instance.vidas >= 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, antesGalinha.transform.position, speed * Time.deltaTime);
        }
        

        if (player.instance.vidas <= 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, galinhaMaldita.transform.position, speed * Time.deltaTime);
            StartCoroutine(derrota());
            
        }
    }

    IEnumerator derrota()
    {
        yield return new WaitForSeconds(4);
        background.instance.speed = 0;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);
    }
}
