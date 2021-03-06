﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController instancia = null;

    public GameObject obstaculo;
    public float espera;
    public float tempoDestruicao;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else if (instancia != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        StartCoroutine(GerarObstaculos());

    }
    IEnumerator GerarObstaculos()
    {
        while (true)
        {
            Vector3 pos = new Vector3(3f, Random.Range(0f, 4f), 7.2f);
            GameObject obj = Instantiate(obstaculo, pos, Quaternion.identity) as GameObject;
            Destroy(obj, tempoDestruicao);
            yield return new WaitForSeconds(espera);
        }
    }
}
