using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed;

    private Vector2 movementValue;
    private float lookValue;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnMove(InputValue inputValue)
    {
        movementValue = inputValue.Get<Vector2>() * speed;
    }

    public void OnLook(InputValue inputValue)
    {
        lookValue = inputValue.Get<Vector2>().x * rotationSpeed;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime);
        transform.Rotate(0, lookValue * Time.deltaTime, 0);
    }
}
