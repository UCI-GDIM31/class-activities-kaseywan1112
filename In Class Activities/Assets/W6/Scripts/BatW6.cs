using UnityEngine;

// Write the BatW6 class here.

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _playerTransform;

    private void Start()
    {
        enabled = false;
    }

    public void EnableChase(Transform player)
    {
        _playerTransform = player;
        enabled = true;
    }

    public void DisableChase()
    {
        enabled = false;
    }


    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed * Time.deltaTime
            );
    }
}
