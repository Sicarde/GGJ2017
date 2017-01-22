using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour {

    //private bool attachable = false;
    private bool attached = false;
    private Vector3 offset;
    private GameObject owner;
    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;
    public bool isFlyable = false;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (attached)//a coroutine would be better
            transform.position = owner.transform.position + offset;
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.layer == LayerMask.NameToLayer("wave"))
        {
            spriteRenderer.enabled = true;
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            //attachable = true;
            if (Input.GetButtonDown("Object") && isFlyable)
            {
                Debug.Log(collider.gameObject.name);
                attached = !attached;
                if (attached)
                {
                    audioSource.Play();
                    owner = collider.gameObject;
                    offset = transform.position - owner.transform.position;
                }
            }
        }
    }

}
