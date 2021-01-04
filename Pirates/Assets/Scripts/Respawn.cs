using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   public  Transform spawnPoint;

    public void Spawn(Transform player)
    {
        player.rotation = spawnPoint.rotation;
        player.position = spawnPoint.position;

    }

}
