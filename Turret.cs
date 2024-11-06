using System.Collections;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Transform _target;
    [SerializeField] private float _shootdelay;

    private void Start() 
    {
        StartCoroutine(Shoot());
    }
    
    private IEnumerator Shoot()
    {
        while (enabled)
        {
            Vector3 shootDirection = (_target.position - transform.position).normalized;
            Bullet bullet = Instantiate(_bulletPrefab, transform.position + shootDirection, Quaternion.identity);

            bullet.transform.forward = shootDirection;
            bullet.Shoot(shootDirection, _bulletSpeed);

            yield return new WaitForSeconds(_shootdelay);
        }
    }
}