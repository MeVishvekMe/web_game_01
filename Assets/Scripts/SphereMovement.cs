using System;
using UnityEngine;

public class SphereMovement : MonoBehaviour {
    private Rigidbody _rb;
    [SerializeField] private float torqueValue = 20f;
    [SerializeField] private UserInput userInput;

    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }
    

    private void Update() {
        MovePlayer();
    }

    private void MovePlayer() {
        Vector3 torqueDirection = new Vector3(userInput.PlayerOneUserInput().y, 0f, -userInput.PlayerOneUserInput().x);
        _rb.AddTorque(torqueDirection * torqueValue * Time.deltaTime);
    }
}
