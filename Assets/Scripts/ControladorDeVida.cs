using TMPro;
using UnityEngine;

public class ControladorDeVida : MonoBehaviour
{
    public TextMeshProUGUI HPTotal;
    public static int Vida = 25;
    public static ControladorDeVida instacia;
    public void Awake()
    {
        instacia = this;
    }

    public void HpTotal(int HP)
    {
        Vida += HP;
        HPTotal.text = "HP:" + Vida.ToString();
    }
    public void Regen(int Regeneration)
    {
        Vida += Regeneration;
        HPTotal.text = "HP:" + Vida.ToString();
    }
}
