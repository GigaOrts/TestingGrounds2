using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    [SerializeField] private float countdown = 2f;

    private float[] positions = { 10f, 0f, -10f };
    private float spawnPositionZ = 20f;
    private float spawnDelay = 1f;

    private void Update()
    {
        Invoke("SpawnRandomAnimal", spawnDelay);
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        int positionIndex = Random.Range(0, positions.Length);
        Instantiate(animals[animalIndex], new Vector3(positions[positionIndex], 0f, spawnPositionZ), animals[animalIndex].transform.rotation);
    }
}
