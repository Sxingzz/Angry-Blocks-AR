using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas AIMacgicbar;

    private void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += OnStartButtonClicked;
        UIButtonHandler.OnUIResetButtonClicked += OnResetButtonClicked;
    }

    private void OnStartButtonClicked()
    {
        AIMacgicbar.enabled = false;
    }

    private void OnResetButtonClicked()
    {
        AIMacgicbar.enabled = true;
    }
}
