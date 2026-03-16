using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _speedMultiplier;
    [SerializeField] private float _maxLinearVelocity;
    [SerializeField] private float _rotationSpeed;
    
    private Animator _animator;
    private Rigidbody _rb;
    
    public Vector2 move;
    public Vector2 look;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        _rb.maxLinearVelocity = _maxLinearVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = new Vector3(move.x, 0, move.y);
        Vector3 lookVector = new Vector3(look.x, 0, look.y);
        
        _rb.linearVelocity = moveVector * (Time.deltaTime * _speedMultiplier);

        Vector3 stickToLook = look.magnitude > 0.1f ? lookVector : moveVector;

        if (stickToLook.sqrMagnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(stickToLook);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * _rotationSpeed);
        }

        if (move == Vector2.zero)
        {
            _rb.linearVelocity = Vector3.zero;
        }
        
        Vector3 animatorTransform = transform.TransformDirection(moveVector);
        // float animatorTransform = _rb.linearVelocity.magnitude;
        if (stickToLook == lookVector)
        {
            _animator.SetFloat("Z", animatorTransform.magnitude - lookVector.magnitude);
        }
        else
        {
            _animator.SetFloat("Z", stickToLook.magnitude);
        }
        
    }
}