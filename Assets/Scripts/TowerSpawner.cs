using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPrefab;
    [SerializeField]
    private EnemySpawner enemySpawner;
    [SerializeField]
    private int towerCostGold = 50;
    [SerializeField]
    private PlayerGold playerGold;

    public void SpawnTower(Transform tileTransform)
    {
        if (towerCostGold > playerGold.CurrentGold)
        {
            return;
        }

        Tile tile = tileTransform.GetComponent<Tile>();

        if(tile.IsBuildTower == true)
        {
            return;
        }

        tile.IsBuildTower = true;
        playerGold.CurrentGold -= towerCostGold;
        GameObject clone = Instantiate(towerPrefab, tileTransform.position, Quaternion.identity);
        clone.GetComponent<TowerWeapon>().Setup(enemySpawner);
    }
}
