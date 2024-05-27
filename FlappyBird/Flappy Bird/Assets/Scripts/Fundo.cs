using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.4f;

    private Vector3 posicaoInicial;
    private float tamanhoDaImagemNaCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagemOriginal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoDaImagemNaCena = tamanhoDaImagemOriginal * escala;
    }

    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoDaImagemNaCena);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
