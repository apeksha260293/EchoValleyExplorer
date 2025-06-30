using UnityEngine;

public class CrystalPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Update the crystal count text
            GameManager.instance.CollectCrystal();

            // Notify the GameWinManager to see if we won
            GameObject.FindObjectOfType<GameWinManager>().CollectCrystal();

            // Destroy the crystal
            Destroy(gameObject);
        }
    }
}
