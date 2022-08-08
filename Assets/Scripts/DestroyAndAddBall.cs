using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndAddBall : MonoBehaviour
{
    [SerializeField] private GameObject _objectToDestroy;
    [SerializeField] private string _tag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_tag))
        {
            Destroy(_objectToDestroy);
            ProgressBarController.value += 100;

            if(ProgressBarController.value >= ProgressBarController.maxValue)
            {
                ProgressBarController.value = 100;
            }
        }
        if (other.gameObject.CompareTag("Miss"))
        {
            Destroy(_objectToDestroy);

            if (ProgressBarController.value == 0)
            {
                ProgressBarController.value -= 0;
            }
            else
            {
                ProgressBarController.value -= 2;
            }
        }

    }

}

