using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemysSpawnerZone : MonoBehaviour
{
    [SerializeField] private Transform _path;

    private Transform[] _points;

    void Start()
    {    
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }

        StartCoroutine(SpawnAllEnemys());
    }

    private IEnumerator SpawnAllEnemys()
    {
        var secondsForWait = new WaitForSeconds(2f);

        foreach (Transform pont in _points)
        {
            EnemySpawnerPoint _enemySpawnerPoint = pont.GetComponent<EnemySpawnerPoint>();
            _enemySpawnerPoint.SpawnEnemy();
            yield return secondsForWait;
        }  
    }
}
