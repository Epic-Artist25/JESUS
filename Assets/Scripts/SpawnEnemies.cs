using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject prefab; //Prefab dos inimigos
    public GameObject spawn; //Game object vazio responsavel por spawnar os inimigos
    public int currentSpeed = 0;
    private GameObject currentWaveInstance;
    void Start()
    {
        SpawnWave();
    }

    void Update()
    {
        Respawn();
    }
    private void SpawnWave()
    {
        currentWaveInstance = Instantiate(prefab, spawn.transform.position, spawn.transform.rotation);
        MovimentoInimigo[] MovimentoInimigos = currentWaveInstance.GetComponentsInChildren<MovimentoInimigo>();
        foreach (MovimentoInimigo movement in MovimentoInimigos)
        {
            movement.velocidade += currentSpeed;
        }
    }
    //Método resonsavel pelo respawn dos inimigos
    public void Respawn()
    {
        if (VidaInimigo.enemyDead >= CountEnemiesInWave() && currentWaveInstance != null) //O número tem que ser a quantidade de inimigos presentes, então se tiver 20, o if tem que ser igual a 20
        {
            Destroy(currentWaveInstance);
            currentWaveInstance = null;
            VidaInimigo.enemyDead = 0;
            currentSpeed += 50;
            Debug.Log(currentSpeed);
            SpawnWave();
        }
    }
    private int CountEnemiesInWave()
    {
        if (prefab != null)
        {
            return prefab.GetComponentsInChildren<VidaInimigo>().Length;
        }
        return 0;
    }
}