using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletSpawn;
    [SerializeField] private float _bulletSpeed;


    public void Shoot(float direction)
    {
        GameObject currentBullet = Instantiate(_bullet, _bulletSpawn.position, Quaternion.identity);
        Rigidbody2D bulletVelocity = currentBullet.GetComponent<Rigidbody2D>();

        if (direction >= 0)
        {
            bulletVelocity.velocity = new Vector2(_bulletSpeed * 1, bulletVelocity.velocity.y); 
        }
        else
        {
            bulletVelocity.velocity = new Vector2(_bulletSpeed * -1, bulletVelocity.velocity.y);
        }
    }
}
