using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComponent : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private GameObject[] _prefab;
    [SerializeField] private float _rangeX;
    [SerializeField] private float _rangeXNegative;
    [SerializeField] private float _rangeY;
    [SerializeField] private float _rangeYNegative;

    public float Speed;

    [ContextMenu("SpawnAndShoot")]

    private void Start()
    {
        StartCoroutine(SpawnAndShoot());
    }

    private void Repeat()
    {
        StartCoroutine(SpawnAndShoot());
    }

     IEnumerator SpawnAndShoot() 
    {
        yield return new WaitForSeconds(Random.Range(1,5));
        int index = Random.Range(0, _prefab.Length);
        GameObject ball = Instantiate(_prefab[index], _target.transform.position, Quaternion.identity );

        ball.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-_rangeXNegative, _rangeX), Random.Range(-_rangeYNegative, _rangeY), -Speed));
        Repeat();
    }

}
