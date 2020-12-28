using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{

    private Vector3 shootDir;
    
    public void Setup(Vector3 shootDir)
    {
        this.shootDir = shootDir;
    }

    private void Update()
    {

            float moveSpeed = 15f;
            transform.position += -shootDir * moveSpeed * Time.deltaTime;
            Destroy(gameObject, 1f);
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
