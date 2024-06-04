using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject fazendeiro, botaoMob;

    public static player instance;
    public int vidas;

    private Rigidbody2D rb;
    public float jump,index;

    public bool grounded;

    public int pontos;

    public TextMeshProUGUI pontosTXT;

    public int mobs;

    public void Awake()
    {
        instance = this;

    }
    private void Start()
    {
        vidas = 3;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(pontinhos());
    }

    private void Update()
    {
        pontosTXT.text = pontos.ToString();
        if (Input.GetButtonDown("Jump") && grounded == true || Input.GetKeyDown(KeyCode.W) && grounded == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if(vidas == 1)
        {
            fazendeiro.SetActive(true); 
        }
    }

    IEnumerator pontinhos()
    {
        yield return new WaitForSeconds(index);
        pontos++;
        StartCoroutine(pontinhos());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("solo"))
        {
            grounded = true;
        }

        if (collision.CompareTag("obstaculo"))
        {
            vidas-=1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("solo"))
        {
            grounded = false;
        }
    }

}
