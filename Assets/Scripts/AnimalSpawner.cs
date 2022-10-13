using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject[] animals;
    [SerializeField] private float spawnDelay;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), 0f, spawnDelay);
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        int randomPosition = Random.Range(0, spawnPositions.Length);

        Instantiate(animals[animalIndex], 
            spawnPositions[randomPosition].position, 
            spawnPositions[randomPosition].rotation);
    }
}