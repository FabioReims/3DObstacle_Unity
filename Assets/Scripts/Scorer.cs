using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _hits;
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit")){
            _hits++;
            Debug.Log("You've collided with "  + _hits + " objects.");
        }
    }
}
