using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    [SerializeField] TMP_Text _text;
    [SerializeField] private Player _health;

    private float _maxHealth;

    private void Awake()
    {
        _maxHealth = _health.MaxHealth;
    }

    private void OnEnable()
    {
        _health.Changed += Show;
    }

    private void OnDisable()
    {
        _health.Changed -= Show;
    }

    private void Show(float currentValue)
    {
        _text.text = $"{currentValue} / {_maxHealth}";
    }
}
