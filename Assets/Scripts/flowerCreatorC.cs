﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerCreatorC : MonoBehaviour
{
    public GameObject flowerPrefabC;
    public int rotationDeg = 20;
    public int flowerLoopSize;
    public float startPos = 30;
    public float endPos = 0.0f;
    public float bloomSpeed = 0.2f;
    private float fLerp = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        flowerLoopSize = 360/rotationDeg;
        for (int i = 0; i < flowerLoopSize; i++) {
            GameObject flowerPedalC = Instantiate(flowerPrefabC, this.transform);
            flowerPedalC.transform.localPosition = new Vector3(0, 2, 0);
            flowerPedalC.transform.localEulerAngles = new Vector3(0,i*rotationDeg,startPos);
            // flowerPedalC.transform.parent = transform;
            flowerPedalC.transform.localPosition = new Vector3(0,0,0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        fLerp += bloomSpeed * Time.deltaTime;
        foreach (Transform child in transform) {
            float tempAngle = child.localEulerAngles.y;
            child.transform.localEulerAngles = new Vector3(0, tempAngle, Mathf.Lerp(startPos,endPos,fLerp));
        }
    }
}
