using UnityEngine;

public class Anda : MonoBehaviour
{
    private float velocidade;
    private bool indoParaDireita = false;

    // Limite dos lados
    public float limiteEsquerdo = -20f;
    public float limiteDireito = 15f;

    void Start()
    {
        // Velocidade lateral aleatória 3 e 8
        velocidade = Random.Range(3f, 8f);
    }

    void Update()
    {
        // Anda pra frente (se quiser pode mudar a velocidade so mudar o "1000")
        transform.Translate(Vector3.forward / 1000);
        //Anda pros lados
        Vector3 direcao = indoParaDireita ? Vector3.forward : Vector3.back;

        transform.Translate(direcao * velocidade * Time.deltaTime, Space.World);

        if (!indoParaDireita && transform.position.z <= limiteEsquerdo)
        {
            indoParaDireita = true;
        }
        else if (indoParaDireita && transform.position.z >= limiteDireito)
        {
            indoParaDireita = false;
        }
    }
}