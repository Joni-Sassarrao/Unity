using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1;

    [SerializeField]
    private float variacaoposicaoY;
    void Start()
    {

    }
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoposicaoY, variacaoposicaoY));
    }
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}