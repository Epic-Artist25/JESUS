using UnityEngine;

public class TiroPlayer : MonoBehaviour
{
    // tem que criar no player um empty obj pra o tiro não colidir com o player, também to fazendo esse tirosa serem filhos de uma "tela" mas ela pode ser só um gameobj vazio

    public GameObject Tiro;
    public GameObject ShootPoint;
    public GameObject tela;
    public int speed;
    public Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // tiro
            tela = GameObject.FindGameObjectWithTag("tela");
            Instantiate(Tiro, ShootPoint.transform.position, Quaternion.identity, tela.transform);
        }
    }
}