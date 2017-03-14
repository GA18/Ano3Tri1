using System.Collections;
using UnityEngine;

public class InimigoMovimentando : MonoBehaviour
{
    public float velocidadeHorizontal;
    public float velocidadeVertical;
    public float min;
    public float max;
    public float espera;


    void Start()
    {
        StartCoroutine(Move(max));
    }

    IEnumerator Move(float destino)
    {
        while (Mathf.Abs(destino - transform.localPosition.y) > 0.2f)
        {
            Vector3 direcao = (destino == max) ? Vector3.up : Vector3.down;
            Vector3 velocidadeVetorial = direcao * velocidadeHorizontal;
            transform.localPosition = transform.localPosition + velocidadeVetorial * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(espera);

        destino = (destino == max) ? min : max;
        StartCoroutine(Move(destino));
    }

    void Update()
    {

        Vector3 direcao = Vector3.left * velocidadeVertical;
        transform.position = transform.position + direcao * Time.deltaTime;
    }
}