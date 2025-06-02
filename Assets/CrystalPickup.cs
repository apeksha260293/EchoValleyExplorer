using UnityEngine;

public class CrystalPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CollectCrystal();
            Destroy(gameObject);
        }
    }
}