using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    public float movementSpeed;
    public float jumpStrength;
    public float rotationSpeed;
    public int maximumLife;
    
    private Rigidbody playerRb;
    [SerializeField] private bool isGrounded;
    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction lookAction;

    private void Start()
    {
        MaximumLife = maximumLife;
        Speed = movementSpeed;
        RotationSpeed = rotationSpeed;
        JumpStrength = jumpStrength;
        playerRb = GetComponent<Rigidbody>();
        isGrounded = true;
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        lookAction = InputSystem.actions.FindAction("Look");

    }

    protected override void UseHability()
    {
        // Use Hability
    }

    private void Update() {
        var moveValue = moveAction.ReadValue<Vector2>();
        var lookValue = lookAction.ReadValue<Vector2>();

        transform.Translate(Time.deltaTime*moveValue.x, 0, Time.deltaTime*moveValue.y);
        transform.Rotate(0,RotationSpeed*lookValue.x,0);

        if (isGrounded && jumpAction.triggered)
        {
            playerRb.AddForce(0,JumpStrength*100,0);
            isGrounded = false;
        }
        


    }
    
    private void FixedUpdate() {
    
        transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.layer == 12) {
            
            isGrounded = true;
        }
    }
}
