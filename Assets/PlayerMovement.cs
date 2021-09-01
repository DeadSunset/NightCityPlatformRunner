using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 6f;
    public float maxJumpForce = 8f;

    private float _speed;
    private Vector2 _move = new Vector2();

    private Rigidbody2D _rb;
    private bool _isFacingRight = true;
    void Start()
    {
        _speed = 0;
        _rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _speed = Input.GetAxis("Horizontal");

        if (_speed < 0 && _isFacingRight)
        {
            Flip();
        }
        else if (_speed > 0 && !_isFacingRight)
        {
            Flip();
        }

        _rb.velocity = new Vector2(_speed * maxSpeed, _rb.velocity.y);
        //_rb.MovePosition(new Vector2((gameObject.transform.position.x + _speed), gameObject.transform.position.y));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        _isFacingRight = !_isFacingRight;
    }

    void Jump()
    {
        _rb.AddForce(Vector2.up * maxJumpForce);
    }
}
