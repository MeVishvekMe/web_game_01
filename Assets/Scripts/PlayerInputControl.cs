using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInputControl : MonoBehaviour {
    [SerializeField] private Button slashButton;
    [SerializeField] private PlayerMechanics playerMechanics;
    private bool _isHolding = false;
    private float _currentHoldingValue;

    private void Update() {
        if (!_isHolding) return;
        
        _currentHoldingValue += Time.deltaTime;
        if (_currentHoldingValue >= 2f) {
            OnPointerUp();
        }
    }

    public bool GetIsHolding() {
        return _isHolding;
    }

    public float GetCurrentHoldingValue() {
        return _currentHoldingValue;
    }

    public void OnPointerUp() {
        _isHolding = false;
        playerMechanics.SlashAttack(_currentHoldingValue);
        _currentHoldingValue = 0f;
    }
    
    public void OnPointerDown() {
        _isHolding = true;
        _currentHoldingValue = 0f;
    }
}
