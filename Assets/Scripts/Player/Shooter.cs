using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletSpawn;
    [SerializeField] private Transform _target;
    [SerializeField] private float _bulletSpeed;

    public void Shoot()
    {
        Debug.Log("///");
        GameObject currentBullet = Instantiate(_bullet, _bulletSpawn.position, Quaternion.identity);
        Rigidbody2D bulletVelocity = currentBullet.GetComponent<Rigidbody2D>();

        if (_target.localScale.x >= 0)
        {
            bulletVelocity.velocity = new Vector2(_bulletSpeed * 1, bulletVelocity.velocity.y); 
        }
        else
        {
            bulletVelocity.velocity = new Vector2(_bulletSpeed * -1, bulletVelocity.velocity.y);
        }
    }
}
