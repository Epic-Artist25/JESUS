using UnityEngine;

public class tiroInimigo : MonoBehaviour
{
    public GameObject TiroInimigo;
    public GameObject Inimigo;
    public GameObject tela;
    public float segundos = 2f;

    public float tempoEntreTiros = 2f; // tempo em segundos entre os tiros
    private float cronometro;

    void Start()
    {
        InvokeRepeating("EnemyFiring", segundos, 2f);
        cronometro = tempoEntreTiros;
    }

    void Update()
    {
        /*cronometro -= Time.deltaTime;

        if (cronometro <= 0f)
        {
            tela = GameObject.FindGameObjectWithTag("tela");

            if (tela != null && TiroInimigo != null && Inimigo != null)
            {
                Instantiate(TiroInimigo, Inimigo.transform.position, Quaternion.identity, tela.transform);
            }

            cronometro = tempoEntreTiros; // reinicia o contador
        }*/
    }
    void EnemyFiring()
    {
        Instantiate(TiroInimigo, transform.position, transform.rotation);
    }
}