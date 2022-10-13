using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    [SerializeField] private float spawnDelay = 1f;

    private float[] Xpositions = { 10f, 0f, -10f };
    private float ZspawnPosition = 20f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), 0f, spawnDelay);
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        int positionIndex = Random.Range(0, Xpositions.Length);
        Instantiate(animals[animalIndex], new Vector3(Xpositions[positionIndex], 0f, ZspawnPosition), animals[animalIndex].transform.rotation);
    }
}
