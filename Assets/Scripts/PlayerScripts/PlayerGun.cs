using FMODUnity;
using UnityEngine;
using UnityEngine.Serialization;

namespace PlayerScripts
{
    public class PlayerGun : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private int bulletSpeed = 10;
        
        [SerializeField] private Vector3 bulletDirectionVector;

        [SerializeField] private EventReference gunShot;
        

        public bool fireGun;

        void Update()
        {
            bulletDirectionVector = transform.InverseTransformDirection(transform.position);
            bulletDirectionVector = new Vector3( - bulletDirectionVector.x, bulletDirectionVector.y, bulletDirectionVector.z);
            
            if (fireGun)
                OnFire();
        }
        
        private void OnFire()
        {
            FmodAudioManager.Instance.Play(gunShot);
            GameObject bullet = Instantiate(bulletPrefab, new Vector3(transform.position.x, 0.6f, transform.position.z + 0.5f), transform.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = bulletDirectionVector;
            fireGun  = false;
            //new Vector3(0, 0, _bulletSpeed);
        }
    }
}
