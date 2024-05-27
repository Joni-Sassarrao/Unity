using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoposicaoY;
    void Start()
    {
        
    }
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-1,1));  
    }
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
