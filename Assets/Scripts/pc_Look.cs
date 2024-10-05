using UnityEngine;
using UnityEngine.InputSystem;

public class pc_Look : MonoBehaviour
{
    private InputAction lookAction;
    private Vector2 lookDir;


    private void Awake()
    {
        lookAction = InputSystem.actions.FindAction("Look");
    }

    private void Update()
    {
        lookDir = lookAction.ReadValue<Vector2>();
        if (lookAction.inProgress){
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg,
                transform.eulerAngles.z
            );
        }
    }
}