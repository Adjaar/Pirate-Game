using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    Animator explode;
    private Vector3 shootDir;
   static float cannonRange;

    //if cannons hit nothing, a water splash is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(cannonRange);
        GetComponent<Animator>().Play("WaterExplosion");
        shootDir = Vector3.zero;
        Destroy(gameObject, 1f);
    }
    public void Setup(Vector3 shootDir, float range)
    {
        this.shootDir = shootDir;
        explode = this.gameObject.GetComponent<Animator>();
        cannonRange = range;
    }


    private void Update()
    {

            float moveSpeed = 15f;
            transform.position += -shootDir * moveSpeed * Time.deltaTime;
           // Destroy(gameObject, 1f);
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        explode.SetTrigger("Collision");
        shootDir = Vector3.zero; //stops cannonball from moving
        Destroy(gameObject, 0.25f);
    }
}
