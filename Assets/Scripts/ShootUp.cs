using UnityEngine;

public class ShootUp : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 10f;
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(Vector3.up * forceAmount * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(this.gameObject);
        }
    }
}