using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRawImage : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;

    RawImage myRawImage;
    void Start()
    {
        myRawImage = GetComponent<RawImage>();
    }

    
    void Update()
    {
        Rect currentUv = myRawImage.uvRect;
        currentUv.x -= Time.deltaTime * horizontalSpeed;
        currentUv.y -= Time.deltaTime * verticalSpeed;

        if (currentUv.x <= -1f || currentUv.x >= 1f)
        {
            currentUv.x = 0f;
        }

        if (currentUv.y <= -1f ||currentUv.y >= 1f)
        {
            currentUv.y = 0f;
        }

        myRawImage.uvRect = currentUv;
    }
}
