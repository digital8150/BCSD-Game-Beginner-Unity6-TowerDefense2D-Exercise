using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private float spawnTime;
    [SerializeField]
    private Transform[] wayPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    // Update is called once per frame
    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject clone = Instantiate(enemyPrefab);
            Enemy enemy = clone.GetComponent<Enemy>();

            enemy.Setup(wayPoints);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
