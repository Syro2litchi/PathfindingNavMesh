using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _speedMultiplier;
    [SerializeField] private float _maxLinearVelocity;
    
    private Animator _animator;
    private Rigidbody _rb;
    
    public Vector2 move;

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
        Move();
        _animator.SetFloat("Z", move.y);
    }

    private void Move()
    {
        _rb.linearVelocity = new Vector3(move.x, 0, move.y) * (Time.deltaTime * _speedMultiplier);

        gameObject.transform.rotation = Quaternion.Euler(0, move.x/move.y, 0);

        if (move == Vector2.zero)
        {
            _rb.linearVelocity = Vector3.zero;
        }
    }
}