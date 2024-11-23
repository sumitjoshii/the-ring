using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector2 _range;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _bonus;
    [SerializeField] private GameObject _red;

    private void Start(){
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnBonus());
        StartCoroutine(SpawnRed());

    }

    private IEnumerator SpawnEnemy(){
        yield return new WaitForSeconds(1.3f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnBonus(){
        yield return new WaitForSeconds(1.5f);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_bonus, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnBonus());
    }

    private IEnumerator SpawnRed(){
        yield return new WaitForSeconds(7);
        Vector2 spawnPos = transform.position + new Vector3(0, Random.Range(-_range.y, _range.y));
        Instantiate(_red, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnRed());
    }
}
