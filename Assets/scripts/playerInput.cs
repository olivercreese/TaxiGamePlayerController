using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isBoost;

    public InputAction boost;

    public void OnEnable()
    {
        boost.Enable();
        boost.performed+=OnBoost;
        boost.canceled+=OnBoost;
    }
    public void OnDisable()
    {
        boost.performed-=OnBoost;
        boost.canceled-=OnBoost;
        boost.Disable();
    }

    private void OnBoost(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            isBoost = true;
        }
        else if (ctx.canceled)
        {
            isBoost = false;
        }
    }

    private void FixedUpdate()
    {
        if (isBoost)
        {
            Debug.Log("Boosting");
        }
        else if (!isBoost)
        {
            Debug.Log("Not Boosting");
        }
    }
}
