using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerScripts
{
    public class PlayerInputs : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
    
        private PlayerInput _playerInputs;
        private PlayerController _playerController;

        void Awake()
        {
            _playerInputs = _player.GetComponent<PlayerInput>();
            _playerController = _player.GetComponent<PlayerController>();
        }

        private void OnMove(InputValue valeur)
        {
            _playerController.move = valeur.Get<Vector2>();
        }

        private void OnLook(InputValue valeur)
        {
            _playerController.look = valeur.Get<Vector2>();
        }
    }
}

