using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    private Vector3 _playerPos;
    [SerializeField] int obstacleSpeed;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        _playerPos = player.transform.position;
    }
    
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerPos, Time.deltaTime * obstacleSpeed);
    }

    void DestroyWhenReached()
    {
        if (transform.position == _playerPos)
        {
            Destroy(gameObject);
        }
    }
    
}
