using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 3f;

    private MeshRenderer _myMeshRenderer;
    private Rigidbody _myRigidbody;

    private void Start()
    {
        _myMeshRenderer = GetComponent<MeshRenderer>();
        _myRigidbody = GetComponent<Rigidbody>();
        _myMeshRenderer.enabled = false;
        _myRigidbody.useGravity = false;
        
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            _myMeshRenderer.enabled = true;
            _myRigidbody.useGravity = true;
        }
    }
}
