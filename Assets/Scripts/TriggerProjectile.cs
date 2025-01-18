using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private GameObject[] projectiles; // Array to hold references to all prefabs
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate each projectile in the array
            foreach (GameObject proj in projectiles)
            {
                if (proj != null)
                {
                    proj.SetActive(true);
                }
            }
        }
    }
}
