using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    [SerializeField] private Transform cannonBall;
    Rigidbody2D rb;

    public void Fire(Vector3 broadside, Vector3 endPoint)
    {
        rb = Instantiate(rb, broadside, Quaternion.identity);
        Vector3 shootDir = (broadside - endPoint).normalized;
       rb.GetComponent<CannonBall>().Setup(shootDir);
    }

}
