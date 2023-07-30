using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour
{
    public AudioClip clip;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("player collision");
        //Ignore Collision for Player or other bullets
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            //Destray self and other object, except walls
            Destroy(gameObject);
            if (collision.gameObject.tag != "Wall")
            {
                AudioSource.PlayClipAtPoint(clip, collision.transform.position);
                Destroy(collision.gameObject);
            }
        }
    }
}
