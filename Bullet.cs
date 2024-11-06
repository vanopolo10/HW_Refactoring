using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Shoot(Vector3 direction, float speed)
    {
        _rigidbody.linearVelocity = direction * speed;
    }
}