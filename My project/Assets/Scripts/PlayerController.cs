using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private             InputAction move;
    private             Camera      mainCamera;

    [SerializeField]    float       speed = 5f;

    void Start()
    {
        move = InputSystem.actions.FindAction("Move");
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        DoMovement();
    }

    private void DoMovement()
    {
        Vector2 movementValue = move.ReadValue<Vector2>();

        Vector3 moveDirection = new Vector3(movementValue.x, 0f, movementValue.y);
        Vector3 cameraDirection = new Vector3(movementValue.x, 0f, 0f);
        transform.position += moveDirection * speed * Time.deltaTime;
        mainCamera.transform.position += cameraDirection * speed * Time.deltaTime;
    }
}
