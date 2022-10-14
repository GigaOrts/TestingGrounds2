using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private int amountToBeFed;

    private int currentFedAmount = 0;
    private GameController game;

    private void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        game = FindObjectOfType<GameController>().GetComponent<GameController>();
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            game.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}