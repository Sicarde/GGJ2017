using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public GameObject wavePrefab;
    public float cooldownDuration = 1.0f;//seconds
    public Material wallMaterial;
    public Material buttonMaterial;
    public Material activatedButtonMaterial;

    private float lastWave = -1f;

	// Update is called once per frame
	void Update () {
        if (Time.time >= lastWave + cooldownDuration && Input.GetButtonDown("Wave") && !Menu.isGamePaused)
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
        obj.GetComponent<WaveLife>().buttonMaterial = buttonMaterial;
        obj.GetComponent<WaveLife>().activatedButtonMaterial = activatedButtonMaterial;
        //Debug.Log(Input.mousePosition);
    }
}
