using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public GameObject wavePrefab;
    public float cooldownDuration = 1.0f;//seconds
    public Material wallMaterial;
    public Material movableObjectMaterial;

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
        GameObject obj = Instantiate(wavePrefab, wavePos, Quaternion.identity);
        obj.GetComponent<WaveLife>().wallMaterial = wallMaterial;
        obj.GetComponent<WaveLife>().movableObjectMaterial = movableObjectMaterial;
        //Debug.Log(Input.mousePosition);
    }
}
