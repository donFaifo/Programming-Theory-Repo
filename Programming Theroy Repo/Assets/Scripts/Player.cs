using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    public float movementSpeed;
    public float jumpStrength;
    public float rotationSpeed;
    public int maximumLife;
    
    private Rigidbody _playerRb;
    [SerializeField] private bool isGrounded;
    private InputAction _moveAction;
    private InputAction _jumpAction;
    private InputAction _lookAction;

    private void Start()
    {
        MaximumLife = maximumLife;
        Speed = movementSpeed;
        RotationSpeed = rotationSpeed;
        JumpStrength = jumpStrength;
        _playerRb = GetComponent<Rigidbody>();
        isGrounded = true;
        _moveAction = InputSystem.actions.FindAction("Move");
        _jumpAction = InputSystem.actions.FindAction("Jump");
        _lookAction = InputSystem.actions.FindAction("Look");

    }

    protected override void UseAbility()
    {
        // Use Ability
    }

    private void Update() {
        var moveValue = _moveAction.ReadValue<Vector2>();
        var lookValue = _lookAction.ReadValue<Vector2>();

        transform.Translate(Time.deltaTime*moveValue.x, 0, Time.deltaTime*moveValue.y);
        transform.Rotate(0,RotationSpeed*lookValue.x,0);

        if (isGrounded && _jumpAction.triggered) Jump(); // ABSTRACTION

    }
    
    private void FixedUpdate() {
    
        transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.layer == 12) {
            
            isGrounded = true;
        }
    }

    private void Jump()
    {
        _playerRb.AddForce(0,JumpStrength*100,0);
        isGrounded = false;
    }
}
