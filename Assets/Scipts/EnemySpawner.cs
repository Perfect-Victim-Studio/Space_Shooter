using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject meteor;
    [SerializeField] float spawn_rate = 1;
    float elapsed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        EnemySpawn();
    }

    public void EnemySpawn()
    {
        //Time
        elapsed += Time.deltaTime;

        if(elapsed > spawn_rate)
        {
            elapsed = 0;

            //Position

            float ranx = Random.Range(-10f, 10f);
            float rany = 6f;

            Vector2 spawn = new Vector2(ranx, rany);

            Instantiate(meteor, spawn, Quaternion.identity);
        }
    }
}