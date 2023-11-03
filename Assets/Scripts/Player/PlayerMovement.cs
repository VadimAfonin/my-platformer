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
    private SpriteRenderer _sprite;    

    private bool isGrounded = false;   

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
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
        _anim.SetFloat("Velocity", direction * _playerSpeed);
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
            _anim.SetFloat("Velocity", 0);
        }
        if (isGrounded)
        {
            _anim.SetBool("isJumping", false);
        }
        if (Input.GetKey(KeyCode.A))
        {        
            _anim.SetFloat("Velocity", -1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _sprite.flipX = false;           
            _anim.SetFloat("Velocity", 1);
        }       
    }
}
