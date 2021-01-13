using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Vector2 center;
    public Vector2 size;

    public GameObject[] powerupPrefab;
    public GameObject ammoPrefab;
    public GameObject crewPrefab;

    IEnumerator Start()
    {
        while (true)
        {
            int newPower = Random.Range(0, 4);
            yield return new WaitForSeconds(30);
            SpawnPower(newPower);
            SpawnAmmo();
            SpawnAmmo();
            SpawnAmmo();
            SpawnCrew();
        }

    }

    public void SpawnPower(int power)
    {
        Vector2 pos = center + new Vector2(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2));

        Instantiate(powerupPrefab[power], pos, Quaternion.identity);
    }

    public void SpawnAmmo()
    {
        Vector2 pos = center + new Vector2(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2));

        Instantiate(ammoPrefab, pos, Quaternion.identity);
    }

    public void SpawnCrew()
    {
        Vector2 pos = center + new Vector2(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2));

        Instantiate(crewPrefab, pos, Quaternion.identity);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
