using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    private Vector3 _playerPos;
    [SerializeField] int obstacleSpeed;
    void Start()
    {
        _playerPos = player.transform.position;
    }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerPos, Time.deltaTime * obstacleSpeed);
    }
}
