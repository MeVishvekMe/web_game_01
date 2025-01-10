using UnityEngine;

public class UserInput : MonoBehaviour {
    private InputActions _inputActions;

    private void Awake() {
        _inputActions = new InputActions();
    }

    private void OnEnable() {
        _inputActions.Enable();
    }

    private void OnDisable() {
        _inputActions.Disable();
    }

    public Vector2 PlayerOneUserInput() {
        return _inputActions.PlayerOne.Movement.ReadValue<Vector2>().normalized;
    }

    public Vector2 PlayerTwoUserInput() {
        return _inputActions.PlayerTwo.Movement.ReadValue<Vector2>().normalized;
    }
}
