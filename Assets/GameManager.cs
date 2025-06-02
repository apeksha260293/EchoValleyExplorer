using UnityEngine;
using TMPro; // Make sure TextMeshPro is imported

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI crystalText;

    private int crystalCount = 0;

    void Awake()
    {
        instance = this;
    }

    public void CollectCrystal()
    {
        crystalCount++;
        crystalText.text = "Crystals Collected: " + crystalCount + " / 10";
    }
}