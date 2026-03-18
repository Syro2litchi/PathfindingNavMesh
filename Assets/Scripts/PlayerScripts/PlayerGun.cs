using UnityEngine;

namespace PlayerScripts
{
    public class PlayerGun : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private int _bulletSpeed = 10;
        
        private Vector3 _bulletDirectionVector;

        void Update()
        {
            
            
            _bulletDirectionVector = transform.InverseTransformDirection(transform.position);
        }
        
        private void OnFire()
        {
            GameObject bullet = Instantiate(_bulletPrefab, new Vector3(transform.position.x, 0.6f, transform.position.z + 0.5f), transform.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, _bulletSpeed);
        }
    }
}
