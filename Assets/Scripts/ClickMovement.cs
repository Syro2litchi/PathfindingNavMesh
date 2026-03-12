using UnityEngine;
using UnityEngine.InputSystem;

public class ClickMovement : MonoBehaviour
{
    private Transform _targetPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Transform OnClick()
    {
        _targetPosition.position = Input.mousePosition;
        
        return _targetPosition;
    }
}
