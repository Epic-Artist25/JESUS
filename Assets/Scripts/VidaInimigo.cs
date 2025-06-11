using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    int vida = 2;
    public static int enemyDead = 0;

    public void Tomardano(int dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            Destroy(gameObject);
            enemyDead += 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerFire")
        {
            Tomardano(vida);
        }
    }
}