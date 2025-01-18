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
        transform.Rotate(xRotation,yRotation,zRotation);
    }
}
