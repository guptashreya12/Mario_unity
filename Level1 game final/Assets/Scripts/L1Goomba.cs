using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Goomba : MonoBehaviour
{
    public Sprite flatSprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag("Player"))
       {
          if(collision.transform.DotTest(transform, Vector2.down)){
              Flatten();
          }
       }
    }
    private void Flatten(){
      GetComponent<Collider2D>().enabled = false;
      GetComponent<L1EntityMovement>().enabled = false;
      GetComponent<L1AnimatedSprite>().enabled = false;
      GetComponent<SpriteRenderer>().enabled = flatSprite;
      Destroy(gameObject, 0.5f);
    }
}
