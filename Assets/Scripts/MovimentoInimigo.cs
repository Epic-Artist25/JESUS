using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentoInimigo : MonoBehaviour
{
    public float velocidade;

    void Update()
    {
        //Anda pros lados
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision) //Metodo que quando colidir com o limite da tela, por meio de um empty game object com um box colider, ira trocar direção e ir pro outro lado
    {
        if (collision.gameObject.tag == "Boundary")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 40, transform.position.z);
            velocidade *= -1;
        }
        if (collision.gameObject.tag == "BoundaryDown")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("LoseScreen");
        }
    }
}