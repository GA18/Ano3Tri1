﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PranchaMove : MonoBehaviour
{

    public float velocidade = 1f;
    public float limite;
    public float retorno;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 velocidadeVetorial = Vector3.left * velocidade;

        transform.localPosition = transform.localPosition + velocidadeVetorial * Time.deltaTime;

        if (transform.localPosition.x <= limite)
        {
            transform.localPosition = new Vector3(retorno, transform.localPosition.y, transform.localPosition.z);
        }
    }
}
