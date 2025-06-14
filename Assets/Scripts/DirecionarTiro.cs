using UnityEngine;

public class DirecionarTiro : MonoBehaviour {
    public Rigidbody tiro;
    public float forceAmount = 10f;
    void Start()
    {
        tiro.GetComponent<Rigidbody>();
    }

    void Update()
    {
        tiro.AddForce(Vector3.down * forceAmount * Time.deltaTime);
    }
}