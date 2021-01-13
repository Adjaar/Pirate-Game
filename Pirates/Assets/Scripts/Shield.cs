using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public Transform ground;
    void Update()
    {
        Physics2D.IgnoreCollision(ground.GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
    }


}
