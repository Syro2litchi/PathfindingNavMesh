using FMODUnity;
using UnityEngine;

namespace PlayerScripts
{
    public class PlayerGunRaycast : MonoBehaviour
    {
        [SerializeField] private GameObject muzzleFlash;
        [SerializeField] private GameObject hitWall;
        [SerializeField] private GameObject hitBot;

        [SerializeField] private EventReference gunShot;
        
        public bool fire;

        // Update is called once per frame
        void Update()
        {
            if (fire)
            {
                Fire();
            }
        }

        private void Fire()
        {
            FmodAudioManager.Instance.Play(gunShot, false, gameObject);
            fire = false;
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 20))
            {
                Instantiate(muzzleFlash, gameObject.transform.position, Quaternion.identity);
                
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("IA"))
                {
                    Instantiate(hitBot, hit.point, Quaternion.identity);
                    Destroy(hit.transform.gameObject, 0.1f);
                }
                else
                {
                    Instantiate(hitWall, hit.point, Quaternion.identity);
                }
            }
        }
    }
}