using UnityEngine;

public class VidaBarreira : MonoBehaviour
{
    public int vida = 20;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyFire")
        {
            vida--;
            if(vida == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
