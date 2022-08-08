using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseRotate : MonoBehaviour
{
    private Vector3 pointScreen;
    private Vector3 offset;
    private float mass;

    private void OnMouseDown()
    {

        mass = GetComponent<Rigidbody>().mass;
        pointScreen = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z));

        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<Rigidbody>().mass = 0.0001f;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pointScreen.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;
    }

    private void OnMouseUp()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        gameObject.GetComponent<Rigidbody>().mass = mass;
    }
}
