using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusCreator : MonoBehaviour
{
    public GameObject cactusPrefab1;
    public int rotationDeg = 20;
    public int cactusloopsize;
    public int timerA = 0;

    // Start is called before the first frame update
    void Start()
    {
        cactusloopsize = 180/rotationDeg; 

        for (int i = 0; i < cactusloopsize; i++) {
            GameObject cactusSlice = Instantiate(cactusPrefab1, transform);
            cactusSlice.transform.localPosition = new Vector3(0, 1, 0);
            cactusSlice.transform.localEulerAngles = new Vector3(0, i*rotationDeg, 0);
            cactusSlice.GetComponent<Renderer>().material.color = new Color(Random.Range(0.1f,0.3f), Random.Range(0.3f,0.6f), Random.Range(0.1f,0.3f), 100);
            // cactusSlice.transform.parent = transform;
            cactusSlice.transform.localPosition = new Vector3(0,1,0);
            cactusSlice.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timerA += 1;

        foreach (Transform child in transform)
		{
		    if ( timerA < child.localEulerAngles.y ) {
				child.gameObject.SetActive(false);
		    } else {
				child.gameObject.SetActive(true);
		    }
        }
    }
}
