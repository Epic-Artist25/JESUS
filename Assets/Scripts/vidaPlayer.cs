using UnityEngine;

public class vidaPlayer : MonoBehaviour
{
    int vida = 3;

    public void Tomardano(int dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}