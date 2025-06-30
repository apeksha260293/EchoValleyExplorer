using TMPro;
using UnityEngine;

public class GameWinManager : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public GameTimer gameTimer;
    public int totalCrystals = 5;
    private int collectedCrystals = 0;

    public void CollectCrystal()
    {
        collectedCrystals++;
        if (collectedCrystals >= totalCrystals)
        {
            winText.text = "You Win!";
            winText.gameObject.SetActive(true);
            gameTimer.StopTimer();
        }
    }
}
