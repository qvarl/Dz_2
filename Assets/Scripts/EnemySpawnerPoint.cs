using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]

public class EnemySpawnerPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    public void SpawnEnemy()
    { 
        Instantiate(_enemy, _transform.position, Quaternion.identity);
    }
}
