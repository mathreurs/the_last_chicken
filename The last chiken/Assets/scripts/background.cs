using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public static background instance;

    public float speed = 0.5f;
    private float offset;
    private Material mat;
    // Start is called before the first frame update

    public void Awake()
    {
        instance = this;

    }
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        StartCoroutine(aumentarVelocidade());
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * speed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }

    IEnumerator aumentarVelocidade()
    {
        yield return new WaitForSeconds(7);
        speed += 0.2f;
        StartCoroutine(aumentarVelocidade());
    }
}
