using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class BallKicker : MonoBehaviour
{
    [SerializeField] private float kickForce = 8f;
    [SerializeField] private Vector3 kickDirection = Vector3.forward;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        bool pressed = (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
            || (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame);

        if (pressed)
        {
            rb.AddForce(kickDirection.normalized * kickForce, ForceMode.Impulse);
        }
    }
}
