using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovment : MonoBehaviour

{
    public GameObject g1;              // reference object
    public GameObject[] monster;       // monster prefabs

    Vector3 location;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0f, 2f));

            location.x = g1.transform.position.x + Random.Range(-2.5f, 2.5f);
            location.y = g1.transform.position.y + Random.Range(8f, 10f);
            location.z = g1.transform.position.z;

            Instantiate(monster[0], location, Quaternion.identity);
        }
    }
}
