using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLife : MonoBehaviour {

    public float initialRadius = 1.0f;
    public float propagationSpeed = 1.0f;
    public float lifetime = 2.0f;

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(initialRadius, initialRadius, 0);
        Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.localScale += transform.localScale * propagationSpeed * Time.deltaTime;
	}


    void OnTriggerStay2D(Collider2D other) {
        Debug.Log(other.transform.position);
    }
    //void WaitAndDestroy()
    //{
    //    yield WaitForSeconds(lifetime);
    //    Destroy(gameObject);
    //}
}
