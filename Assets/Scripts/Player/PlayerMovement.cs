using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Controls _controls;
    private Rigidbody _rb;

    private void Awake()
    {
        _controls = new Controls();
        _rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void Update()
    {
        transform.eulerAngles += new Vector3(0f, 1f, 0f);
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}
