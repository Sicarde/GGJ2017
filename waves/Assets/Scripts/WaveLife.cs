using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveLife : MonoBehaviour {

    public float initialRadius = 1.0f;
    public float propagationSpeed = 1.0f;
    public float lifetime = 2.0f;
    public Material wallMaterial;
    public Material movableObjectMaterial;

    // Use this for initialization
    void Start () {
        transform.localScale = new Vector3(initialRadius, initialRadius, 0);
        Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.localScale += transform.localScale * propagationSpeed * Time.deltaTime;
        wallMaterial.SetFloat("_WaveSize", transform.localScale.x);
        wallMaterial.SetVector("_WaveOrigin", new Vector4(transform.position.x, transform.position.y, transform.position.z, 0.0f));
        movableObjectMaterial.SetFloat("_WaveSize", transform.localScale.x);
        movableObjectMaterial.SetVector("_WaveOrigin", new Vector4(transform.position.x, transform.position.y, transform.position.z, 0.0f));
    }

    void OnDestroy() {
        wallMaterial.SetFloat("_WaveSize", 0);
        movableObjectMaterial.SetFloat("_WaveSize", 0);
        Debug.Log(0);
    }

    //void WaitAndDestroy()
    //{
    //    yield WaitForSeconds(lifetime);
    //    Destroy(gameObject);
    //}
}
