using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xRotation;
    [SerializeField] private float yRotation;
    [SerializeField] private float zRotation;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Rotate(Time.deltaTime * xRotation,Time.deltaTime * yRotation,Time.deltaTime * zRotation);
    }
}
