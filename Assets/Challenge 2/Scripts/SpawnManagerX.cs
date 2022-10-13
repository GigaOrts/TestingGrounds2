using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;
    private float maxSpawnInterval = 2f;

    void Start()
    {
        spawnInterval = Random.Range(1f, maxSpawnInterval);
        InvokeRepeating(nameof(SpawnRandomBall), startDelay, spawnInterval);
    }

    void SpawnRandomBall ()
    {
        float randomPosX = Random.Range(spawnLimitXLeft, spawnLimitXRight);
        Vector3 spawnPos = new Vector3(randomPosX, spawnPosY, 0);

        int randomBallIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[randomBallIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }
}