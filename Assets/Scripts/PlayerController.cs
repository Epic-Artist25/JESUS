using UnityEngine;

public class PlayerController : MonoBehaviour
{
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
}
