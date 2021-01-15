using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    Animator explode;
    private Vector3 shootDir;

    //prevents water explosion and regular explosion from going off
    bool exploded;
   static float cannonRange;

    //if cannons hit nothing, a water splash is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(cannonRange);
        if (exploded == false)
        {
            GetComponent<Animator>().Play("WaterExplosion");
            FindObjectOfType<AudioManager>().Play("Water splash");
        }

        shootDir = Vector3.zero;

        //prevents the cannons from powerups colliding with the water splash
        this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        Destroy(gameObject, 1f);
    }

    //ammo int are as follows
    //0 - regular
    //1 -chainshot
    //2- grapeshot
    public void Setup(Vector3 shootDir, float range, int ammo)
    {
        this.shootDir = shootDir;
        explode = this.gameObject.GetComponent<Animator>();
        explode.SetInteger("CannonType", ammo);
        cannonRange = range;
    }


    private void Update()
    {

            float moveSpeed = 15f;
            transform.position += -shootDir * moveSpeed * Time.deltaTime;
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        explode.SetTrigger("Collision");
        exploded = true;
        shootDir = Vector3.zero; //stops cannonball from moving
        FindObjectOfType<AudioManager>().Play("Explode");
        Destroy(gameObject, 0.25f);
    }
}
