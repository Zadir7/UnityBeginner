using UnityEngine;

namespace Game
{
    public class EnemySpawnerController : MonoBehaviour
    {
        public GameObject enemyToSpawn;
        public float spawnDelay;

        private float spawnTimer;


        private void FixedUpdate()
        {
            if (spawnTimer <= 0)
            {
                SpawnEnemy();
                spawnTimer = spawnDelay;
            }
            else
            {
                spawnTimer -= Time.fixedDeltaTime;
            }
        }

        private void SpawnEnemy()
        {
            Instantiate(enemyToSpawn, transform.position, transform.rotation);
        }
    }
}
