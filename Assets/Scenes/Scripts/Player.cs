using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action<float> Changed;

    private float _degreeChange = 10;
    private float _currentHealth = 50;

    public float MaxHealth { get; private set; } = 100;

    private void Start()
    {
        Changed?.Invoke(_currentHealth);
    }

    public void Health()
    {
        float health = _currentHealth + _degreeChange;

        if (_currentHealth < MaxHealth)
        {
            if (_currentHealth + _degreeChange > MaxHealth)
            {
                _currentHealth = MaxHealth;
            }

            _currentHealth += _degreeChange;

            Changed?.Invoke(_currentHealth);
        }
    }

    public void Damage()
    {
        if (_currentHealth > 0)
        {
            if(_currentHealth - _degreeChange < 0)
            {
                _currentHealth = 0;
            }

            _currentHealth -= _degreeChange;

            Changed?.Invoke(_currentHealth);
        }
    }
}
