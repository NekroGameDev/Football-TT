using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveScore : MonoBehaviour
{
    [SerializeField] private GameObject _objectToDestroy;
    [SerializeField] private string _tag;

    public float StartTime;
    public float EndTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_tag))
        {
            Destroy(_objectToDestroy);
            ProgressBarController.value -= 15;
            if (ProgressBarController.value <= ProgressBarController.minValue)
            {
                ProgressBarController.value = 0;
            }
        }

    }

    private void FixedUpdate()
    {
        StartTime += 3f * Time.deltaTime;
        if(StartTime >= EndTime)
        {
            Destroy(_objectToDestroy);
        }
    }
}
