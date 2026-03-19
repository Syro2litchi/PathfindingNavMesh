using UnityEngine;
using UnityEngine.Serialization;

namespace PlayerScripts
{
    public class PlayerGun : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private int bulletSpeed = 10;
        
        [SerializeField] private Vector3 _bulletDirectionVector;

        public bool fireGun;

        void Update()
        {
            _bulletDirectionVector = transform.InverseTransformDirection(transform.position);
            _bulletDirectionVector = new Vector3( - _bulletDirectionVector.x, _bulletDirectionVector.y, _bulletDirectionVector.z);
            
            if (fireGun)
                OnFire();
        }
        
        private void OnFire()
        {
            GameObject bullet = Instantiate(bulletPrefab, new Vector3(transform.position.x, 0.6f, transform.position.z + 0.5f), transform.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = _bulletDirectionVector;
            fireGun  = false;
            //new Vector3(0, 0, _bulletSpeed);
        }
    }
}
