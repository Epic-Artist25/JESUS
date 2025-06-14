using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerController : MonoBehaviour
{
    ControladorDeVida hp;
    public Rigidbody rb;
    public int speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyFire" || collision.gameObject.tag == "Enemy")
        {
            ControladorDeVida.instacia.HpTotal(-1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyFire" || other.gameObject.tag == "Enemy")
        {
            ControladorDeVida.instacia.HpTotal(-1);
        }
    }
}
