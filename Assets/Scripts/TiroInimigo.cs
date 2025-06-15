using UnityEngine;

public class tiroInimigo : MonoBehaviour
{
    public GameObject TiroInimigo;
    public GameObject Inimigo;
    public float segundos = 2f;

    void Start()
    {
        InvokeRepeating("EnemyFiring", segundos, 2f);
    }
    void EnemyFiring()
    {
        Instantiate(TiroInimigo, transform.position, transform.rotation);
    }
}