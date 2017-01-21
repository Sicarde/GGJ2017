using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public GameObject wavePrefab;
    public float cooldownDuration = 1.0f;//seconds

    private float lastWave = -1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= lastWave + cooldownDuration && Input.GetButtonDown("Wave"))
        {
            lastWave = Time.time;
            StartWave();
        }
    }

    void StartWave()
    {
        Vector3 wavePos = new Vector3(transform.position.x, transform.position.y, 0);
        Instantiate(wavePrefab, wavePos, Quaternion.identity);
        //Debug.Log(Input.mousePosition);
    }
}
