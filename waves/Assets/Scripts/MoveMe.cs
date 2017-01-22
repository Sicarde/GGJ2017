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

    void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("trigger");
        Debug.Log(collider.gameObject.layer == LayerMask.NameToLayer("wave"));
        if (collider.gameObject.CompareTag("Player"))
        {
            //attachable = true;
            if (Input.GetButtonDown("Object"))
            {
                Debug.Log(collider.gameObject.name);
                attached = !attached;
                owner = collider.gameObject;
                offset = transform.position - owner.transform.position;
                if (attached)
                    audioSource.Play();
            }
        } else if (collider.gameObject.layer == LayerMask.NameToLayer("wave")) {
            spriteRenderer.enabled = true;
        }
    }

}
