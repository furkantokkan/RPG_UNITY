using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    PlayerHealth playerHealth;
    private void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
    private void OnEnable()
    {
        playerHealth.Shielded = true;
    }
    private void OnDisable()
    {
        playerHealth.Shielded = false;
    }
}
