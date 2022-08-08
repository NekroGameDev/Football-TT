using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyAdd : MonoBehaviour
{
    [SerializeField] private GameObject _objectToDestroy;
    [SerializeField] private string _tag;

    private int _allMoney;

    public float StartTime;
    public float EndTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_tag))
        {
            Destroy(_objectToDestroy);
            _allMoney += Random.Range(1,3);
            MoneyManager.Money += _allMoney;
        }

    }
    private void FixedUpdate()
    {
        StartTime += 3f * Time.deltaTime;
        if (StartTime >= EndTime)
        {
            Destroy(_objectToDestroy);
        }
    }
}
