using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    [SerializeField] Transform player;

    public Transform gunHandle;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        gunHandle.LookAt(player);
        gunHandle.transform.Rotate(0, 90, 90);
    }

}
