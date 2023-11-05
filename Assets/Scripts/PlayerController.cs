using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.5f;

    // References
    private Rigidbody2D _rigidbody;

    // Movement
    private Vector2 _movment;
    private bool _isFacingRight = true;

    // Attack
    private bool _isAttacking;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_isAttacking == false)
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            _movment = new Vector2(horizontalInput, verticalInput);
        }
    }

    private void FixedUpdate()
    {
        if ( _isAttacking == false)
        {
            float horizontalVelocity = _movment.normalized.x * speed;
            float verticalVelocity = _movment.normalized.y * speed;
            _rigidbody.velocity = new Vector2(horizontalVelocity, verticalVelocity);
        }
    }
}
