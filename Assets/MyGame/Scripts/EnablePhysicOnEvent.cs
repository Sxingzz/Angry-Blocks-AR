using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePhysicOnEvent : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += StartPhysicOnButtonClicked;
        rb.isKinematic = true;
    }

    private void StartPhysicOnButtonClicked()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    private void OnDestroy()
    {
        UIButtonHandler.OnUIStartButtonClicked -= StartPhysicOnButtonClicked;
    }
}
