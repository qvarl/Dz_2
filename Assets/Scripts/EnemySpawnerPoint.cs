using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public void SpawnEnemy()
    { 
        Instantiate(_enemy, transform.position, Quaternion.identity);
    }
}
