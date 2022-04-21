using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject[] balloonPrefab;
    public float spawningFrequency = 2f;
    public float xRange;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBalloon());
    }

    IEnumerator SpawnBalloon()
    {
        while (true)
        {
            float randomX = Random.Range(-xRange, xRange);
            Vector2 randomizedPosition = new Vector2(randomX, spawnPoint.position.y);

            Instantiate(balloonPrefab[Random.Range(0, balloonPrefab.Length)], randomizedPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawningFrequency);
        }
    }
}
