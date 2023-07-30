using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("player collision");
        //Ignore Collision for Player or other bullets
        if (collision.gameObject.tag == "Monster" || collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            //Destray self and other object, except walls
            Destroy(gameObject);
            if (collision.gameObject.tag != "Wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
