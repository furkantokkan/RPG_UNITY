using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float time;
    void Start()
    {
        Destroy(this.gameObject,time);
    }


}
