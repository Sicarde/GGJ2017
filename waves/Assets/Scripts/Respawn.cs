using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public GameObject spawnPoint;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Killzone"))
        {
            //TODO death feedback
            this.transform.position = spawnPoint.transform.position;
        }
        else if (collider.gameObject.CompareTag("Respawn"))
        {
            spawnPoint = collider.gameObject;
        }
    }
}
