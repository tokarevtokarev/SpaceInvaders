using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionTrigger = collision.gameObject;
        if (collisionTrigger.tag != "Player")
        {
            Destroy(collisionTrigger);
        }
    }
}
