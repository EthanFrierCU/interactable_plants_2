using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerScaler : MonoBehaviour
{
    public float scaleSpeed = 0.2f;
    private float tLerp = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(Mathf.Lerp(0.0f,1.0f,tLerp),Mathf.Lerp(0.0f,1.0f,tLerp),Mathf.Lerp(0.0f,1.0f,tLerp));
        tLerp += scaleSpeed * Time.deltaTime;
    }
}
