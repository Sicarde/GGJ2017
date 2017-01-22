using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    public Material pressedButtonMaterial;
    public Sprite pressedButtonSprite;
    public bool isPressed = false;
    public GameObject objectToActivate;

    void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.gameObject.layer == LayerMask.NameToLayer("player") ||
            other.collider.gameObject.layer == LayerMask.NameToLayer("object")) {
            if (other.collider.transform.position.y > transform.position.y) {
                isPressed = true;
                GetComponent<SpriteRenderer>().material = pressedButtonMaterial;
                GetComponent<SpriteRenderer>().sprite = pressedButtonSprite;
                objectToActivate.SetActive(true);
            }
        }
    }
}
