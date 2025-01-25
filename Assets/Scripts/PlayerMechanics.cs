using System;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour {
    [SerializeField] private PlayerInputControl playerInputControl;
    [SerializeField] private float moveMagnitude = 20f;

    private Rigidbody2D _rb;
    
    private void Start() {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void SlashAttack(float inputMultiplier) {
        _rb.AddForce(Vector3.up * (inputMultiplier * 1000f), ForceMode2D.Impulse);
    }
}
