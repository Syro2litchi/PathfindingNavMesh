using UnityEngine;
using UnityEngine.InputSystem;

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
    
    void OnEnable()
    {
        _playerInputs.actions["Move"].performed += OnMove;
        _playerInputs.actions["Move"].canceled += OnMove;
    }

    void OnDisable()
    {
        _playerInputs.actions["Move"].performed -= OnMove;
        _playerInputs.actions["Move"].canceled -= OnMove;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _playerController.move = context.ReadValue<Vector2>();
    }
}
