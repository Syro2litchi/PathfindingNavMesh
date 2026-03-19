using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerScripts
{
    public class PlayerInputs : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
    
        private PlayerInput _playerInputs;
        private PlayerGun _gun;
        private PlayerGunRaycast _gunRaycast;
        private PlayerController _playerController;

        void Awake()
        {
            _playerInputs = _player.GetComponent<PlayerInput>();
            _playerController = _player.GetComponent<PlayerController>();
            _gun = _player.GetComponentInChildren<PlayerGun>();
            _gunRaycast = _player.GetComponentInChildren<PlayerGunRaycast>();
        }

        private void OnMove(InputValue valeur)
        {
            _playerController.move = valeur.Get<Vector2>();
        }

        private void OnLook(InputValue valeur)
        {
            _playerController.look = valeur.Get<Vector2>();
        }

        private void OnFire(InputValue valeur)
        {
            _gun.fireGun = true;
            _gunRaycast.fire = true;
        }
    }
}