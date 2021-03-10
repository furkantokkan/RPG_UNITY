using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMaterial : MonoBehaviour
{
    [SerializeField] private Material Disolve;
    void Start()
    {
        GetComponent<Renderer>().material = Disolve;
        GetComponent<SpawnEffect>().enabled = true;
    }
}
