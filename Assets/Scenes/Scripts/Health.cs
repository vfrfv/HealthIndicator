using System;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action<float> Changed;

    private float _degreeChange = 10;
    private float _currentHealth  = 50;

    public float MaxHealth { get; private set; } = 100;

    private void Start()
    {
        Changed?.Invoke(_currentHealth);
    }

    public void AddHealth()
    {
        if (_currentHealth < MaxHealth)
        {
            _currentHealth += _degreeChange;

            Changed?.Invoke(_currentHealth);
        }
    }

    public void ReduceHealth()
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= _degreeChange;

            Changed?.Invoke(_currentHealth);
        }
    }
}
