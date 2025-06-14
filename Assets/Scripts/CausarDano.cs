using UnityEngine;

public class CausarDano : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "BoundaryDown")
        {
            Destroy(this.gameObject);
        }
    }
}