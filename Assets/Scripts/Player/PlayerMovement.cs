using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Vars")]
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _jumpOffset;
    [SerializeField] private float _playerSpeed;

    [Header("Settings")]
    [SerializeField] private Transform _playerColliderTransform;
    [SerializeField] private LayerMask _groundLayer;    

    private Rigidbody2D rb;
    private Animator _anim;

    private bool isGrounded = false;   
    public int lastDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }    

    public void Move(float direction, bool isSpacePressed)
    {
        if (isSpacePressed)
        {
            Jump();
        }

        if (direction != 0)
        {
            Movement(direction);
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, _jumpPower);
            _anim.SetBool("isJumping", true);            
        }       
    }

    private void Movement(float direction)
    {
        rb.velocity = new Vector2(direction * _playerSpeed, rb.velocity.y);
        //_anim.SetFloat("Velocity", direction * _playerSpeed);
    }    

    private void FixedUpdate()
    {
        Vector3 overlapTransform = _playerColliderTransform.position;
        isGrounded = Physics2D.OverlapCircle(overlapTransform, _jumpOffset, _groundLayer);
    }    

    private void Update()
    {
        if (Mathf.Abs(rb.velocity.x) < 0.1f)
        {
            _anim.SetBool("isRunning", false);
        }
        if (isGrounded)
        {
            _anim.SetBool("isJumping", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _anim.SetBool("isRunning", true);
            lastDirection = -1;
            _playerColliderTransform.localScale = new Vector2(lastDirection, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _anim.SetBool("isRunning", true);
            lastDirection = 1;
            _playerColliderTransform.localScale = new Vector2(lastDirection, 1);
        }
    }
}
