using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemysSpawnerZone : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private EnemySpawnerPoint[] _points;

    private void Start()
    {
        StartCoroutine(SpawnAllEnemys());
    }

    private IEnumerator SpawnAllEnemys()
    {
        var secondsForWait = new WaitForSeconds(2f);

        foreach (EnemySpawnerPoint point in _points)
        {
            point.SpawnEnemy();
            yield return secondsForWait;
        }
    }
}
