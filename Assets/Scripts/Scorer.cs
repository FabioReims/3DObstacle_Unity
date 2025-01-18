using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("You've collided with " + hits + " objects.");
    }
}
