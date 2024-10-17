using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    private Camera mainCam;

    [SerializeField] private GameObject ballPrefabs;
    [SerializeField] private float ballFormatForce = 500f;


    private void Start()
    {
        mainCam = FindObjectOfType<Camera>();
        UIButtonHandler.OnUIShootButtonClicked += ShootBallOnButton;
    }

    private void ShootBallOnButton()
    {
        Vector3 spawnPosition = mainCam.transform.position + mainCam.transform.forward
                                                                               * 0.1f;
        Quaternion spawnRotation = mainCam.transform.rotation;

        GameObject spawnBall = Instantiate(ballPrefabs, spawnPosition, spawnRotation);
        Rigidbody rb = spawnBall.GetComponent<Rigidbody>();


        if (rb != null)
        {
            rb.AddForce(mainCam.transform.forward * ballFormatForce);
        }

        Destroy(spawnBall, 5f);
    }
}
